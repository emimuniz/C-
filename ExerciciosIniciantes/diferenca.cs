using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, DIFERENCA;
            Console.Write("Digite um valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite segundo valor: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto valor: ");
            num4 = int.Parse(Console.ReadLine());
            DIFERENCA = (num1 * num2 - num3 * num4);
            Console.WriteLine("DIFERENÇA = " + DIFERENCA);
            Console.ReadKey();
        }
    }
}
