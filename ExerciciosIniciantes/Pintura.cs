using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, altura, dimensao, tinta;
            Console.Write("Largura da Parede: ");
            largura = double.Parse(Console.ReadLine());
            Console.Write("Altura da parede: ");
            altura = double.Parse(Console.ReadLine());
            dimensao = altura * largura;
            tinta = dimensao / 2;
            Console.WriteLine("Sua parede tem dimensão de " + largura + "x" + altura + " e sua area da dimensão é de "+dimensao+"m2");
            Console.WriteLine("Para pintar essa parede, você precisara de " + tinta + "l de tinta.");
            Console.ReadKey();

        }
    }
}
