using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turnos
    {

		string idTurno;
		Dia dia;
		Hora hora;
		Clientes cliente;
		Motos moto;
		Servicios servicios;
		bool asistencia=false;

        public Turnos() { }

        public string IdTurno { get => idTurno; set => idTurno = value; }
        public Dia dia1 { get => dia; set => dia = value; }
        public Hora hora1 { get => hora; set => hora = value; }
        public Clientes cliente1 { get => cliente; set => cliente = value; }
        public Motos moto1 { get => moto; set => moto = value; }
        public Servicios servicios1 { get => servicios; set => servicios = value; }
        public bool asistencia1 { get => asistencia; set => asistencia = value; }
    }
}
