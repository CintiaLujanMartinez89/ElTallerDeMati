using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
   public class DaoTurnos
    {
        ConexionBD cn = new ConexionBD();
        public DataTable ObtenerTabla(string dni)
        {
            string consulta = $"select Patente_Moto_T,Marca_M,Modelo_M,Nombre_S,FORMAT(Dia_T, 'dd/MM/yyyy') as Dia_T,Hora_T from Turnos as t inner join Motos as m on t.Patente_Moto_T = m.Patente_Moto_M inner join SERVICIOS as s on s.Id_Servicio_S = t.Id_Servicio_T where Dni_T =12345678";//Where Dni_T='{dni}'";
            DataTable dt = cn.ObtenerTabla("TURNOS", consulta);
            return dt;
           
        }

        public int ReservarTURNO(DateTime dia, TimeSpan hora, string dni, string patente, string servicio, string observacion)
        {
            using (SqlCommand cmd = new SqlCommand("ReservarTurno", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dia", dia);
                cmd.Parameters.AddWithValue("@Hora", hora);
                cmd.Parameters.AddWithValue("@Dni", dni);
                cmd.Parameters.AddWithValue("@Patente", patente);
                cmd.Parameters.AddWithValue("@IdServicio", servicio);
                cmd.Parameters.AddWithValue("@Observacion", observacion);

                try
                {
                    int fila = cmd.ExecuteNonQuery();
                    return fila;
                }
                catch (SqlException ex)
                {
                    // Manejar la excepción, por ejemplo, registrarla o mostrar un mensaje de error
                    Console.WriteLine("Error al reservar el turno: " + ex.Message);
                    return 0;
                }
            }
        }


    }
}
