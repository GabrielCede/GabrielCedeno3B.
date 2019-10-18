using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que escriba dos columnas de números, en la primera se colocan los números del 1 al 100, en la segunda los números del 100 al 1.
            int columna1 = 0;
            int columna2 = 101;
            for (int i = 1; i <= 100; i++)
            {
                columna1++;
                columna2--;
                Console.WriteLine(columna1 + " " + columna2);

            }
        }
    }
}
