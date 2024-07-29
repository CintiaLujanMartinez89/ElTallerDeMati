using Dao;
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
            return DT.ReservarTURNO(dia, hora,dni,patente,servicio,observacion);
        }
    }
}
