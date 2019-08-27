using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.Write("A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            B = int.Parse(Console.ReadLine());
            B = A - B;
            A = A - B;
            B = A + B;
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.ReadKey();
        }
    }
}
