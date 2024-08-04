using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Vistas
{
    public partial class ReservarTurno : System.Web.UI.Page
    {
        NegocioDia_X_Hora NDXH = new NegocioDia_X_Hora();
        NegocioTurnos NT = new NegocioTurnos();

        protected List<DateTime> diasDisponibles;
        string usuarioLogueado;
        string dniLogueado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                diasDisponibles = (List<DateTime>)Session["DiasDisponibles"];
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (clTurnosDisponibles.SelectedDate == DateTime.MinValue)
            {
                // Manejar el caso en que no se seleccionó una fecha
                Console.WriteLine("Por favor, seleccione una fecha.");
                return;
            }

            DateTime diaSeleccionado = clTurnosDisponibles.SelectedDate;
            TimeSpan horaSeleccionada;
            if (!TimeSpan.TryParse(rbHorarios.SelectedValue.ToString(), out horaSeleccionada))
            {
                // Manejar el caso en que la hora no es válida
                Console.WriteLine("Por favor, seleccione una hora válida.");
                return;
            }

            string patente = txtPatente.Text;
            string servicio = ddlServicios.SelectedValue.ToString();
            string observacion = txtComentario.Text;
            string dniLogueado = Session["Dni"] as string;

            int fila = NT.ReservarTurno(diaSeleccionado, horaSeleccionada, dniLogueado, patente, servicio, observacion);

            txtPatente.Text = "";
            ddlServicios.SelectedValue = "0";
            txtComentario.Text = "";

        }

        //SI EL LOGIN== NULL REDIRECCIONAR A INGRESAR.ASPX
    }
}