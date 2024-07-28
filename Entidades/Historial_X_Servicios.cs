using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class Historial_X_Servicios { 
	
	 Historial historial;
	 Servicios servicio;
	 Dia dia;
	 int kilometraje;

        public Historial Historial1 { get => historial; set => historial = value; }
        public Servicios Servicio1 { get => servicio; set => servicio = value; }
        public Dia Dia1 { get => dia; set => dia = value; }
        public int Kilometraje1 { get => kilometraje; set => kilometraje = value; }
    }
}
