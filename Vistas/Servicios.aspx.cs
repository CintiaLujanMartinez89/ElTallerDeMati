using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class Servicios : System.Web.UI.Page
    {
        string usuarioLogueado;
        string dniLogueado;
        NegocioServicios NS = new NegocioServicios();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            
            if (Session["Usuario"] != null)
            {
                usuarioLogueado = Session["Usuario"] as string;
                dniLogueado = Session["Dni"] as string;

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
            
            if (!IsPostBack)
            {
               
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string idServicio = "S" + txtId.Text.ToString();
            string nombre = txtNombre.Text.ToString();
            string descripcion = txtDescripcion.Text.ToString();
            float precio;
            if (float.TryParse(txtPrecio.Text, out precio))
            {
                int fila = NS.AgregarServicio(idServicio, nombre, descripcion, precio);
                if (fila > 0)
                {
                    string message = "Se Agrego Servicio!";
                    ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}');", true);

                    txtId.Text = "";
                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                


                }else
                {
                    string message = "Error al ingresar Servicio";
                    string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                    ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);
                }
            }
            else
            {
                string message = "No se pudo ingresar Servicio, error en atributo Precio";
                string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);
            }

        }
    }
}