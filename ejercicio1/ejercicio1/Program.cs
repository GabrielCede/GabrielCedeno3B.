using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que lea una serie de números por teclado e indique cuál es el mayor.

            int cantidad, numero, mayor = 0, menor = 0;

            Console.WriteLine("Digite la cantidad de números a comparar:");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {

                Console.WriteLine("Digite un número:");
                numero = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = numero;

                }
                else

                    if (i != 0)
                {
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                    if (numero > mayor)
                    {

                        mayor = numero;
                    }
                }


            }
            Console.WriteLine("el número mayor es:" + mayor);
            Console.ReadKey();
        }
    }
}
