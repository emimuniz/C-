using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {

        static void Main(string[] args)
        {
            int ano;
            Console.Write("Que ano quer analisar? Coloque 0 para analisar o ano atual: ");
            ano = int.Parse(Console.ReadLine());
            if (ano == 0) {
                ano = DateTime.Now.Year;
            }
            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0){
                Console.WriteLine("O ano " + ano + " é BISSEXTO");
            }
            else {
                Console.WriteLine("O ano " + ano + " NÂO È BISSEXTO");
            }
            Console.ReadKey();
        }
    }
}
