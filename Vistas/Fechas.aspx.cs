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
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            if (Session["Usuario"] != null)
            {
               string usuarioLogueado = Session["Usuario"] as string;
               string dniLogueado = Session["Dni"] as string;

                // Mostrar los valores obtenidos de la sesión
                lblUsuarioLogueado.Text = "Bienvenida/o " + usuarioLogueado;

            }
            else
            {

                string message = "Debe Ingresar o Registrase e Ingresar ";
                string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);
                Response.Redirect("Ingresar.aspx");
            }

        }
    }
}