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
    public partial class Administrador : System.Web.UI.Page
    {
        NegocioTurnos NT = new NegocioTurnos();
        NegocioServicios NS = new NegocioServicios();



        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                // string usuarioLogueado = Session["Usuario"] as string;
                string usuarioLogueado = "Matias";
                string dniLogueado = "29315386";//Session["Dni"] as string;

                // Mostrar los valores obtenidos de la sesión
                lblUsuarioLogueado.Text = "Bienvenida/o " + usuarioLogueado;
           
                CargarTablaTurnos();
                CargarTablaServicios();
           }
            
        }

        public void CargarTablaTurnos()
        {
            DataTable tabla = NT.ObtenerTurnosAsignados();
            gvTurnosAsignados.DataSource = tabla;
            gvTurnosAsignados.DataBind();
        }

        public void CargarTablaServicios()
        {
            DataTable tabla = NS.ObtenerServicios();
            gvServicios.DataSource = tabla;
            gvServicios.DataBind();
        }

        protected void gvTurnosAsignados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = ((Label)gvTurnosAsignados.Rows[e.RowIndex].FindControl("lblNTurno")).Text;

            Turnos obj = new Turnos();
            obj.IdTurno = id;
            int fila = NT.EliminarTurno(obj);

            if (fila == 1)
            {
                string message = "Turno eliminado con exito! ";
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}');", true);

           //  ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"Swal.fire({{ icon: 'success', title: 'Turno eliminado con exito!', showConfirmButton: true }});", true);


            }
            else { MessageBox.Show("Error al eliminar Turno!"); }

            CargarTablaTurnos();
        }


        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;  //obtiene una referencia al CheckBox que disparó el evento
            GridViewRow fila = (GridViewRow)chk.NamingContainer;  //Obtener la fila del GridView que contiene el CheckBox

            CheckBox cBox = (CheckBox)fila.FindControl("chkbAsistencia");

            // Si se marco el check
            if (cBox.Checked)
            {
                string idTurno = ((Label)fila.FindControl("lblNTurno")).Text;
                string dia = ((Label)fila.FindControl("lblDia")).Text;
                string hora = ((Label)fila.FindControl("lblHora")).Text;
                string nombre = ((Label)fila.FindControl("lblNombre")).Text;

                int estado = NT.cambiarAsistencia(idTurno, dia, hora);
             
                if (estado == 1)
                {
                    string message = "Se CONFIRMO la asistencia del Cliente: " + nombre;
                    ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}');", true);
                   
                }
                else
                {
                    string message = "No se pudo cambiar la Asistencia del Cliente: " + nombre;
                    string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                    ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);
                }
            }


            //Si se desmarca el check
            else
            {
                string idTurno = ((Label)fila.FindControl("lblNTurno")).Text;
                string dia = ((Label)fila.FindControl("lblDia")).Text;
                string hora = ((Label)fila.FindControl("lblHora")).Text;
                string nombre = ((Label)fila.FindControl("lblNombre")).Text;


                int estado = NT.cambiarAsistencia(idTurno, dia, hora);
                if (estado == 1)
                {
                    string message = "Se CANCELO la asistencia del Cliente: " + nombre;
                    ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}');", true);
                }
                else {
                    string message = "No se pudo cambiar la Asistencia del Cliente: " + nombre;
                    string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                    ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);
                 
                    //   ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{HttpUtility.JavaScriptStringEncode("No se pudo cambiar la Asistencia del Cliente: " + nombre)}', 'error');", true);

                }
            }

            CargarTablaTurnos();
        }

        protected void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = "Matias";
            Session["Dni"] = "29315386";

            Response.Redirect("Servicios.aspx");
        }

        protected void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = "Matias"; 
            Session["Dni"] = "29315386";
            Response.Redirect("AgregarMoto.aspx");
        }

        protected void btnCliXMotos_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = "Matias";
            Session["Dni"] = "29315386";
            Response.Redirect("ClientesXMotos.aspx");
        }

        protected void btnIngresarFechas_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = "Matias";
            Session["Dni"] = "29315386";
            Response.Redirect("IngresarFechas.aspx");
        }
    }
}