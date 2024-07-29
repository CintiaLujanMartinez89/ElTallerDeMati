using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Vistas
{
    public partial class Clientes : System.Web.UI.Page
    {
        NegocioTurnos NT = new NegocioTurnos();
        NegocioMotos NM = new NegocioMotos();

        private string usuarioLogueado;
        private string dniLogueado;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            if (Session["Usuario"] != null)
            {
                usuarioLogueado = Session["Usuario"] as string;
                dniLogueado = Session["Dni"] as string;

                // Mostrar los valores obtenidos de la sesión
                lblUsuarioLogueado.Text = "Bienvenida/o " + usuarioLogueado;

            } else {
                MessageBox.Show("Debe Ingresar o Registrase e Ingresar");
                Response.Redirect("Ingresar.aspx"); }

            if (!IsPostBack)
            {
                mostrarTablaMotos(dniLogueado);
                mostrarTablaTurnos(dniLogueado);
            }
        }

            public void mostrarTablaMotos(string dni)
            {
                DataTable tabla = NM.ObtenerTablaMotos(dni);
                gvMisMotos.DataSource = tabla;
                gvMisMotos.DataBind();
            }

            protected void mostrarTablaTurnos(string dni)
            {
                DataTable tabla = NT.ObtenerTablaTurnos(dni);
                gvMisTurnos.DataSource = tabla;
                gvMisTurnos.DataBind();
            }

        protected void btnAgregarMoto_Click(object sender, EventArgs e)
        {
            Session["UrlPaginaPrevia"] = Request.UrlReferrer.ToString();
            Response.Redirect("AgregarMoto.aspx");
        }
    }
}