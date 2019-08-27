using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, km;
            double pagar;
            Console.Write("Quantos dias alugados: ");
            dias = int.Parse(Console.ReadLine());
            Console.Write("Quantos km rodados: ");
            km = int.Parse(Console.ReadLine());
            pagar = dias * 60 + km * 0.15;
            Console.WriteLine("O total a pagar é de R${0:F2}" , pagar);
            Console.ReadKey();
        }
    }
}
