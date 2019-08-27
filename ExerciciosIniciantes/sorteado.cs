using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int sorteado, num1; 
            Random rdm = new Random();
            sorteado = rdm.Next(10);
            Console.WriteLine("-------------------------------------------");
            Console.Write("Descobra o numero sorteado 1 ate 10: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            if (num1 == sorteado)
                Console.WriteLine("Você ganhou!");
            else
                Console.WriteLine("Você Perdeu, numero sorteado foi "+sorteado+". Tente novamente");
            
            Console.ReadKey();

        }
    }
}
