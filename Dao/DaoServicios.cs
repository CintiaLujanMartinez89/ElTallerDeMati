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

        public int EliminarServ(Entidades.Servicios obj)
        {
            int fila;
            using (SqlCommand cmd = new SqlCommand("spEliminarServicios", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idServicio",obj.id_Servicio1);
               fila= cmd.ExecuteNonQuery();
                return fila;
            }
        }

        public int AgregarServ(string idServicio, string nombre, string descripcion, float precio)
        {
            int fila;
            using (SqlCommand cmd = new SqlCommand("spAgregarServicios", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idServicio",idServicio);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@Precio", precio);

                fila = cmd.ExecuteNonQuery();

            }

            return fila;
        }
       public int ActualizarServ(Entidades.Servicios obj)
        {
            using (SqlCommand cmd = new SqlCommand("spActualizarServicios", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idServicio",obj.id_Servicio1);
                cmd.Parameters.AddWithValue("@Nombre", obj.nombre1);
                cmd.Parameters.AddWithValue("@Descripcion", obj.detalle1);
                cmd.Parameters.AddWithValue("@Precio",obj.precio1);

               int fila= cmd.ExecuteNonQuery();
                return fila;
            }
        }
    }
}
