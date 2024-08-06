using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Dao
{
    public class DaoDia_X_Hora
    {
        ConexionBD cn = new ConexionBD();


        public List<DateTime> ObtenerDiasDisp()
        {
            List<DateTime> diasDisponibles = new List<DateTime>();

            string query = "SELECT Dia_DXH, Hora_DXH FROM DIA_X_HORA WHERE NOT EXISTS(SELECT 1 FROM TURNOS WHERE TURNOS.Dia_T = DIA_X_HORA.Dia_DXH  AND TURNOS.Hora_T = DIA_X_HORA.Hora_DXH )";

            using (SqlConnection conexion = cn.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            diasDisponibles.Add(Convert.ToDateTime(reader["Dia_DXH"]));
                        }
                    }
                }
            }

            return diasDisponibles;
        }

        public int EliminarFechadeDisp(DateTime fechaSeleccionada)
        {
            string consulta = "DELETE FROM Dia_X_HORA WHERE Dia_dxh = @Dia";

            int fila = 0;

            try
            {
                using (SqlConnection conn = cn.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@Dia", fechaSeleccionada);
                        fila = cmd.ExecuteNonQuery();

                    }

                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, registrarla o mostrar un mensaje de error
                Console.WriteLine("Error al reservar el turno: " + ex.Message);
                return 0;
            }

            return fila;

        }

        public List<TimeSpan> ObtenerHorasDisp(DateTime fechaSeleccionada)
        {
            List<TimeSpan> horasDisponibles = new List<TimeSpan>();

            string query = @"SELECT Hora_DXH FROM DIA_X_HORA WHERE Hora_DXH NOT IN( SELECT Hora_T FROM TURNOS WHERE Dia_T = @Dia) AND dIA_dxh= @Dia";

            using (SqlConnection conexion = cn.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Dia", fechaSeleccionada);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            horasDisponibles.Add((TimeSpan)reader["Hora_DXH"]);
                        }
                    }
                }
            }

            return horasDisponibles;
        }

        public int AgregarFechaDisp(DateTime fecha, TimeSpan hora)
        {  int filasAfectadas = 0;

            try
            {
                using (SqlConnection conn = cn.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("spAgregarFechaHora", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Dia", fecha.Date); // .Date para asegurar que solo la fecha se envíe
                        cmd.Parameters.AddWithValue("@Hora", hora);

                        filasAfectadas = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                throw new Exception("Ocurrió un error al agregar la fecha y hora", ex);
            }

            return filasAfectadas;


        }

    }
}
