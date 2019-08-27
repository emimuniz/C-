using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, dobro, triplo;
            double raiz;

            Console.Write("Digite um valor: ");
            num1 = int.Parse(Console.ReadLine());
            dobro = num1 * 2;
            triplo = num1 * 3;
            raiz = Math.Sqrt(num1);

            Console.WriteLine("O dobro de " + num1 + " vale " + dobro);
            Console.WriteLine("O triplo de " + num1 + " vale " + triplo);
            Console.WriteLine("A raiz quadrada de " + num1 + " é igual a: {0:F2} ", raiz);
            Console.ReadKey();

        }
    }
}
