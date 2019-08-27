using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double comprar, money;
            Console.Write("Quanto voce tem de dinheiro? R$");
            money = double.Parse(Console.ReadLine());
            comprar = money / 3.27;
            Console.WriteLine("Com " + money + " voce pode comprar US${0:F2}" , comprar);
            Console.ReadKey();


        }
    }
}
