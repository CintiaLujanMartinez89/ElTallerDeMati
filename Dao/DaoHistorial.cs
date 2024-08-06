using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
   public class DaoHistorial
    {
        ConexionBD cn = new ConexionBD();
        public string ObtenerIdHistorial(string dni, string patente)
        {
                string idHistorial = string.Empty;
                using (SqlConnection connection = cn.ObtenerConexion())
                {
                    string query = "SELECT Id_Historial_H FROM HISTORIAL WHERE Dni_H = @Dni AND Patente_Moto_H = @Patente";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Dni", dni);
                    command.Parameters.AddWithValue("@Patente", patente);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        idHistorial = reader["Id_Historial_H"].ToString();
                    }
                }           
            return idHistorial;
        }

    }
}
