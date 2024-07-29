using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
   public class DaoClientes_X_Motos
    {
        ConexionBD cn = new ConexionBD();
        public int AgregarCXM(string dniLogueado,string patente)
        {
            using (SqlCommand cmd = new SqlCommand("AgregarCliente_X_Moto", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dni", dniLogueado);
                cmd.Parameters.AddWithValue("@Patente", patente);
         
                int fila = cmd.ExecuteNonQuery();

                return fila;
            }
        }
    }
}
