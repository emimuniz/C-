using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double resultado = (n1 + n2) / 2;
            Console.WriteLine("A Média é {0:F1}", resultado);
            Console.ReadKey();

        }
    }
}
