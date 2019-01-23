using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_10___Loop_som_avbryts_med_break
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumpObjekt = new Random();
            int slumptal1;
            int slumptal2;
            int antalVarv = 0;
            while(true)
            {
                slumptal1 = slumpObjekt.Next(1, 101);
                slumptal2 = slumpObjekt.Next(1, 101);

                antalVarv = antalVarv + 1;
                Console.WriteLine("Varv: " + antalVarv + " Slumptalen är: " + slumptal1 + " och " + slumptal2);

                if (slumptal1 == slumptal2) break;
            }
            Console.WriteLine();
            Console.WriteLine("Slumptalen blev lika på varv " + antalVarv + ".");

            if(antalVarv < 20)
            {
                Console.WriteLine("Det gick fort!");
            }
            else if(antalVarv < 100)
            {
                Console.WriteLine("Det behövdes altså färre än 100 försök.");
            }
            else
            {
                Console.WriteLine("Det tog sin tid...");
            }
            Console.ReadLine();


            //Nytt program
            int antalRundor = 0;
            int slumptal3;
            while(true)
            {
                antalRundor++;
                if(antalRundor > 10000)break;

                slumptal3 = slumpObjekt.Next(1, 100);
                if(slumptal3 < 25)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if(slumptal3 < 50)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if(slumptal3 < 75)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if(slumptal3 < 100)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.Write("X");
            }
            Console.ReadLine();
        }
    }
}
