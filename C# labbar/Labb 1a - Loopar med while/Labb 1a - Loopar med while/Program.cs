using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labb_1a___Loopar_med_while
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nVälj program \n1: LoopaHej \n2: Från 1 till 100 \n3: Bomben \n4: Antal gånger \n5: Upprepa text");
                ConsoleKeyInfo knappTryck = Console.ReadKey();
                switch (knappTryck.KeyChar)
                {
                    case '1':
                        Loopa_hej();
                        break;

                    case '2':
                        Från_1_till_100();
                        break;

                    case '3':
                        Bomben();
                        break;

                    case '4':
                        Antal_gånger();
                        break;

                    case '5':
                        Upprepa_text();
                        break;

                    default:
                        Console.WriteLine("\nFelaktig inmatning\n");
                        break;
                }
            }

            void Loopa_hej()
            {
                int antalVarv = 0;

                while (antalVarv < 1000)
                {
                    Console.Write(antalVarv + "Hej");

                    antalVarv = antalVarv + 1;
                }
                Console.WriteLine();

                Console.WriteLine("Slut på loopen.");

                Console.ReadLine();
            }

            void Från_1_till_100()
            {
                Console.WriteLine();
                for(int i = 1; i <= 100; i++)
                {
                    Console.Write(i + "\t");
                }
                Console.ReadLine();
            }

            void Bomben()
            {
                Console.WriteLine("\n");
                for(int i = 20; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                Thread.Sleep(3000);
                Console.WriteLine("... poff?");
                Console.ReadLine();
            }

            void Antal_gånger()
            {
                Console.WriteLine("\nAntal gånger?");
                int times = int.Parse(Console.ReadLine());

                for (int i = 0; i < times; i++)
                {
                    Console.Write((i+1) + "Hej  ");
                }
                Console.ReadLine();
            }

            void Upprepa_text(){
                Console.WriteLine("\n\nVilken text?");
                string text = Console.ReadLine();

                Console.WriteLine("\nHur många gånger?");
               int times = int.Parse(Console.ReadLine());

                for(int i = 1; i <= times; i++)
                {
                    Console.WriteLine(i + ". " + text);
                }
                Console.ReadLine();
            }
        }
    }
}
