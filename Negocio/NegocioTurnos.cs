using Dao;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioTurnos
    {
        DaoTurnos DT = new DaoTurnos();
        public DataTable ObtenerTablaTurnos(string dni)
        {
            return DT.ObtenerTabla(dni);
        }

        public int ReservarTurno(DateTime dia, TimeSpan hora, string dni, string patente, string servicio, string observacion)
        {
            return DT.ReservarTURNO(dia, hora, dni, patente, servicio, observacion);
        }

        public DataTable ObtenerTurnosAsignados()
        {
            return DT.ObtenerTablaTurnosAsignados();
        }

        public int EliminarTurno(Turnos obj)
        {
            return DT.Eliminar(obj);
        }

        public int cambiarAsistencia(string idTurno, string dia, string hora)
        {
            return DT.cambiarAsist(idTurno, dia, hora);
        }

        public Turnos obtenerTurnoPorId(string idTurno)
        {
            return DT.obtenerTurnoPorId(idTurno);
        }

        public (string dni, string patente) BuscarDnixIdTurno(string idTurno, DateTime dia)
        {
            return DT.BuscarDnixIdTurno(idTurno, dia);
        }

        public int EliminarTurnoCliente(DateTime dia, TimeSpan hora)
        {
            return DT.EliminarTurnoCliente(dia, hora);
        }
    }
}
