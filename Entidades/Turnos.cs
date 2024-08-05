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
		DateTime dia;
		TimeSpan hora;
		string dni;
        string patente;
        string idServicio;
        string observacion;
        bool asistencia=false;
		

        public Turnos() { }

        public string IdTurno { get => idTurno; set => idTurno = value; }
        public DateTime Dia { get => dia; set => dia = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Patente { get => patente; set => patente = value; }
        public string IdServicio { get => idServicio; set => idServicio = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public bool Asistencia { get => asistencia; set => asistencia = value; }
    }
}
