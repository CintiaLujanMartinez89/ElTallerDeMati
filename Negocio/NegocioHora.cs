using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
  public  class NegocioHora
    {
        DaoHora DH = new DaoHora();
        public List<TimeSpan> ObtenerHorasDisponibles()
        {
            return DH.ObtenerHorasDisp();
        }
    }
}
