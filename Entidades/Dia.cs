using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dia
    {
        public DateTime Fecha;

        // Constructor
        public Dia(DateTime fecha)
        {
            Fecha = fecha;
        }

        // Metodo
        public override string ToString()
        {
            return Fecha.ToShortDateString();
        }

        // Ejemplo de un método estático para generar una lista de días en un mes

        public static List<Dia> GenerarDiasDelMes(int year, int month)
        {
            List<Dia> diasDelMes = new List<Dia>();
            int diasEnElMes = DateTime.DaysInMonth(year, month);

            for (int dia = 1; dia <= diasEnElMes; dia++)
            {
                DateTime fecha = new DateTime(year, month, dia);
                diasDelMes.Add(new Dia(fecha));
            }

            return diasDelMes;
        }

        /* // Crear un día específico
        Dia diaEspecial = new Dia(new DateTime(2024, 7, 26));
        Console.WriteLine(diaEspecial.ToString());

        // Generar días para un mes específico
        List<Dia> diasJulio2024 = Dia.GenerarDiasDelMes(2024, 7);
        foreach (var dia in diasJulio2024)
        {
            Console.WriteLine(dia.ToString());
        }
         */
    }

}
