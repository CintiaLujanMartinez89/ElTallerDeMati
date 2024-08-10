using Negocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class Registrarse : System.Web.UI.Page
    {
        Entidades.Clientes cli = new Entidades.Clientes();
        NegocioClientes NC = new NegocioClientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string contrase = txtPassword.Text;

            string hashContraseñaIngresada = Seguridad.HashearContraseña(contrase);

          
            cli.Nombre1 = nombre;
            cli.Apellido1 = apellido;
            cli.Dni1 = dni;
            cli.Domicilio1 = domicilio;
            cli.Telefono1 = telefono;
            cli.Email1 = email;
            cli.Contraseña1 = hashContraseñaIngresada;

            int fila=NC.AgregarCliente(cli);
            if (fila ==1)
            {
                string message = "Usuario agregado exitosamente.";
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}');", true);
                txtDni.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDomicilio.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";

                string messag = "Usuario Registrado con exito!";
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{messag}');", true);
                Response.Redirect("Ingresar.aspx");
            } else if(fila == -1){
                string message = "El usuario ya existe!";
                string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);
                txtDni.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDomicilio.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                //Response.Redirect("Ingresar.aspx");
            }
            else
            {
                string message = "Error al ingresar usuario";
                string icon = "error"; // Cambia el icono a 'error' u otro valor según sea necesario
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", $"showAlert('{message}', '{icon}');", true);
                Response.Redirect("Inicio.aspx");
            }
        }

    }
}
    