using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Web.UI;

namespace Dao
{
    public class DaoTurnos
    {
        ConexionBD cn = new ConexionBD();
        public DataTable ObtenerTabla(string dni)
        {
            string consulta = $"select Patente_Moto_T,Marca_M,Modelo_M,Nombre_S,FORMAT(Dia_T, 'dd/MM/yyyy') as Dia_T,Hora_T from Turnos as t inner join Motos as m on t.Patente_Moto_T = m.Patente_Moto_M inner join SERVICIOS as s on s.Id_Servicio_S = t.Id_Servicio_T Where Dni_T='{dni}'";
            DataTable dt = cn.ObtenerTabla("TURNOS", consulta);
            return dt;

        }


        public DataTable ObtenerTablaTurnosAsignados()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.spObtenerTurnosAsignados", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int ReservarTURNO(DateTime dia, TimeSpan hora, string dni, string patente, string servicio, string observacion)
        {
            using (SqlCommand cmd = new SqlCommand("ReservarTurno", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dia", dia.Date);
                cmd.Parameters.AddWithValue("@Hora", hora);
                cmd.Parameters.AddWithValue("@Dni", dni);
                cmd.Parameters.AddWithValue("@Patente", patente);
                cmd.Parameters.AddWithValue("@IdServicio", servicio);
                cmd.Parameters.AddWithValue("@Observacion", observacion);
                cmd.Parameters.AddWithValue("@Asistencia", '0');
              
                    int fila = cmd.ExecuteNonQuery();
                   
                    return fila;
              
               
            }
        }

        public int Eliminar(Turnos obj)
        {

            int id = Convert.ToInt32(obj.IdTurno);

            using (SqlCommand cmd = new SqlCommand("spEliminar", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Turno", id);

                try
                {
                    int fila = cmd.ExecuteNonQuery();
                    return fila;
                }
                catch (SqlException ex)
                {
                    // Manejar la excepción, por ejemplo, registrarla o mostrar un mensaje de error
                    Console.WriteLine("Error al eliminar el turno: " + ex.Message);
                    return 0;
                }
            }
        }


        public int cambiarAsist(string idTurno, string dia, string hora)
        {
            using (SqlCommand cmd = new SqlCommand("spCambiarAsistencia", cn.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Convertir idTurno a entero
                if (!int.TryParse(idTurno, out int idTurnoInt))
                {
                    MessageBox.Show("El ID del turno no es válido.");
                    return -1; // Indicar un error
                }

                // Convertir dia a DateTime
                if (!DateTime.TryParse(dia, out DateTime diaDate))
                {
                    MessageBox.Show("La fecha no es válida.");
                    return -1; // Indicar un error
                }

                // Convertir hora a TimeSpan
                if (!TimeSpan.TryParse(hora, out TimeSpan horaTimeSpan))
                {
                    MessageBox.Show("La hora no es válida.");
                    return -1; // Indicar un error
                }

                // Configurar parámetros del procedimiento almacenado
                cmd.Parameters.AddWithValue("@IdTurno", idTurnoInt);
                cmd.Parameters.AddWithValue("@Dia", diaDate.Date); // Asegúrate de usar solo la parte de fecha
                cmd.Parameters.AddWithValue("@Hora", horaTimeSpan); // TimeSpan representa la hora

                try
                {
                    // Ejecutar el procedimiento almacenado y obtener el número de filas afectadas
                    int filasAfectadas = (int)cmd.ExecuteScalar();
                    return filasAfectadas;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al cambiar asistencia: " + ex.Message);
                    return -1; // Indicar un error
                }
            }
        }
        public Turnos obtenerTurnoPorId(string idTurno)
        {
            string consulta = $"  SELECT [Dia_T],[Hora_T],[Dni_T],[Patente_Moto_T],[Id_Servicio_T],[Observacion_T],[Id_Turno_T] FROM TURNOS WHERE Id_Turno_T='{idTurno}' and Asistencia_T='1'";
           
            SqlCommand command = new SqlCommand(consulta, cn.ObtenerConexion());
            Turnos turno = new Turnos();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                    {
                        turno.Dia = reader.GetDateTime(reader.GetOrdinal("Dia_T"));
                        turno.Hora = reader.GetTimeSpan(reader.GetOrdinal("Hora_T"));

                        turno.Dni = reader["Dni_T"].ToString();
                        turno.Patente = reader["Patente_Moto_T"].ToString();
                        turno.IdServicio = reader["Id_Servicio_T"].ToString();
                        turno.Observacion = reader["Observacion_T"].ToString();
                        turno.IdTurno = reader["Id_Turno_T"].ToString();
                    }
                }

            }

            return turno;
        }

        public (string dni, string patente) BuscarDnixIdTurno(string idTurno, DateTime dia)
        {
            string dni = string.Empty;
            string patente = string.Empty;

            using (SqlConnection connection = cn.ObtenerConexion())
            {
       
                // Usar interpolación de cadenas para la consulta (no recomendado)
                string consulta = $@"SELECT Dni_T, Patente_Moto_T FROM Turnos WHERE Id_Turno_T = '{idTurno}' AND Dia_T = '{dia:yyyy-MM-dd}'";

                SqlCommand command = new SqlCommand(consulta, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    dni = reader["Dni_T"].ToString();
                    patente = reader["Patente_Moto_T"].ToString();
                }
            }
          return (dni, patente);
        }

        public int EliminarTurnoCliente(DateTime dia, TimeSpan hora)
        {
            int filasAfectadas = 0;
            using (SqlConnection connection = cn.ObtenerConexion())
            {
                // Define la consulta SQL con parámetros
                string consulta = @"DELETE FROM Turnos WHERE Dia_T = @Dia AND Hora_T = @Hora";

                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@Dia", dia.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Hora", hora.ToString(@"hh\:mm\:ss"));

                    // Ejecuta la consulta y obtiene el número de filas afectadas
                    filasAfectadas = command.ExecuteNonQuery();

                }
            }

            return filasAfectadas;
        }

    }
}
