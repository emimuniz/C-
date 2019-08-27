using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;
            Console.Write("Digite sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;
            Console.WriteLine("MEDIA = "+media);
            Console.ReadKey();
        }
    }
}
