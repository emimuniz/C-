using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, desconto; 
            Console.Write("Qual é o preço do produto: ");
            valor = double.Parse(Console.ReadLine());
            desconto = valor - valor * 5 / 100;
            Console.WriteLine("O produto que custava R$" + valor + ", na promoção com desconto de 5% vai custar R$ {0:F2}" , desconto);
            Console.ReadKey();

        }
    }
}
