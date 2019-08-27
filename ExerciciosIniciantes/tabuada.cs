using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, contador;

            Console.Write("Digite um numero para ver a tabuada: ");
            num1 = int.Parse(Console.ReadLine());
            contador = 1;
            Console.WriteLine("==========================================================");
            while (contador <=  10)
            {
                Console.WriteLine(+num1 + "x" + contador + "=" + num1 * contador);
                contador = contador + 1;
            }
            Console.WriteLine("==========================================================");
            Console.ReadKey();

        }
    }
}
