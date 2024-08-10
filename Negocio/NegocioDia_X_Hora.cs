using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioDia_X_Hora
    {
        DaoDia_X_Hora DDXH = new DaoDia_X_Hora();
        public List<DateTime> ObtenerDiasDisponibles()
        {
            return DDXH.ObtenerDiasDisp();
        }

        public List<TimeSpan> ObtenerHorasDisponibles( DateTime fechaSeleccionada)
        {
            return DDXH.ObtenerHorasDisp(fechaSeleccionada);
        }

        public int EliminarFechadeDisponibles(DateTime fechaSeleccionada)
        {
            return DDXH.EliminarFechadeDisp(fechaSeleccionada);
        }

        public int AgregarFechaDisponible(DateTime fecha, TimeSpan hora)
        {
            return DDXH.AgregarFechaDisp(fecha, hora);
        }

        
    }
}
