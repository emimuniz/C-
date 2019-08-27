using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            double impar;
            Console.Write("Me diga um numero qualquer: ");
            num1 = int.Parse(Console.ReadLine());
            impar = num1 % 2;
            if (impar == 0) { 
                Console.Write("O numero " + num1 + " é PAR");
            }
            else {
                Console.Write("O numero " + num1 + " é IMPAR");
            }

            Console.ReadKey();
        }
    }
}
