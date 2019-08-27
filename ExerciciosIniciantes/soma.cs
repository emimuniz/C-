using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
            Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("X = " +soma);
            Console.ReadKey();
        }
    }
}
