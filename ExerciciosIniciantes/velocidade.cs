using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidade;
            double valor;
            Console.Write("Qual é velocidade do carro? ");
            velocidade = int.Parse(Console.ReadLine());
            valor = (velocidade - 80) * 7;
            if (velocidade > 80) {
               
                Console.WriteLine("MULTADO! Você execedeu o limite permitido que é de 80km/h \n Você deve pagar uma multa de R${0:F2}" , valor);
            }

            Console.WriteLine("Tenha um bom dia! Dirija com segurança.");
            Console.ReadKey();
        }
    }
}
