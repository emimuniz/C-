using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            object datanasc;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite sua data de nascimento: ");
            datanasc = Console.ReadLine();
            if (idade >= 18) {
                Console.WriteLine("Você está na idade de tirar habilitação");
            }
            else
            {
                Console.Write("Você esta muito novo para tirar habilitação");
            }
            Console.ReadKey();
            Console.Clear();

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua data de nascimento: ");
            datanasc = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Olá " + nome + " sua idade é " + idade + ", você nasceu na data: " + datanasc);
            Console.ReadKey(); 
        }
    }
}
