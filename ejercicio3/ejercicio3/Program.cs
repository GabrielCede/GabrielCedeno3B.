using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
             //Crear un programa que lea cantidades y precios y al final indique el total de la factura.Primero se pregunta: Introduzca la cantidad vendida tras lo cual el usuario introducirá un número entero positivo.Después se pregunta: Introduzca el precio que será un número decimal positivo.La lectura termina cuando en la cantidad se introduzca un cero.Si es así se escribirá el total.

            int producto = 0;
            double valor = 0, acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese cantidad de artículos vendidos: ");
                producto = int.Parse(Console.ReadLine());
                if (producto != 0)
                {
                    Console.WriteLine("Ingrese el precio del producto: ");
                    valor = double.Parse(Console.ReadLine());
                }
                acumulador = acumulador + (valor * producto);
            } while (producto != 0);
            Console.WriteLine("El valor total a pagar es de :" + acumulador + "dólares");
            Console.ReadKey();
        }
    }
}
