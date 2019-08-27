using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, sorteado;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==========================================")
;           Console.WriteLine("TENTE ADIVINHAR O NUMERO QUE ESTAVA PENSANDO");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.Write("Digite um numero de 1 até 100: ");
            num1 = int.Parse(Console.ReadLine());
            Random rdm = new Random();
            sorteado = rdm.Next(100);
            if (sorteado == num1)
                    Console.WriteLine("Você acertou!");
            else
                    Console.WriteLine("Voce errou! O NUMERO SORTEADO FOI " + sorteado);

            Console.ReadKey();

        }
    }
}
