using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ReservarTurno : System.Web.UI.Page
    {
        NegocioDia ND = new NegocioDia();
        NegocioHora NH = new NegocioHora();
        NegocioTurnos NT = new NegocioTurnos();

        protected List<DateTime> diasDisponibles;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string usuarioLogueado = Session["Usuario"] as string;
                string dniLogueado = Session["Dni"] as string;

                // Mostrar los valores obtenidos de la sesión
                lblUsuarioLogueado.Text = "Bienvenida/o " + usuarioLogueado;
               
                diasDisponibles = ND.ObtenerDiasDisponibles();
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
            List<TimeSpan> horasDisponibles = NH.ObtenerHorasDisponibles();
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
            string Dia = clTurnosDisponibles.SelectedDate.ToShortDateString();
            string Hora= rbHorarios.SelectedValue.ToString();
            string Patente = txtPatente.ToString();
            //int fila = NT.ReservarTurno();
        }
        //SI EL LOGIN== NULL REDIRECCIONAR A INGRESAR.ASPX
    }
}