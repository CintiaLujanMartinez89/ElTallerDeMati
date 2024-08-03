using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Vistas
{
    public partial class IngresarFechas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarMoto_Click(object sender, EventArgs e)
        {
            DateTime fecha =Convert.ToDateTime( txtFecha.Text);
            MessageBox.Show(fecha.ToString());

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}