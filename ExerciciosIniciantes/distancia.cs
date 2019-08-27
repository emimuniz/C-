using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            Console.Write("Qual a distancia da sua viagem?");
            distancia = int.Parse(Console.ReadLine());
            Console.WriteLine("Você esta prestes a começar uma viagem de " + distancia); ;
            if (distancia <= 200)
            {
                Console.WriteLine("E o preço da sua passagem sera de R${0:F2}", distancia * 0.50);
            }
            else
            {
                Console.WriteLine("E o preço da sua passagem sera de R${0:F2}", distancia * 0.45);
            }
            Console.ReadKey();
            
        }
    }
}
