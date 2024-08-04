using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class Fechas : System.Web.UI.Page
    {
        NegocioDia_X_Hora NDXH = new NegocioDia_X_Hora();
        NegocioTurnos NT = new NegocioTurnos();

        protected List<DateTime> diasDisponibles;
        string usuarioLogueado;
        string dniLogueado;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            if (Session["Usuario"] != null)
            {
                usuarioLogueado = Session["Usuario"] as string;
                dniLogueado = Session["Dni"] as string;

                // Mostrar los valores obtenidos de la sesión
                lblUsuarioLogueado.Text = "Bienvenida/o " + usuarioLogueado;


                diasDisponibles = NDXH.ObtenerDiasDisponibles();
                Session["DiasDisponibles"] = diasDisponibles; // Guardar en sesión para usar en el evento DayRender

            }
            else
            {

                string message = "Debe Ingresar o Registrase e Ingresar ";
                string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);
                Response.Redirect("Ingresar.aspx");
            }
        }

        protected void clTurnosDisponibles_DayRender(object sender, DayRenderEventArgs e)
        {
            if (!diasDisponibles.Contains(e.Day.Date))
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Gray; // Cambiar el color para que se vea deshabilitado


            }
        }

        protected void clTurnosDisponibles_SelectionChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = clTurnosDisponibles.SelectedDate;

            // Aquí llamas a tu método para obtener las horas disponibles pasándole la fecha seleccionada
            List<TimeSpan> horasDisponibles = NDXH.ObtenerHorasDisponibles(fechaSeleccionada);

            LlenarRadioButtonList(horasDisponibles);
        }

        private void LlenarRadioButtonList(List<TimeSpan> horasDisponibles)
        {
            rbHorarios.Items.Clear();
            foreach (TimeSpan hora in horasDisponibles)
            {
                rbHorarios.Items.Add(new ListItem(hora.ToString(@"hh\:mm"), hora.ToString()));
            }
        }

        protected void btnEliminarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = clTurnosDisponibles.SelectedDate;
            int fila = NDXH.EliminarFechadeDisponibles(fechaSeleccionada);

            if (fila == 1)
            {
                string message = "Se ELIMINO fecha disponible para Turnos";
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}');", true);
            }
            else
            {
                string message = "NO se pudo ELIMINAR fecha  disponible para Turnos";
                string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);

                //   ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{HttpUtility.JavaScriptStringEncode("No se pudo cambiar la Asistencia del Cliente: " + nombre)}', 'error');", true);
            }

            diasDisponibles = NDXH.ObtenerDiasDisponibles();
        }

        protected void btnAgregarFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(txtFecha.Text);

            foreach (ListItem item in chkbHoras.Items)
            {
                if (item.Selected)
                {
                    // Convertir la hora seleccionada a un objeto DateTime
                    TimeSpan hora;
                   
                    if (TimeSpan.TryParse(item.Value, out hora))
                    {

                        // Llamar al método para agregar el registro a la base de datos
                        int resultado = NDXH.AgregarFechaDisponible(fecha, hora);

                        // Mostrar mensaje según el resultado
                        if (resultado > 0)
                        {
                            // Registro agregado exitosamente
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Fecha y hora agregadas exitosamente.');", true);
                        }

                        else
                        {
                            // Error al agregar el registro
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Error al agregar la fecha y hora.');", true);
                        }
                    }
                }


            }
        }

    }
}