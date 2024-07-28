using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hora
    {
        // Propiedad
        public TimeSpan Tiempo { get; set; }

        // Constructor
        public Hora(TimeSpan tiempo)
        {
            Tiempo = tiempo;
        }

        // Métodos
        public override string ToString()
        {
            return Tiempo.ToString(@"hh\:mm");
        }

        // Ejemplo de un método estático para generar una lista de horas en un día
        public static List<Hora> GenerarHorasDelDia(int intervaloMinutos)
        {
            List<Hora> horasDelDia = new List<Hora>();
            for (int i = 0; i < 24 * 60; i += intervaloMinutos)
            {
                TimeSpan tiempo = new TimeSpan(0, i, 0);
                horasDelDia.Add(new Hora(tiempo));
            }

            return horasDelDia;
        }
    }

         /* // Crear una hora específica
        Hora horaEspecial = new Hora(new TimeSpan(14, 30, 0));
        Console.WriteLine(horaEspecial.ToString());

            // Generar horas para un día con intervalos de 30 minutos
        List<Hora> horasDelDia = Hora.GenerarHorasDelDia(30);
        foreach (var hora in horasDelDia)
        {
            Console.WriteLine(hora.ToString());
        }
        */


}
