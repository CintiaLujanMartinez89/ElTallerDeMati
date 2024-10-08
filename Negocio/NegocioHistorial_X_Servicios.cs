﻿using Dao;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{   
      public  class NegocioHistorial_X_Servicios
    {
        DaoHistorial_X_Servicios DHXS = new DaoHistorial_X_Servicios();
        
        public DataTable ObtenerTablaHistorial()
        {
            return DHXS.ObtenerTablaHisto();
        }

       public DataTable BuscarXDni_Patente(string dni,string patente)
        {
            return DHXS.BuscarXDni_Patente(dni,patente);
        }
       
        public DataTable BuscarXDni(string dni)
        {
            return DHXS.BuscarXDni(dni);
        }

        public DataTable BuscarXPatente(string dni)
        {
            return DHXS.BuscarXPatente(dni);
        }

        public void guardarHistorial(Historial_X_Servicios obj)
        {
            DHXS.guardarHistorialXServicio(obj);
        }

        public void eliminarHistorialPorTurno(string dni, DateTime dia, string patente)
        {
            DHXS.eliminarHistorialPorTurno(dni, dia, patente);
        }

       public void GuardaObservacion(string dni, DateTime dia, string patente, string observacion)
        {
            DHXS.GuardaObservacion(dni, dia, patente, observacion);
        }
    }

}
