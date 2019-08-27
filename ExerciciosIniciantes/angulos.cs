using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int angulo;
            double seno, cosseno, tangente, randians;
            Console.Write("Digite o angulo que você deseja: ");
            angulo = int.Parse(Console.ReadLine());
            randians = angulo * (Math.PI / 180);
            seno = Math.Sin(randians);
            cosseno = Math.Cos(randians);
            tangente = Math.Tan(randians);
            Console.WriteLine("O angulo de " + angulo + " tem SENO de {0:F2}" , seno);
            Console.WriteLine("O angulo de " + angulo + " tem COSSENO de {0:F2}" , cosseno);
            Console.WriteLine("O angulo de " + angulo + " tem TANGENTE de {0:F2}" , tangente);
            Console.ReadKey();
        }
    }
}
