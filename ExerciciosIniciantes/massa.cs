using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, massa; 
            Console.Write("Qual é seu peso? (kg) ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Qual é sua altura?(m) ");
            altura = double.Parse(Console.ReadLine());
            massa = peso / (altura * altura);
            Console.WriteLine("O IMC dessa pessoa é de {0:F2}" , massa);
            if (massa < 18.5){
                Console.Write("ABAIXO DO PESO");
            }
            else if  (massa > 18.5 && massa < 25){
                Console.Write("PESO IDEAL");
            }
            else if (massa > 25 && massa < 30){
                Console.Write("SOBREPESO");

            }
            else if (massa > 30 && massa < 40){
                Console.Write("OBESIDADE");
            }
            else{
                Console.Write("OBESIDADE MORBITA");
            }

            Console.ReadKey();
        }
    }
}
