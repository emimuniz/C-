using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {

            int ano, anoatual, idade;
            Console.Write("Digite o ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());
            anoatual = DateTime.Now.Year;
            idade = anoatual - ano;
            if (idade < 18){
                Console.WriteLine("Você ainda ira se alistar");
                Console.WriteLine("Falta" + (idade - 18) + "anos");
            }
            else if (idade > 18) {
                Console.WriteLine("Você já passou do tempo de alistamento");
                Console.WriteLine("Passou " + (idade - 18)+"anos");
            }
            else{
                Console.WriteLine("É hora de se alistar.");
            }
            Console.ReadKey();
        }
    }
}
