using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {


		string dni;
		string nombre;
		string apellido;
		string domicilio;
		string telefono;
		string email;
        string contraseña;
		bool estado=true;

        public Clientes() { }

        public string Dni1 { get => dni; set => dni = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido; set => apellido = value; }
        public string Domicilio1 { get => domicilio; set => domicilio = value; }
        public string Telefono1 { get => telefono; set => telefono = value; }
        public string Email1 { get => email; set => email = value; }
        public bool Estado1 { get => estado; set => estado = value; }
        public string Contraseña1 { get => contraseña; set => contraseña = value; }
    }
}
