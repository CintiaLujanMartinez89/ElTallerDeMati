using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Historial
    {
		string idHistorial;
		string dni;
		string patente;

        public Historial() { }

        public string idHistorial1 { get => idHistorial; set => idHistorial = value; }
        public string dni1 { get => dni; set => dni = value; }
        public string patente1 { get => patente; set => patente = value; }
    }
}
