using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            float medida, km, hm, dam, dm, cm, mm;

            Console.Write("Uma distancia em metros: ");
            medida = float.Parse(Console.ReadLine());
            km = medida / 1000;
            hm = medida / 100;
            dam = medida / 10;
            dm = medida * 10;
            cm = medida * 100;
            mm = medida * 1000;

            Console.WriteLine("A medida de " + medida + " corresponde a ");
            Console.WriteLine(+km + "km \n" + hm + "hm \n" + dam + "dam \n" + dm + "dm \n" + cm + "cm \n" + mm + "mm");
            Console.ReadKey();
        }
    }
}
