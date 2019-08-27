using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            Console.Write("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine());
            area = 3.14159 * Math.Pow(raio, 2);
            Console.WriteLine("A = {0:F4}", area);
            Console.ReadKey();


        }
    }
}
