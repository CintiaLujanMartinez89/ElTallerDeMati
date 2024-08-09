using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dao
{
  public  class DaoMotos
    {
        //Se declara un objeto ConexionBD llamado cn
        ConexionBD cn = new ConexionBD();
        public DataTable ObtenerMotos(string dni)
        {
            using (SqlCommand cmd = new SqlCommand("ObtenerMotosPorDni", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
           
        }

        public int Agregar(string patente, string marca, string modelo,int km)
        {
            using (SqlCommand cmd = new SqlCommand("AgregarMoto", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@km", km);

                
                int fila = cmd.ExecuteNonQuery();
               

                return fila;
            }
        }

        public int EliminarMoto(Motos obj)
        {
            int fila = 0;
            string query = "UPDATE MOTOS SET Estado_M = 0 WHERE Patente_Moto_M = @Patente";

            // Usa un bloque using para asegurarte de que los recursos se liberen adecuadamente
            using (SqlConnection connection = cn.ObtenerConexion())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agrega el parámetro a la consulta
                    command.Parameters.AddWithValue("@Patente", obj.patente1);

                    // Ejecuta la consulta y obtiene el número de filas afectadas
                    fila = command.ExecuteNonQuery();
                }
            }

            // Devuelve el número de filas afectadas
            return fila;
        }
    }
}
