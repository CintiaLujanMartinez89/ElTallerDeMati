using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class Historial : System.Web.UI.Page
    {
        NegocioHistorial_X_Servicios NHXS = new NegocioHistorial_X_Servicios();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTablaHistorial();
        }

        public void CargarTablaHistorial()
        {
            DataTable tabla = NHXS.ObtenerTablaHistorial();
            gvHistorial.DataSource = tabla;
            gvHistorial.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(txtDni.Text!="" && txtPatente.Text != "")
            {
                string dni = txtDni.Text;
                string patente = txtPatente.Text;

                gvHistorial.DataSource= NHXS.BuscarXDni_Patente(dni, patente);
                gvHistorial.DataBind();

                txtDni.Text = "";
                txtPatente.Text = "";
            } else if( txtDni.Text != "" && txtPatente.Text == "")
                    {
                     string dni = txtDni.Text;

                      gvHistorial.DataSource = NHXS.BuscarXDni(dni);
                      gvHistorial.DataBind();

                  txtDni.Text = "";
            }
            else {
                string patente = txtPatente.Text;

                gvHistorial.DataSource = NHXS.BuscarXPatente(patente);
                gvHistorial.DataBind();

                txtPatente.Text = "";
            }

        }

        protected void btnVerTodos_Click(object sender, EventArgs e)
        {
            CargarTablaHistorial();
        }
    }
}