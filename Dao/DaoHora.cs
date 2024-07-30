using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
   public class DaoHora
    {
        ConexionBD cn = new ConexionBD();

            public List<TimeSpan> ObtenerHorasDisp(DateTime fechaSeleccionada)
            {
                List<TimeSpan> horasDisponibles = new List<TimeSpan>();

                string query =@"SELECT Hora_H FROM HORA WHERE Hora_H NOT IN( SELECT Hora_T FROM TURNOS WHERE Dia_T = @Dia)";

                using (SqlConnection conexion = cn.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                    cmd.Parameters.AddWithValue("@Dia", fechaSeleccionada);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                horasDisponibles.Add((TimeSpan)reader["Hora_H"]);
                            }
                        }
                    }
                }

                return horasDisponibles;
            }
        

    }
}
