using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Introduktion_till_villkor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad är lösenordet?");
            string input = Console.ReadLine();
            if (input.ToLower() == "gurka")
            {
                Console.WriteLine("Välkommen till systemet");
            }
            else
            {
                Console.WriteLine("Go home...");
            }
            Console.ReadLine();

            //Nytt program
            Console.WriteLine("Gillar du att programmera?");
            string inmatning = Console.ReadLine();
            if (inmatning.ToLower() == "ja" || inmatning.ToLower() == "jajamän" || inmatning.ToLower() == "japp")
            {
                Console.WriteLine("Kul att höra :-).");
            }
            else
            {
                Console.WriteLine("Kämpa på ändå!");
            }
            Console.ReadLine();

            //Nytt program
            Console.WriteLine("Vad är din favoritfärg?");
            string skrivning = Console.ReadLine();
            if (skrivning.ToLower() == "blå")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blått är vått");
            }
            else if (input.ToLower() == "röd")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Rött är sött");
            }
            else if (input.ToLower() == "gul")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Gult är fult");
            }
            else
            {
                Console.WriteLine("Kul färg");
            }
            Console.ReadLine();
        }
    }
}
