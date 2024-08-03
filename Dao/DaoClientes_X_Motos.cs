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

        public DataTable CargarTabla()
        {
                using (SqlCommand cmd = new SqlCommand("spCargarTablaCLIXMOT", cn.ObtenerConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            
        }

        public DataTable BuscarXDni_Patente(string dni,string patente)
        {
            string consulta = $"SELECT Dni_CXM,Nombre_CLI+' '+Apellido_CLI as Nombre_CLI,Patente_Moto_CXM,Marca_M,Modelo_M FROM clientes_X_Motos inner join CLIENTES on Dni_CXM= Dni_CLI inner join MOTOS on Patente_Moto_CXM = Patente_Moto_M  where Dni_CXM='{dni}' and Patente_Moto_CXM='{patente}'";
            string nombreTabla = "CLIENTES_X_MOTOS";
            return cn.ObtenerTabla(nombreTabla, consulta);
        }

        public DataTable BuscarXDni(string dni)
        {
            string consulta = $"SELECT Dni_CXM,Nombre_CLI+' '+Apellido_CLI as Nombre_CLI,Patente_Moto_CXM,Marca_M,Modelo_M FROM clientes_X_Motos inner join CLIENTES on Dni_CXM = Dni_CLI inner join MOTOS on Patente_Moto_CXM = Patente_Moto_M  where Dni_CXM='{dni}' ";
            string nombreTabla = "CLIENTES_X_MOTOS";
            return cn.ObtenerTabla(nombreTabla, consulta);
        }

        public DataTable BuscarXPatente(string patente)
        {
            string consulta = $"SELECT Dni_CXM,Nombre_CLI+' '+Apellido_CLI as Nombre_CLI,Patente_Moto_CXM,Marca_M,Modelo_M FROM clientes_X_Motos inner join CLIENTES on Dni_CXM = Dni_CLI inner join MOTOS on Patente_Moto_CXM = Patente_Moto_M  where  Patente_Moto_CXM='{patente}'";
            string nombreTabla = "CLIENTES_X_MOTOS";
            return cn.ObtenerTabla(nombreTabla, consulta);
        }
    }
}
