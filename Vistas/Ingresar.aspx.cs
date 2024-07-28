using Dao;
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
    public partial class Ingresar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       DaoClientes cli = new DaoClientes();
        Autenticacion autenticacion = new Autenticacion();
        NegocioClientes cliente = new NegocioClientes();

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Insertar un nuevo usuario
            string dni = txtDni.Text;
            string contraseña = txtPassword.Text;
            string usuario;

        

            // Verificar las credenciales del usuario
            bool credencialesValidas = autenticacion.VerificarCredenciales(dni, contraseña);

            if (credencialesValidas==true)
            {
                // Aquí puedes redirigir a la página Clientes.aspx
                  Response.Redirect("Clientes.aspx");
                MessageBox.Show("Credenciales válidas.");
                usuario = cliente.Buscar(dni);
                // Muestra el nombre del usuario en un label o cualquier otro control
                Label3.Text = usuario;
            }
            else
            {
                MessageBox.Show("Credenciales inválidas.");
            }
        }

    }
}