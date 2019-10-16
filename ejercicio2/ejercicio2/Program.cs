using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear  un  programa  que  lea  un  número  entero  y  a  partir  de  él  cree  un  cuadrado  de  asteriscos  con  ese tamaño. Los asteriscos sólo se verán en el borde del cuadrado, no en el interior.

            int cuadrado = 0;

            Console.WriteLine("Ingrese la altura del cuadrado:");
            cuadrado = int.Parse(Console.ReadLine());

            for (int horizontal = 0; horizontal < cuadrado; horizontal++)
            {
                for (int vertical = 0; vertical < cuadrado; vertical++)
                {
                    if (horizontal == 0 || vertical == 0 || horizontal == (cuadrado - 1) || vertical == (cuadrado - 1))
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");

                }
                Console.WriteLine(" ");


            }
            Console.ReadKey();
        }
    }
}
