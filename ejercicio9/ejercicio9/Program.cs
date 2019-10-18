using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la tabla deseada:");
            int m = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 15; i++)
            {
                m = n * i;
                Console.WriteLine($"{n} x {i} = {m}");
            }
        }
    }
}
