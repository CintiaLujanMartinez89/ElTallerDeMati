using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
   
 public   class DaoServicios
    {
        ConexionBD cn = new ConexionBD();
        public DataTable ObternerServ()
        {
            using (SqlCommand cmd = new SqlCommand("spObtenerServicios", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
