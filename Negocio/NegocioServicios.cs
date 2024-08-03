using Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   
    public class NegocioServicios
    {
        DaoServicios DS = new DaoServicios();
        public DataTable ObtenerServicios()
        {
            return DS.ObternerServ();
        }
    }
}
