using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class Program
    {
     

        static void Main(string[] args)
        {
            int opcao, sorteado;
            Random rdm = new Random();
            Console.WriteLine("Suas opções: \n [0] PEDRA \n [1] PAPEL \n [2] TESOURA");
            Console.Write("Qual é sua jogada? ");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("JO");
            Thread.Sleep(2000);
            Console.WriteLine("KEN");
            Thread.Sleep(2000);
            Console.WriteLine("PO!!");
            Thread.Sleep(2000);
            sorteado = rdm.Next(2);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            if (sorteado == 0){
                Console.WriteLine("O computador jogou PEDRA");
            }
            else if (sorteado == 1){ 
                Console.WriteLine("O computador jogou PAPEL");
            }
            else if(sorteado == 2){
                Console.WriteLine("O computador jogou TESOURA");
            }
            if  (opcao == 0){
                Console.WriteLine("O jogador jogou PEDRA");
            }
            else if (opcao == 1){
                Console.WriteLine("O jogador jogou PAPEL");
            }
            else if(opcao == 2){
                Console.WriteLine("O jogador jogou TESOURA");
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            if (sorteado == opcao){
                Console.WriteLine("EMPATE");
            }
            else if(sorteado == 0 && opcao == 1){
                Console.WriteLine("Jogador Venceu");
            }
            else if (sorteado == 1 && opcao == 0)
            {
                Console.WriteLine("Computador Venceu");
            }
            else if (sorteado == 1 && opcao == 2)
            {
                Console.WriteLine("Jogador Venceu");
            }
            else if (sorteado == 2 && opcao == 1)
            {
                Console.WriteLine("Computador Venceu");
            }
            else if (sorteado == 0 && opcao == 2)
            {
                Console.WriteLine("Computador Venceu");
            }
            else if (sorteado == 2 && opcao == 0)
            {
                Console.WriteLine("Jogador Venceu");
            }
           
            Console.ReadKey();
        }
    }
}
