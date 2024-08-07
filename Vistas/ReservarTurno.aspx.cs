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

                if (dniLogueado == "0")
                {
                    Label6.Visible = true;
                    txtDni.Visible = true;
                }
                else
                {
                    Label6.Visible = false;
                    txtDni.Visible = false;
                }

                // Guardar los valores en ViewState para persistencia durante los postbacks
                ViewState["UsuarioLogueado"] = usuarioLogueado;
                ViewState["DniLogueado"] = dniLogueado;
            }
            else
            {
                usuarioLogueado = ViewState["UsuarioLogueado"] as string;
              
                diasDisponibles = (List<DateTime>)Session["DiasDisponibles"];

                // Si no es la primera carga, asignar el valor del TextBox a dniLogueado si el TextBox es visible
                if (txtDni.Visible)
                {
                    dniLogueado = txtDni.Text;
                }
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
          
                string message = "Por favor, seleccione una fecha.";
                string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', 'error');", true);  // Manejar el caso en que no se seleccionó una fecha

                return;
            }

            DateTime diaSeleccionado = clTurnosDisponibles.SelectedDate.Date;
            TimeSpan horaSeleccionada;
            if (!TimeSpan.TryParse(rbHorarios.SelectedValue.ToString(), out horaSeleccionada))
            {
                string message = "Por favor, seleccione una hora válida.";
                string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);  // Manejar el caso en que no se seleccionó una fecha
                return;
            }


            string patente = txtPatente.Text;
            string servicio = ddlServicios.SelectedValue.ToString();
            string observacion = txtComentario.Text;
            if (txtDni.Visible)
            {
              string  dniLogueado = txtDni.Text;
            }
            else { string dniLogueado = Session["Dni"] as string; }
          
            int fila = NT.ReservarTurno(diaSeleccionado, horaSeleccionada, dniLogueado, patente, servicio, observacion);
           
            if (fila >0)
            {
                string message = "Se AGREGO con exito el turno";
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}');", true);

            }else
            {
                string message = "ERROR al agregar Turno";
                string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);
            }
            txtPatente.Text = "";
            ddlServicios.SelectedValue = "0";
            txtComentario.Text = "";
            clTurnosDisponibles.SelectedDate = DateTime.MinValue; // Deselecciona la fecha en el Calendar
            ddlServicios.SelectedIndex = -1;
            txtDni.Text = "";
            diasDisponibles = NDXH.ObtenerDiasDisponibles();
            Session["DiasDisponibles"] = diasDisponibles;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            MessageBox.Show(usuarioLogueado + " " + dniLogueado);
            if (usuarioLogueado == "Matias De Stefano")
            {
                Session["Usuario"] = usuarioLogueado;
                Session["Dni"] = "0";

                Response.Redirect("Administrador.aspx");
            }
            else {
                Session["Usuario"] = usuarioLogueado;
                Session["Dni"] = dniLogueado;

                Response.Redirect("Clientes.aspx");
            }
        }
    }
}