using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labb_3___Tillämpningsövningar
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1: Berätta och berätta igen \n2: Tennisbollen \n3: Snigeln i brunnen \n4: Mini nim \n5: Gissa talet");
                Console.Write("\nVälj program: ");
                ConsoleKeyInfo knappTryck = Console.ReadKey();
                switch (knappTryck.KeyChar)
                {
                    case '1':
                        BerattaIgen();
                        break;

                    case '2':
                        Tennisbollen();
                        break;

                    case '3':
                        Snigeln();
                        break;

                    case '4':
                        MiniNim();
                        break;

                    case '5':
                        GissaTalet();
                        break;

                    default:
                        Console.WriteLine("\nFelaktig inmatning\n");
                        break;
                }
            }

            void BerattaIgen()
            {
                while (true)
                {
                    Console.WriteLine("Berätta och Berätta igen var ute och gick, så blev Berätta överkörd av en bilen, vem var kvar?");

                    if (Console.ReadLine() != "Berätta igen")
                    {
                        Console.WriteLine("\nFel svar!");
                        break;
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            void Tennisbollen()
            {
                double actualHeight;

                Console.WriteLine("\n\nSkriv in en höjd i meter: ");

                while(double.TryParse(Console.ReadLine(), out actualHeight) == false)
                {
                    Console.WriteLine("Felaktig inmatning, försök igen: ");
                }

                int antalStuds = 1;
                double displayHeight = actualHeight;
                string[] units = { "m", "dm", "cm", "mm"};
                int currentUnit = 0;

                while(actualHeight > 0.001)
                {
                    antalStuds++;
                    actualHeight *= 0.555;
                    displayHeight *= 0.555;

                    if(displayHeight < 1 && currentUnit < units.Length - 1)
                    {
                        displayHeight *= 10;
                        currentUnit++;
                    }

                    Console.WriteLine("{0:F2} {1}", displayHeight, units[currentUnit]);
                    Thread.Sleep(1000);
                }

                Console.WriteLine("\nBollen stannade efter {0} studs", antalStuds);

                Console.ReadLine();
            }

            void Snigeln()
            {
                int djup = 8;
                int timmar = 5;
                int minuter = 0;

                Console.WriteLine("\nSnigeln har ramlat ner i en {0} meter djup brunn 5:00 på morgonen\n", djup);

                while (djup >= 0)
                {
                    Console.WriteLine("{0:00}:{1:00}\t {2} meter från kanten", timmar, minuter, djup);

                    timmar += 1;
                    djup -= 2;

                    if(djup <= 0)
                    {
                        break;
                    }

                    Console.WriteLine("{0:00}:{1:00}\t {2} meter från kanten", timmar, minuter, djup);

                    minuter += 30;
                    djup += 1;

                    if(minuter >= 60)
                    {
                        timmar++;
                        minuter -= 60;
                    }

                }

                    Console.WriteLine("\n{0:00}:{1:00} var han uppe vid kanten, då hade {2} timmar gått", timmar, minuter, (timmar - 5));

                Console.ReadLine();
            }

            void MiniNim()
            {
                Random slumptal = new Random();

                int antalKulor = slumptal.Next(10, 21);

                Console.WriteLine("\n\nAntal kulor:{0} \nTa en eller två kulor", antalKulor);

                bool spelare1 = true;

                while(antalKulor > 0)
                {
                    Console.Write("\n{0}: ", (spelare1 ? "Spelare 1" : "Spelare 2"));
                    int kulorBort;
                    while(int.TryParse(Console.ReadLine() , out kulorBort) == false)
                    {

                        Console.WriteLine("Felaktig inmatning! Försök igen: ");                        
                    }

                    while (true)
                    {
                        if(antalKulor > 1)
                        {
                            if (kulorBort == 1 || kulorBort == 2)
                            {
                                antalKulor -= kulorBort;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Felaktig inmatning! Försök igen: ");
                            }
                        }
                        else
                        {
                            if(kulorBort == 1)
                            {
                                antalKulor -= kulorBort;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Felaktig inmatning! Försök igen: ");
                            }
                        }
                    }


                    //antalKulor -= slumptal.Next(1, 3);
                    Console.WriteLine("{0} {1} kvar", antalKulor, (antalKulor == 1 ? "kula" : "kulor"));
                    spelare1 = !spelare1;

                }

                Console.WriteLine("\nSpelare {0} vann!", (spelare1 ? "2" : "1"));

                Console.ReadLine();
            }

            void GissaTalet()
            {
                Random slumpObjekt = new Random();

                int slumpTal = slumpObjekt.Next(1, 101);
                int gissning;
                int antalGissningar = 0;

                Console.WriteLine("\n\nVilket tal tänker jag på?");

                while (true)
                {
                    Console.Write("    ");
                    string nyGissning = Console.ReadLine();

                    while(int.TryParse(nyGissning, out gissning) == false)
                    {
                        Console.WriteLine("Skriv in ett heltal!\t");
                        Console.Write("    ");
                        nyGissning = Console.ReadLine();
                    }

                    antalGissningar++;

                    if(gissning == slumpTal)
                    {
                        Console.WriteLine("Rätt svar! Bara {0} gissningar!", antalGissningar);
                        break;
                    }
                    else if(gissning > slumpTal)
                    {
                        Console.WriteLine("Mitt tal är lägre, försök igen!");
                    }
                    else
                    {
                        Console.WriteLine("Mitt tal är högre, försök igen!");
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
