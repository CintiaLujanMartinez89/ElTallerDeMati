using Dao;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable CargarTablaCliXMot()
        {
            return DCXM.CargarTabla();
        }

        public DataTable BuscarXDni_Patente(string dni,string patente)
        {
            return DCXM.BuscarXDni_Patente(dni, patente);
        }


        public DataTable BuscarXDni(string dni)
        {
            return DCXM.BuscarXDni(dni);
        }

        public DataTable BuscarXPatente(string patente)
        {
            return DCXM.BuscarXPatente(patente);
        }
    }
}
