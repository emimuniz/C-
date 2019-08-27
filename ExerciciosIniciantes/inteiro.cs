using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("Digite um valor: ");
            num1 = double.Parse(Console.ReadLine());
            num2 = Math.Truncate(num1);
            Console.WriteLine("O valor digitado foi " + num1 + " e a sua porção inteira é " + num2);
            Console.ReadKey();
        }
    }
}
