using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa en C# que lea un número entero positivo y que escriba tres columnas. La primera cuenta desde uno hasta el número escrito contando de uno en uno; la segunda columna cuenta de dos en dos y la tercera de tres. 

            int columna1 = 0;
            int columna2 = 0;
            int columna3 = 0;
            Console.WriteLine("Ingrese un numero");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                columna1++;
                columna2 = columna2 + 2;
                columna3 = columna3 + 3;
                Console.WriteLine(columna1 + " " + columna2 + " " + columna3);
            }
        }
    }
}
