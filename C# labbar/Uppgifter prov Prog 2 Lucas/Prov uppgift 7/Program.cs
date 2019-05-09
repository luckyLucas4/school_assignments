using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbetare arb1 = new Arbetare("Göran", 40, 25000, false);
            Robot rob1 = new Robot("Mutte", "Monterare", "7B65");
            Tjänsteman tj1 = new Tjänsteman("Klas", 50, 50000, "VD");

            List<Resurs> resurser = new List<Resurs>();
            resurser.Add(arb1);
            resurser.Add(rob1);
            resurser.Add(tj1);

            List<ILöneutbetalning> löner = new List<ILöneutbetalning>();
            löner.Add(arb1);
            löner.Add(tj1);

            foreach(Resurs resurs in resurser)
            {
                resurs.VisaInfo();
            }

            foreach(ILöneutbetalning lön in löner)
            {
                lön.Lönesamtal();
            }
            Console.WriteLine();

            resurser.Add(new Arbetare("Hasse", 27, 50000, true));
            resurser.Add(new Arbetare("Gunnar", 45, 32000, false));
            List<Arbetare> arbetare = new List<Arbetare>();
            foreach(Resurs resurs in resurser)
            {
                if(resurs is Arbetare a)
                {
                    arbetare.Add(a);
                    Console.WriteLine($"La till {a.namn} i listan över arbetare");
                }
            }

            Arbetarregister reg1 = new Arbetarregister(arbetare);
            Console.WriteLine("\nTryck 1 för att visa arbetare, 2 för att ta bort arbetare," +
                    " 3 för att sortera efter lön, 4 för att sortera efter ålder och 5 för att avsluta");
            bool menuActive = true;
            while(menuActive == true)
            {
                
                bool input = true;

                while(input == true)
                {
                    input = false;
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.D1:
                            reg1.visaArbetare();
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine("\nSkriv in namnet på någon av dessa arbetare, " +
                                "skriv 1 innan namnet för att göra skillnad på stora och små bokstäver\n\n");

                            foreach(Arbetare a in reg1.arbetare)
                            {
                                Console.Write(a.namn + " ");
                            }
                            Console.WriteLine();

                            string inmatning = Console.ReadLine();
                            inmatning = inmatning.Replace(" ","");

                            bool caseSensitive = false;
                            if (inmatning[0] == '1')
                            {
                                caseSensitive = false;
                                inmatning.Remove(0, 1);
                            }

                            if(reg1.taBortArbetare(inmatning, caseSensitive) == false)
                            {
                                Console.WriteLine("Ingen arbetare med det namnet hittad");
                            }
                            break;

                        case ConsoleKey.D3:
                            reg1.sorteraEfterLön();
                            break;

                        case ConsoleKey.D4:
                            reg1.sorteraEfterÅlder();
                            break;

                        case ConsoleKey.D5:
                            menuActive = false;
                            break;

                        default:
                            Console.WriteLine("Felaktig inmatning, försök igen");
                            input = true;
                            break;
                    }
                }
            }
            reg1.visaArbetare();
            reg1.sorteraEfterLön();
            reg1.visaArbetare();
            reg1.sorteraEfterÅlder();
            reg1.visaArbetare();

            Console.Read();
        }
    }
}
