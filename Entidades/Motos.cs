using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Motos
    {
        string patente;
        string marca;
        string modelo;
        int km_Inicial = 0;
        bool estado = true;

        // Constructor
        public Motos() { }

        public string patente1 { get => patente; set => patente = value; }
        public string marca1 { get => marca; set => marca = value; }
        public string modelo1 { get => modelo; set => modelo = value; }
        public int km_Inicial1 { get => km_Inicial; set => km_Inicial = value; }
        public bool estado1 { get => estado; set => estado = value; }
    }



}
