using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoClientes
    {

        ConexionBD cn = new ConexionBD();

        public void InsertarCliente(string dni, string nombre, string apellido, string domicilio, string telefono, string email, string hashContraseña)
        {

        }

        public string BuscarCliente(string dni)
        {
            using (SqlConnection connection = cn.ObtenerConexion())
            {
                string query = "SELECT Nombre_CLI + ' '+ Apellido_CLI as Nombre_CLI  FROM Clientes WHERE Dni_CLI = @Dni";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Dni", dni);

                string nombreUsuario = null;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nombreUsuario = reader["Nombre_CLI"].ToString();
                    }
                }

                return nombreUsuario;
            }
        }

    }

}

