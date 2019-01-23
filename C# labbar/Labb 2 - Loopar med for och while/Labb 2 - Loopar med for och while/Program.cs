using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labb_2___Loopar_med_for_och_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumpObjekt = new Random();
            int antalVarv = 0;
            while (true)
            {
                // Slumpar två tal tal från 1 till och med 100:
                int slumptal1 = slumpObjekt.Next(1, 101);
                int slumptal2 = slumpObjekt.Next(1, 101);
                antalVarv = antalVarv + 1;
                Console.WriteLine("Varv: " + antalVarv + " Slumptalen är: " + slumptal1 + " och " +
                slumptal2);
                if (slumptal1 == slumptal2)
                {
                    break; // Avbryter loopen
                }
            }
            Console.WriteLine();
            Console.WriteLine("Slumptalen blev lika på varv " + antalVarv + ".");
            if (antalVarv < 20)
            {
                Console.WriteLine("Det gick fort!!!");
            }
            else if (antalVarv < 100)
            {
                Console.WriteLine("Det behövdes alltså färre än 100 försök.");
            }
            else
            {
                Console.WriteLine("Det tog sin tid...");
            }

            Thread.Sleep(3000);

            int random1, random2, random3;

            antalVarv = 0;

            while (true)
            {
                antalVarv++;

                random1 = slumpObjekt.Next(1, 101);
                random2 = slumpObjekt.Next(1, 101);
                random3 = slumpObjekt.Next(1, 101);

                Console.WriteLine("Varv: {0}, talen är {1}, {2}, {3}", antalVarv, random1, random2, random3);

                if(random1 == random2 && random1 == random3)
                {
                    break;
                }
            }

            Thread.Sleep(3000);

            Console.WriteLine("\n\n");

            antalVarv = 0;

            while (true)
            {
                antalVarv++;

                random1 = slumpObjekt.Next(1, 101);
                random2 = slumpObjekt.Next(1, 101);
                random3 = slumpObjekt.Next(1, 101);

                Console.WriteLine("Varv: {0}, talen är {1}, {2}, {3}", antalVarv, random1, random2, random3);

                if(random1 == random2 || random1 == random3 || random2 == random3)
                {
                    break;
                }
            }


            Thread.Sleep(3000);

            for (int i = 0; i < 10000; i++)
            {
                int slumpatTal = slumpObjekt.Next(1, 100);

                if(slumpatTal < 25)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if(slumpatTal < 50)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (slumpatTal < 75)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(slumpatTal + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();
        }
    }
}
