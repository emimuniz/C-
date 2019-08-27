using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("É um prazer te conhecer, " + nome + "!");
            Console.ReadKey();
        }
    }
}
