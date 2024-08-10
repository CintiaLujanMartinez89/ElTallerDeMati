using System;
using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace Dao
{
    public class DaoClientes
    {

        ConexionBD cn = new ConexionBD();

        public int Agregar(Clientes cli)
        {
            int filasAfectadas = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("spInsertarCliente", cn.ObtenerConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Dni", cli.Dni1);
                    cmd.Parameters.AddWithValue("@Nombre", cli.Nombre1);
                    cmd.Parameters.AddWithValue("@Apellido", cli.Apellido1);
                    cmd.Parameters.AddWithValue("@Domicilio", cli.Domicilio1);
                    cmd.Parameters.AddWithValue("@Telefono", cli.Telefono1);
                    cmd.Parameters.AddWithValue("@Email", cli.Email1);
                    cmd.Parameters.AddWithValue("@HashContraseña", cli.Contraseña1);
                  
                     filasAfectadas = cmd.ExecuteNonQuery();
                    MessageBox.Show(filasAfectadas.ToString());                 
                }
                return filasAfectadas;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error: " + ex.Message);
                return -1;
            }
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

