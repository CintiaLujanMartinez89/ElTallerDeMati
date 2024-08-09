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

       public int EliminarServicio(Entidades.Servicios obj)
        {
          return DS.EliminarServ(obj);
        }

        public int AgregarServicio(string idServicio, string nombre, string descripcion,float precio)
        {
            return DS.AgregarServ( idServicio, nombre, descripcion,precio);
        }

       public int ActualizarServicio(Entidades.Servicios obj)
        {
           return DS.ActualizarServ(obj);
        }
    }
}
