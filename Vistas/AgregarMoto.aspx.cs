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
    public partial class AgregarMoto : System.Web.UI.Page
    {
        NegocioMotos NM = new NegocioMotos();
        NegocioClientes_X_Motos NCXM = new NegocioClientes_X_Motos();

        private string usuarioLogueado;
        private string dniLogueado;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            lblMensaje.Text="";


            if (Session["Usuario"] != null)
            {
                usuarioLogueado = Session["Usuario"] as string;
                dniLogueado = Session["Dni"] as string;

                // Mostrar los valores obtenidos de la sesión
                lblUsuarioLogueado.Text = "Bienvenida/o " + usuarioLogueado;

            }
            else
            {
                MessageBox.Show("Debe Ingresar o Registrase e Ingresar");
                Response.Redirect("Ingresar.aspx");
            }

            //DEPENDIENDO DE LA URL DE LA QUE ACCEDO (TIPO CLIENTE O TIPO ADMIN) A ESTA VA A SER DIFERENTE A DONDE ME DEVUELVA
            if (Session["UrlPaginaPrevia"] != null)
            {
                HyperLink2.NavigateUrl = Session["UrlPaginaPrevia"].ToString();
            }
            else
            {
                // Establecer un valor predeterminado si no hay URL previa
                HyperLink1.NavigateUrl = "~/Inicio.aspx";
            }
        }

        protected void btnSolicitarTurno_Click(object sender, EventArgs e)
        {
            string patente = txtPatente.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int km = Convert.ToInt32(txtKm.Text);

            int filaAgregada=NM.AgregarMoto(patente, marca, modelo, km);

            if (filaAgregada == 1)
            {
                int filaNXM = NCXM.AgregarClienteXMoto(dniLogueado, patente);// INGRESA item EN CLIENTES_x_MOTOS

                if (filaNXM == 1)
                {
                    lblMensaje.Text = "MOTO agregada con exito!";

                } else { lblMensaje.Text = "Error al insertar el cliente en CLIENTES_X_MOTOS."; }

            }else { lblMensaje.Text = "Error al agregar MOTO."; }

            txtPatente.Text = "";
            txtMarca.Text = "";
             txtModelo.Text = "";
            txtKm.Text = "";
        }
    }
}