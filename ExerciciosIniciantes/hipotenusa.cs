using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            double oposto, adjacente, hipotenusa;
            Console.Write("Comprimento do cateto oposto: ");
            oposto = double.Parse(Console.ReadLine());
            Console.Write("Comprimento do cateto adjacente: ");
            adjacente = double.Parse(Console.ReadLine());
            hipotenusa = Math.Sqrt(Math.Pow(oposto,2) + Math.Pow(adjacente,2));
            Console.WriteLine("A hipotenusa vai medir {0:F2}", hipotenusa);
            Console.ReadKey();
        }
    }
}
