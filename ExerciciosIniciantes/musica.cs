using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Escolha uma musica: Digite 1- Heartless ou 2- Over My Head: ");
            num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "C:/Users/admi/Desktop/Emi Muniz/The Fray - Heartless.wav";
                player.Play();
            }

            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "C:/Users/admi/Desktop/Emi Muniz/The Fray - Over My Head.wav";
                player.Play();
            }
            Console.ReadKey();

        }
    }
}
