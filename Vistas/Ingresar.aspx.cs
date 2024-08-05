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
       

       DaoClientes DC = new DaoClientes();
        Autenticacion autenticacion = new Autenticacion();
        NegocioClientes NC = new NegocioClientes();

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Insertar un nuevo usuario
            string dni = txtDni.Text;
            string contraseña = txtPassword.Text;
            string usuario;
           
            string hashContraseñaIngresada = Seguridad.HashearContraseña(contraseña);
           
            // Verificar las credenciales del usuario
            bool credencialesValidas = autenticacion.VerificarCredenciales(dni, hashContraseñaIngresada);
            
            if (credencialesValidas==true)
            {
                usuario = NC.Buscar(dni);

                // Almacenar datos en la sesión
                Session["Usuario"] = usuario;
                Session["Dni"] = dni;

                Response.Redirect("Clientes.aspx");           
                              
            }
            else
            {
                txtDni.Text = "";
                txtPassword.Text = "";
               
                MessageBox.Show("Credenciales inválidas.");
            }
        }

    }
}