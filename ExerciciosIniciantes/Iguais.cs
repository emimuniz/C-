using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Digite um valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2){
                Console.Write("O primeiro numero é maior");
            }
            else if (num2 > num1){
                Console.Write("O segundo numero é maior");
            }
            else {
                Console.Write("Nenhum dos dois numeros é maior, são exatamente iguais");
            }
            Console.ReadKey();
        }
    }
}
