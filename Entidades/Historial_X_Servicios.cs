using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class Historial_X_Servicios { 
	
	string idHistorial;
        string dni;
        string patente;
        string idServicio;
        DateTime Fecha_Realizacion;
	 int kilometraje;

        public Historial_X_Servicios() { }

        public string idHistorial1 { get => idHistorial; set => idHistorial = value; }
        public string dni1 { get => dni; set => dni = value; }
        public string patente1 { get => patente; set => patente = value; }
        public string idServicio1 { get => idServicio; set => idServicio = value; }
        public DateTime fecha_Realizacion1 { get => Fecha_Realizacion; set => Fecha_Realizacion = value; }
        public int kilometraje1 { get => kilometraje; set => kilometraje = value; }
    }
}
