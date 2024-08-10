using System;
using Dao;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class NegocioHistorial
    {
        DaoHistorial DH = new DaoHistorial();
        public string ObtenerIdHistorial(string dni, string patente)
        {
           return DH.ObtenerIdHistorial(dni, patente);
        }

        public int AgregarHistorial(string dniLogueado,string  patente)
        {
            return DH.Agregar(dniLogueado, patente);
        }
    }
}
