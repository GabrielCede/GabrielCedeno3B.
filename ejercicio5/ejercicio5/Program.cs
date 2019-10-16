using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para la altura de la pirámide: ");
            int numero = int.Parse(Console.ReadLine());
            int j = 0, k = 0;
            for (int i = 1; i <= numero; i++)
            {
                for (j = 1; j <= (numero - i); j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write('*');
                }
                for (k = (i - 1); k >= 1; k--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
