using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas, comissao;
            Console.Write("Digite o nome do funcionario: ");
            nome = Console.ReadLine();
            Console.Write("Digite o salario do funcionario: ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o total de vendas: ");
            vendas = double.Parse(Console.ReadLine());
            comissao = salario + vendas * 15/100;
            Console.WriteLine("TOTAL = R${0:F2}", comissao);
            Console.ReadKey();
        }
    }
}
