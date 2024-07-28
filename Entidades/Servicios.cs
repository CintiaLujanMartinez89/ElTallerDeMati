using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Servicios
    {
	string id_Servicio;
	string nombre;
	string detalle;
	float precio;

		public Servicios() { }

        public string id_Servicio1 { get => id_Servicio; set => id_Servicio = value; }
        public string nombre1 { get => nombre; set => nombre = value; }
        public string detalle1 { get => detalle; set => detalle = value; }
        public float precio1 { get => precio; set => precio = value; }
    }
}
