using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, anoatual, idade;
            Console.Write("Digite sua data de nascimento: ");
            ano = int.Parse(Console.ReadLine());
            anoatual = DateTime.Now.Year;
            idade = anoatual - ano;
            Console.WriteLine("O atleta tem " + idade+" anos");
            Console.Write("Classificação: ");
            if (idade < 9){
                Console.Write("MIRIM");
            }
            else if (idade > 9 && idade <= 14){
                Console.Write("INFANTIL");
            }
            else if (idade > 14 && idade <= 19){
                Console.Write("JUNIOR");
            }
            else if (idade > 19 && idade <= 25){
                Console.Write("SÊNIOR");
            }
            else{
                Console.Write("MASTER");
            }
            Console.ReadKey();
        }
    }
}
