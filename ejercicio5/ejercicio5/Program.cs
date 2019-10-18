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
              int altura = 0;

            Console.WriteLine(" Ingrese el nùmero para la altura de la pirámide:");
            altura = int.Parse(Console.ReadLine());
            int A = 0, B = 0;
            for (int i = 1; i <= altura ; i++)
            {
                for (A = 1; A <= (altura - i); A++)
                {
                    Console.Write(" ");
                }
                for (B = 1; B <= i; B++)
                {
                    Console.Write('*');
                }
                for (B = (i - 1); B >= 1; B--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
