using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;

            Console.Write("Digite um valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.Write("A soma entre " + num1 + " e " + num2 + " é igual a: " + soma);
            Console.ReadKey();
        }
    }
}
