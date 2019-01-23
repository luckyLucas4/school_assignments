using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Labb_8___Loopar_med_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int antalVarv = 0;
            while(antalVarv < 1000)
            {
                Console.Write(antalVarv + " Hej ");
                antalVarv = antalVarv + 1;
            }
            Console.WriteLine();
            Console.WriteLine("Slut på loopen.");
            Console.ReadLine();


            //Nytt program
            int varv = 1;
            while(varv <= 100)
            {
                Console.WriteLine(varv + " ");
                varv = varv + 1;
            }
            Console.ReadLine();


            //Nytt program
            for(int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Hej! Nu är vi på varv " + i);
            }
            Console.ReadLine();


            //Nytt program
            for(int i = 20; i >= 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(500);
                if(i == 0)
                {
                    Console.Write("BOOOOOOOOM!");
                }
            }
            Console.ReadLine();


            //Nytt program
            Console.WriteLine("Tips: Tryck ESC för att fly, annars kan du ju alltid stanna kvar och se vad som händer, för det borde hända snart");
            Thread.Sleep(3000);
            while(true)
            {
                Console.Write("Hej igen!");
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape) break;
            }
            Console.ReadLine();


            //Nytt program
            Console.Write("Hur många gånger? ");
            string input = Console.ReadLine();
            int gånger = Convert.ToInt32(input);
            for(int i = 0; i <= gånger; i++)
            {
                Console.WriteLine("Hej " + i);
            }
            Console.ReadLine();


            //Nytt program
            Console.Write("Vilken text? ");
            string text = Console.ReadLine();
            Console.Write("Hur många gånger? ");
            string inmatning = Console.ReadLine();
            int times = Convert.ToInt32(inmatning);
            for(int i = 1; i <= times; i++)
            {
                Console.WriteLine(text + i);
            }
            Console.ReadLine();
        }
    }
}
