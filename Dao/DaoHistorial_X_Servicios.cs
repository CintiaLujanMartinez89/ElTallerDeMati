using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
   
  public  class DaoHistorial_X_Servicios
    {
        ConexionBD cn = new ConexionBD();
        public DataTable ObtenerTablaHisto()
        {
            using (SqlCommand cmd = new SqlCommand("ObtenerTablaHistorial", cn.ObtenerConexion()))
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
            string consulta = $"SELECT Dni_HXS,Nombre_CLI+' '+Apellido_CLI as Nombre_CLI,Patente_Moto_HXS,Marca_M,Modelo_M, FORMAT(Fecha_Realizacion_HXS, 'dd/MM/yyyy') AS Fecha_Realizacion_HXS,Kilometraje_HXS,Nombre_S FROM HISTORIAL_X_SERVICIOS inner join CLIENTES on Dni_HXS = Dni_CLI inner join MOTOS on Patente_Moto_HXS = Patente_Moto_M inner join SERVICIOS on Id_Servicio_S=Id_Servicio_HXS where Dni_HXS='{dni}' and Patente_Moto_HXS='{patente}'";
            string nombreTabla = "HISTORIAL_X_SERVICIOS";
            return cn.ObtenerTabla(nombreTabla, consulta);
        }

        public DataTable BuscarXDni(string dni)
        {
            string consulta= $"SELECT Dni_HXS,Nombre_CLI+' '+Apellido_CLI as Nombre_CLI,Patente_Moto_HXS,Marca_M,Modelo_M, FORMAT(Fecha_Realizacion_HXS, 'dd/MM/yyyy') AS Fecha_Realizacion_HXS,Kilometraje_HXS,Nombre_S FROM HISTORIAL_X_SERVICIOS inner join CLIENTES on Dni_HXS = Dni_CLI inner join MOTOS on Patente_Moto_HXS = Patente_Moto_M inner join SERVICIOS on Id_Servicio_S=Id_Servicio_HXS  where Dni_HXS='{dni}'";
            string nombreTabla = "HISTORIAL_X_SERVICIOS";
            return cn.ObtenerTabla(nombreTabla, consulta);
        }

        public DataTable BuscarXPatente( string patente)
        {
            string consulta = $"SELECT Dni_HXS,Nombre_CLI+' '+Apellido_CLI as Nombre_CLI,Patente_Moto_HXS,Marca_M,Modelo_M, FORMAT(Fecha_Realizacion_HXS, 'dd/MM/yyyy') AS Fecha_Realizacion_HXS,Kilometraje_HXS,Nombre_S FROM HISTORIAL_X_SERVICIOS inner join CLIENTES on Dni_HXS = Dni_CLI inner join MOTOS on Patente_Moto_HXS = Patente_Moto_M inner join SERVICIOS on Id_Servicio_S=Id_Servicio_HXS where Patente_Moto_HXS='{patente}'";
            string nombreTabla = "HISTORIAL_X_SERVICIOS";
            return cn.ObtenerTabla(nombreTabla, consulta);
        }
    }
}
