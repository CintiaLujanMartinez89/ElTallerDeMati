using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dao;
using System.Windows;

namespace Negocio
{
    public class Autenticacion
    {
        ConexionBD cn = new ConexionBD();

        public bool VerificarCredenciales(string dni, string contraseñaIngresada)
        {
            using (SqlConnection connection = cn.ObtenerConexion())
            {
                string query = "SELECT HashContraseña_CLI FROM Clientes WHERE Dni_CLI = @Dni";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Dni", dni);
              
                string hashContraseñaAlmacenada = (string)command.ExecuteScalar();
                
                return hashContraseñaAlmacenada == contraseñaIngresada;
            }
        }

    }

}
