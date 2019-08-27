using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, antecessor, sucessor;

            Console.Write("Digite um valor: ");
            num1 = int.Parse(Console.ReadLine());
            antecessor = num1 - 1;
            sucessor = num1 + 1;
            Console.Write("Analisando o valor " + num1 + ", seu antecessor é " + antecessor + "  e o sucessor é " + sucessor);
            Console.ReadKey();
        }
    }
}
