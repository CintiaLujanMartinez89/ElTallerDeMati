using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ClientesXMotos : System.Web.UI.Page
    {
        NegocioClientes_X_Motos NCXM = new NegocioClientes_X_Motos();

        string usuarioLogueado;
        string dniLogueado;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            /*
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
            */
            if (!IsPostBack)
            {
                CargarTablaClientesXMotos();
            }
        }

        private void CargarTablaClientesXMotos()
        {
            gvClientesXMotos.DataSource = NCXM.CargarTablaCliXMot();
            gvClientesXMotos.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
                if (txtDni.Text != "" && txtPatente.Text != "")
                {
                    string dni = txtDni.Text;
                    string patente = txtPatente.Text;

                    gvClientesXMotos.DataSource = NCXM.BuscarXDni_Patente(dni, patente);
                    gvClientesXMotos.DataBind();

                    txtDni.Text = "";
                    txtPatente.Text = "";
                }
                else if (txtDni.Text != "" && txtPatente.Text == "")
                {
                    string dni = txtDni.Text;

                    gvClientesXMotos.DataSource = NCXM.BuscarXDni(dni);
                    gvClientesXMotos.DataBind();

                    txtDni.Text = "";
                }
                else
                {
                    string patente = txtPatente.Text;

                    gvClientesXMotos.DataSource = NCXM.BuscarXPatente(patente);
                    gvClientesXMotos.DataBind();

                    txtPatente.Text = "";
                } 

        }

        protected void btnVerTodos_Click(object sender, EventArgs e)
        {
            CargarTablaClientesXMotos();
        }
    }
}