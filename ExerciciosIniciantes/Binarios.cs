using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto;
            string numBinario = "";
            Console.WriteLine("================ Binario =================");
            Console.Write("Digite um numero inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
            while(num/2 >= 1)
            {
                numBinario = Convert.ToString(num % 2) + numBinario;
                num = num / 2;
            }
           numBinario = Convert.ToString(num) + numBinario;
           Console.WriteLine("Convertido para BINARIO é igual a " + numBinario);
           Console.ReadKey();
        }
    }
}
