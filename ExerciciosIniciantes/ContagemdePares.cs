using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    i++;
                }
               
            }
            Console.Write("Acabou");
            Console.ReadKey();


        }
    }
}
