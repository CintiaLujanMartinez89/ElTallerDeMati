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
    }
}
