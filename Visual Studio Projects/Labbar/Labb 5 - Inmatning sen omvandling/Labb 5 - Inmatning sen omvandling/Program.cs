using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___Inmatning_sen_omvandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Meddelande och input
            Console.Write("Hur gammal är du? (Skriv bara med siffror) ");
            string inmatning = Console.ReadLine();
            int ålder = Convert.ToInt32(inmatning);

            //Välja output beroende på input
            if (ålder > 18)
            {
                Console.WriteLine("Oj, är du redan " + ålder + "år gammal!");
            }
            else
            {
                Console.WriteLine("Är du bara " + ålder + "...");
            }

            Console.ReadLine();

            //Nytt program
            Console.Write("Hur många grader är det ute? (Svara i heltal)  ");
            string input = Console.ReadLine();
            int grader = Convert.ToInt32(input);

            if (grader > 24)
            {
                Console.WriteLine("Baddags!");
            }
            else
            {
                Console.WriteLine("Jaja, lika bra att vara i skolan...");
            }

            Console.ReadLine();

            //Nytt program
            Console.Write("Gissa på ett tal 1 tom 10!");

            while (true)
            {
                string skrivning = Console.ReadLine();
                int tal = Convert.ToInt32(skrivning);


                if (tal == 4)
                {
                    Console.WriteLine("Rätt gissat!");
                    break;
                }
                else
                {
                    Console.WriteLine("Helt fel! Gissa igen!");
                }
            }
            Console.ReadLine();
        }
    }
}
