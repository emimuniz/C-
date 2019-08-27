using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura, f; 
            Console.Write("Informe a temperatura em °C: ");
            temperatura = double.Parse(Console.ReadLine());
            f = temperatura*1.8 + 32;
            Console.WriteLine("A temperatura de " + temperatura + "°C corresponde a " + f + "°F");
            Console.ReadKey();
        }
    }
}
