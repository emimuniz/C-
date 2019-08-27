using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            Console.Write("Digite sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            media = (nota1 * 3.5 + nota2 * 7.5 )/ 11;
            Console.WriteLine("MEDIA = {0:F5}" , media);
            Console.ReadKey();
        }
    }
}
