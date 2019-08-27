using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, total;
            Console.Write("");
            X = double.Parse(Console.ReadLine());
            Console.Write("");
            Y = double.Parse(Console.ReadLine());
            total = X / Y;
            Console.Write("{0:F3} km/l", total);
            Console.ReadKey();

        }
    }
}
