using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, SOMA;
            Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            SOMA = num1 + num2;
            Console.WriteLine("SOMA = " + SOMA);
            Console.ReadKey();
        }
    }
}
