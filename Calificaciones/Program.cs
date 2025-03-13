using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Validar la nota final de un estudiante
            //Tabata Vernaza
            int calificacion;
            do
            {
                Console.Write("Ingresa tu calificación en números (0-100): ");
                calificacion = int.Parse(Console.ReadLine());

                if (calificacion >= 90)
                {
                    Console.WriteLine("Tu calificación es A");
                }
                else if (calificacion >= 80)
                {
                    Console.WriteLine("Tu calificación es B");
                }
                else if (calificacion >= 70)
                {
                    Console.WriteLine("Tu calificación es C");
                }
                else if (calificacion >= 60)
                {
                    Console.WriteLine("Tu calificación es D");
                }
                else if (calificacion <= 59)
                {
                    Console.WriteLine("Tu calificación es F");
                }
            } while (true); // Se repite el programa
        }
    }
}
