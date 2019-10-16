using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas = 0, total = 0;

            Console.WriteLine("Ingrese las horas trabajadas: ");
            horas = int.Parse(Console.ReadLine());
            if (horas <= 35)
            {
                total = horas * 15;
            }
            else
            {
                total = ((35 * 15) + (horas - 35) * 22);
            }
            Console.WriteLine("La cantidad que se le debe pagar es:" + total + "dólares");
            Console.ReadKey();
        }
    }
}
