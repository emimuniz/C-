using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            float p1, p2, media;
            Console.Write("Digite sua nota: ");
            p1 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            p2 = float.Parse(Console.ReadLine());
            media = p1 + p2 / 2;
            if (media > 5.0) {
                Console.WriteLine("APROVADO");
            }
                
            else if (media > 5.0 && media < 6.9) {
                Console.WriteLine("RECUPERAÇÂO");
            }
            else {
                Console.WriteLine("REPROVADO");
            }
            Console.ReadKey();
        }
    }
}
