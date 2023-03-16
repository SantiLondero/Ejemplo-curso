using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (n < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
                Console.WriteLine("Nulo");

            Console.ReadKey();
        }
    }
}
