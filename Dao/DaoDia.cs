using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
  public  class DaoDia
    {
        ConexionBD cn = new ConexionBD();
    
        public List<DateTime> ObtenerDiasDisp()
        {
            List<DateTime> diasDisponibles = new List<DateTime>();
  
            string query = "SELECT Dia_D FROM DIA";

             using (SqlConnection conexion =cn.ObtenerConexion())
             {
                 using (SqlCommand cmd = new SqlCommand(query, conexion))
                 {
         
                     using (SqlDataReader reader = cmd.ExecuteReader())
                     {
                         while (reader.Read())
                         {
                             diasDisponibles.Add(Convert.ToDateTime(reader["Dia_D"]));
                         }
                     }
                 }
             }

             return diasDisponibles;
        }


  }
}
