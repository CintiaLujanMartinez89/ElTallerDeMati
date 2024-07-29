using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioDia
    {
        DaoDia DD = new DaoDia();
        public List<DateTime> ObtenerDiasDisponibles()
        {
            return DD.ObtenerDiasDisp();
        }
    }
}
