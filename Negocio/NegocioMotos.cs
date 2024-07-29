using Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMotos
    {
        DaoMotos DM = new DaoMotos();
        public DataTable ObtenerTablaMotos(string dni)
        {
            return DM.ObtenerMotos(dni);
        }

        public int AgregarMoto(string patente, string marca,string modelo,int km)
        {
            return DM.Agregar(patente, marca, modelo, km);
        }
    }
}
