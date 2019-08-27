using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorc, salario, anos, valor, parcela, anos2;
            Console.Write("Digite o valor da casa: R$");
            valorc = double.Parse(Console.ReadLine());
            Console.Write("Digite o salario do comprador: R$");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Quantos anos de financiamento: ");
            anos = double.Parse(Console.ReadLine());
            valor = salario * 30 / 100;
            anos2 = anos * 12;
            parcela = valorc / anos2;
            Console.WriteLine("Para pagar uma casa de " + valorc + " em " + anos + " a prestação será de {0:F2} R$" , parcela);
            if (valor >  parcela) {
                Console.WriteLine("Emprestimo aprovado");
            }
            else {
                Console.WriteLine("Emprestimo negado");
            }
            Console.ReadKey();
          
        }
    }
}
