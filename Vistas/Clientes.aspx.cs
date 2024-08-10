using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Vistas
{
    public partial class Clientes : System.Web.UI.Page
    {
        NegocioTurnos NT = new NegocioTurnos();
        NegocioMotos NM = new NegocioMotos();

        private string usuarioLogueado;
        private string dniLogueado;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            if (Session["Usuario"] != null)
            {
                usuarioLogueado = Session["Usuario"] as string;
                dniLogueado = Session["Dni"] as string;

                // Mostrar los valores obtenidos de la sesión
                lblUsuarioLogueado.Text = "Bienvenida/o " + usuarioLogueado;

            } else
            {
                string message = "Debe Ingresar o Registrase e Ingresar";
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}');", true);
               
                Response.Redirect("Ingresar.aspx"); }

            if (!IsPostBack)
            {
                mostrarTablaMotos(dniLogueado);
                mostrarTablaTurnos(dniLogueado);
            }
        }

            public void mostrarTablaMotos(string dni)
            {
                DataTable tabla = NM.ObtenerTablaMotos(dni);
                gvMisMotos.DataSource = tabla;
                gvMisMotos.DataBind();
            }

            protected void mostrarTablaTurnos(string dni)
            {
                DataTable tabla = NT.ObtenerTablaTurnos(dni);
                gvMisTurnos.DataSource = tabla;
                gvMisTurnos.DataBind();
            }

        protected void btnAgregarMoto_Click(object sender, EventArgs e)
        {
            Session["UrlPaginaPrevia"] = Request.UrlReferrer.ToString();
            Response.Redirect("AgregarMoto.aspx");
        }
        private void MostrarExito(string message)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', 'success');", true);
        }
        protected void gvMisMotos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string patente = ((Label)gvMisMotos.Rows[e.RowIndex].FindControl("lblPatente")).Text;
            Motos obj = new Motos { patente1 = patente };

            if (NM.EliminarMoto(obj) > 0)
            {
                MostrarExito("Se Elimino Moto!");
                mostrarTablaMotos(dniLogueado);
            }
        }
        private void MostrarError(string message)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', 'error');", true);
        }
        protected void gvMisTurnos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DateTime dia;
            TimeSpan hora;

            // Obtén el valor del Label para la fecha
            if (!DateTime.TryParse(((Label)gvMisTurnos.Rows[e.RowIndex].FindControl("lblFecha")).Text, out dia))
            {
                MostrarError("La fecha no es válida.");
                return;
            }

            // Obtén el valor del Label para la hora
            string hr = ((Label)gvMisTurnos.Rows[e.RowIndex].FindControl("lblHora")).Text;
            if (!TimeSpan.TryParse(hr, out hora))
            {
                MostrarError("La hora no es válida.");
                return;
            }

            // Intenta eliminar el turno
            int filasAfectadas = NT.EliminarTurnoCliente(dia, hora);
            if (filasAfectadas > 0)
            {
                MostrarExito("¡Se eliminó el turno exitosamente!");
                mostrarTablaTurnos(dniLogueado);

            }
            else
            {
                MostrarError("No se pudo eliminar el turno. Por favor, inténtelo de nuevo.");
            }


        }

    }
}