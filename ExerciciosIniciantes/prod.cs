using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, PROD;
            Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            PROD = num1 * num2;
            Console.WriteLine("PROD = " + PROD);
            Console.ReadKey();
        }
    }
}
