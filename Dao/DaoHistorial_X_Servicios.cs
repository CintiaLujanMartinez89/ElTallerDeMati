using System;
using Entidades;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public void guardarHistorialXServicio(Historial_X_Servicios obj)
        {
            using (SqlConnection connection = cn.ObtenerConexion())
            {
                string query = "INSERT INTO Historial_X_Servicios (Id_Historial_HXS, [Dni_HXS], [Patente_Moto_HXS], [Id_Servicio_HXS], [Fecha_Realizacion_HXS], [Kilometraje_HXS]) VALUES (@idHistorial, @Dni, @Patente, @IdServicio, @FechaRealizacion, @Kilometraje)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idHistorial", obj.idHistorial1);
                command.Parameters.AddWithValue("@Dni", obj.dni1);
                command.Parameters.AddWithValue("@Patente", obj.patente1);
                command.Parameters.AddWithValue("@IdServicio", obj.idServicio1);
                command.Parameters.AddWithValue("@FechaRealizacion", obj.fecha_Realizacion1);
                command.Parameters.AddWithValue("@Kilometraje", obj.kilometraje1);

               int estado= command.ExecuteNonQuery();

            }
           
        }

        public void eliminarHistorialPorTurno(string dni, DateTime dia, string patente)
        {
            using (SqlConnection connection = cn.ObtenerConexion())
            {
                string diaFormateado = dia.ToString("yyyy-MM-dd");
                string query = $"DELETE FROM Historial_X_Servicios WHERE Dni_HXS ='{dni}' AND Fecha_Realizacion_HXS ='{diaFormateado}' AND Patente_Moto_HXS ='{patente}'";
               
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }


    }
}
