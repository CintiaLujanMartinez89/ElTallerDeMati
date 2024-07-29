using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
   public class NegocioClientes_X_Motos
    {
        DaoClientes_X_Motos DCXM = new DaoClientes_X_Motos();

        public int AgregarClienteXMoto(string dniLogueado,string patente)
        {
            return DCXM.AgregarCXM(dniLogueado,patente);
        }

    }
}
