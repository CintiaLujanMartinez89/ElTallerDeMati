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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*DECLARE @Contraseña NVARCHAR(50) = 'miContraseña';
DECLARE @HashContraseña NVARCHAR(255) = CONVERT(NVARCHAR(255), HASHBYTES('SHA2_256', @Contraseña), 1);

INSERT INTO Usuarios (Nombre, Correo, HashContraseña) 
VALUES ('usuario1', 'usuario1@correo.com', @HashContraseña);
  */
    }
}