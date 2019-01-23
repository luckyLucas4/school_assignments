using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Inmatning_sen_omvandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad är din temperatur? (Användkomma för att ange decimaltal t.ex 37.14)  ");
            string indata = Console.ReadLine();
            double temperatur = Convert.ToDouble(indata);

            if (temperatur > 36.5)
            {
                Console.WriteLine("Vila i sängen hela dagen!");
            }
            else if (temperatur < 36.5)
            {
                Console.WriteLine("Cool typ! Drick en kopp varm choklad...");
            }
            else
            {
                Console.WriteLine("Helt normalt! Du är ju helt frisk...");
            }
            
            Console.ReadLine();


            //Nytt program
            Console.WriteLine("Skriv två decimaltal ");
           
            Console.Write("Tal A: ");
            string inmatning1 = Console.ReadLine();
            double talA = Convert.ToDouble(inmatning1);

            Console.Write("Tal B: ");
            string inmatning2 = Console.ReadLine();
            double talB = Convert.ToDouble(inmatning2);

            double summa = talA + talB;
            Console.WriteLine("Summan av talen är: " + summa);

            Console.ReadLine();


            //Nytt program
            Console.WriteLine("Skriv ett decimaltal med mer än 2 decimaler");
            string input = Console.ReadLine();
            double decima = Convert.ToDouble(input);

            double avrundatTal = Math.Round(decima, 2);
            Console.WriteLine(avrundatTal);

            Console.ReadLine();
        }
    }
}
