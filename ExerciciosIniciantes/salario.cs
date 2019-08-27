using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, horas, valor, salario;
            Console.Write("Digite o numero do funcionario: ");
            numero = double.Parse(Console.ReadLine());
            Console.Write("Digite a carga horaria do funcionario: ");
            horas = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor que recebe por horas: ");
            valor = double.Parse(Console.ReadLine());
            salario = horas * valor;
            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ {0:F2}", salario);
            Console.ReadKey();

        }
    }
}
