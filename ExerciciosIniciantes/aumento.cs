using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, aumento;
            Console.Write("Qual é o salario do funcionario: R$");
            valor = double.Parse(Console.ReadLine());
            aumento = valor + valor * 15 / 100;
            Console.WriteLine("Um funcionario que ganhava R$" + valor + ", com 15% de aumento, passa a receber R${0:F2}" , aumento);
            Console.ReadKey();
        }
    }
}
