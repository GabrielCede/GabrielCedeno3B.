using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {

                Console.WriteLine("\n Del siguiente menú, elija una opción: ");
                Console.WriteLine("1) Salir");
                Console.WriteLine("2) Sumatorio");
                Console.WriteLine("3) Factorial");
                Console.WriteLine(" ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                      
                        break;
                    case 2:
                        Console.WriteLine("Digite el primer valor a sumar: ");
                        int numero1 = int.Parse (Console.ReadLine());
                        Console.WriteLine("Digite el segundo valor a sumar: ");
                        int numero2 = int.Parse (Console.ReadLine());
                        Console.WriteLine("La respuesta de la sumatoria es: {0}", numero1 + numero2);
                        Console.WriteLine("Presione Enter para continuar: ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Digite un número para calcular el factorial: ");
                        int numero =int.Parse (Console.ReadLine());
                        int factorial = numero;
                        for (int i = numero - 1; i >= 1; i--)
                        {
                            factorial = factorial * i;
                        }
                        Console.WriteLine("El factorial de {0} es {1}", numero, factorial);
                        Console.WriteLine("Precione Enter para continuar: ");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 1);

        }
    }
}
    

