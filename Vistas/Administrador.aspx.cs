using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Web.Services;
using System.Web.Script.Services;

namespace Vistas
{
    public partial class Administrador : System.Web.UI.Page
    { 
        
        NegocioTurnos NT = new NegocioTurnos();
        NegocioServicios NS = new NegocioServicios();
        NegocioHistorial_X_Servicios NHXS = new NegocioHistorial_X_Servicios();
        NegocioHistorial NH = new NegocioHistorial();
        string usuarioLogueado;
        string dniLogueado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                usuarioLogueado = Session["Usuario"] as string;
                dniLogueado = Session["Dni"] as string;

                lblUsuarioLogueado.Text = "Bienvenida/o " + usuarioLogueado;

                ViewState["UsuarioLogueado"] = usuarioLogueado;
                ViewState["DniLogueado"] = dniLogueado;

                CargarTablaTurnos();
                CargarTablaServicios();
            }
            else
            {
                usuarioLogueado = ViewState["UsuarioLogueado"] as string;
                dniLogueado = ViewState["DniLogueado"] as string;
            }

        }

        private void CargarTablaTurnos()
        {
            DataTable tabla = NT.ObtenerTurnosAsignados();
            gvTurnosAsignados.DataSource = tabla;
            gvTurnosAsignados.DataBind();
        }

        private void CargarTablaServicios()
        {
            DataTable tabla = NS.ObtenerServicios();
            gvServicios.DataSource = tabla;
            gvServicios.DataBind();
        }
       
        [ScriptMethod]
        [WebMethod]
        public static void GuardarObservacion(string dni, DateTime dia, string patente, string observacion)
        {
            try
            {
                NegocioHistorial_X_Servicios NHXS = new NegocioHistorial_X_Servicios();

                NHXS.GuardaObservacion(dni, dia, patente, observacion);

            }
            catch (Exception ex)
            {
                // Manejo de error
                throw new Exception("Error al guardar la observación: " + ex.Message);
            }
        }


        protected void gvTurnosAsignados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = ((Label)gvTurnosAsignados.Rows[e.RowIndex].FindControl("lblNTurno")).Text;

            Turnos obj = new Turnos { IdTurno = id };
            int fila = NT.EliminarTurno(obj);

            string message = fila == 1 ? "Turno eliminado con exito!" : "Error al eliminar Turno!";
            string icon = fila == 1 ? "success" : "error";
            ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);

            CargarTablaTurnos();
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            GridViewRow fila = (GridViewRow)chk.NamingContainer;
            CheckBox cBox = (CheckBox)fila.FindControl("chkbAsistencia");

            if (cBox.Checked)
            {   
                string idTurno = ((Label)fila.FindControl("lblNTurno")).Text;
                string dia = ((Label)fila.FindControl("lblDia")).Text;
                string hora = ((Label)fila.FindControl("lblHora")).Text;
                string nombre = ((Label)fila.FindControl("lblNombre")).Text;
                TextBox txtKilometraje = (TextBox)fila.FindControl("txtKilometraje");
              // Turnos objTurno = NT.obtenerTurnoPorId(idTurno);

                if (txtKilometraje == null)
                {
                    MostrarError("No se encontró el campo de kilometraje.");
                    cBox.Checked = false;
                    return;
                }

                if (!int.TryParse(txtKilometraje.Text, out int kilometraje) || kilometraje <= 0)
                {
                    MostrarError("Por favor, ingrese un kilometraje válido antes de confirmar la asistencia.");
                    cBox.Checked = false;
                    return;
                }

              
                if (NT.cambiarAsistencia(idTurno, dia, hora) == 1)
                {
                    MostrarExito($"Se CONFIRMO la asistencia del Cliente: {nombre}");
                    Turnos objTurno = NT.obtenerTurnoPorId(idTurno);
                    Historial_X_Servicios obj = new Historial_X_Servicios();


                        obj.dni1 = objTurno.Dni;
                    obj.patente1 = objTurno.Patente;
                    obj.idServicio1 = objTurno.IdServicio;
                         obj.fecha_Realizacion1 = objTurno.Dia;
                    obj.idHistorial1 = NH.ObtenerIdHistorial(objTurno.Dni, objTurno.Patente);
                    obj.kilometraje1 = kilometraje;
                   
                    string cBoxClientID = cBox.ClientID;
                  
                    ScriptManager.RegisterStartupScript(this, GetType(), "showObservationPrompt", $"showObservationPrompt('{obj.dni1}', '{dia}', '{obj.patente1}', '{cBoxClientID}');", true);


                    NHXS.guardarHistorial(obj);
                }
            }
            else
            {
                string idTurno = ((Label)fila.FindControl("lblNTurno")).Text;
                string dia = ((Label)fila.FindControl("lblDia")).Text;
                string hora = ((Label)fila.FindControl("lblHora")).Text;
                string nombre = ((Label)fila.FindControl("lblNombre")).Text;

                if (NT.cambiarAsistencia(idTurno, dia, hora) > 0)
                {
                    MostrarExito($"Se CANCELO la asistencia del Cliente: {nombre}");

                    var (dni, patente) = NT.BuscarDnixIdTurno(idTurno, Convert.ToDateTime(dia));
                    NHXS.eliminarHistorialPorTurno(dni, Convert.ToDateTime(dia), patente);
                }
                else
                {
                    MostrarError($"No se pudo cambiar la Asistencia del Cliente: {nombre}");
                }
            }

            CargarTablaTurnos();
        }

        private void MostrarExito(string message)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', 'success');", true);
        }

        private void MostrarError(string message)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', 'error');", true);
        }

        protected void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            GuardarSesion();
            Response.Redirect("Servicios.aspx");
        }

        protected void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            GuardarSesion();
            Response.Redirect("ReservarTurno.aspx");
        }

        protected void btnCliXMotos_Click(object sender, EventArgs e)
        {
            GuardarSesion();
            Response.Redirect("ClientesXMotos.aspx");
        }

        protected void btnIngresarFechas_Click(object sender, EventArgs e)
        {
            GuardarSesion();
            Response.Redirect("Fechas.aspx");
        }

        private void GuardarSesion()
        {
            Session["UrlPaginaPrevia"] = Request.UrlReferrer.ToString();
            Session["Usuario"] = usuarioLogueado;
            Session["Dni"] = dniLogueado;
        }

        protected void gvServicios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string idServicio = ((Label)gvServicios.Rows[e.RowIndex].FindControl("lblIdServicio")).Text;
            Entidades.Servicios obj = new Entidades.Servicios { id_Servicio1 = idServicio };

            if (NS.EliminarServicio(obj) > 0)
            {
                MostrarExito("Se Elimino Servicio!");
                CargarTablaServicios();
            }
        }

        protected void gvServicios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvServicios.EditIndex = e.NewEditIndex;
            CargarTablaServicios();
        }

        protected void gvServicios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = ((Label)gvServicios.Rows[e.RowIndex].FindControl("lbletIdServicio")).Text;
            string nombre = ((TextBox)gvServicios.Rows[e.RowIndex].FindControl("txtetNombre")).Text;
            string detalle = ((TextBox)gvServicios.Rows[e.RowIndex].FindControl("txtetDetalle")).Text;
            string precio = ((TextBox)gvServicios.Rows[e.RowIndex].FindControl("txtetPrecio")).Text;

            Entidades.Servicios obj = new Entidades.Servicios
            {
                id_Servicio1 = id,
                nombre1 = nombre,
                detalle1 = detalle,
                precio1 = float.Parse(precio, CultureInfo.InvariantCulture)
            };

            if (NS.ActualizarServicio(obj) > 0)
            {
                MostrarExito("Se actualizo el Servicio!");
                gvServicios.EditIndex = -1;
                CargarTablaServicios();
            }
        }

        protected void gvServicios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvServicios.EditIndex = -1;
            CargarTablaServicios();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            GuardarSesion();
            Response.Redirect("Ingresar.aspx");
        }
    }
}
