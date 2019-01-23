using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_satsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett tal: ");
            int svar;
            while(int.TryParse(Console.ReadLine(), out svar) == false){
                Console.WriteLine("\nFelaktig inmatning!\n");
            }

            switch (svar)
            {
                case 1: Console.Write("Ett"); break;
                case 2: Console.Write("Två"); break;
                case 3: Console.Write("Tre"); break;
                default: Console.Write("Ogiltigt alternativ!"); break;
            }

            Console.WriteLine("\n\nSkriv in ett väderstreck");
            System.ConsoleKeyInfo knappTryck = Console.ReadKey();
            char nyttSvar = knappTryck.KeyChar;

            Console.WriteLine(nyttSvar);

            switch (nyttSvar)
            {
                case 'n': Console.WriteLine("\nYou walk north!"); break;
                case 'e': Console.WriteLine("\nYou walk east!"); break;
                case 's': Console.WriteLine("\nYou walk south!"); break;
                case 'w': Console.WriteLine("\nYou walk west!"); break;
                default: Console.WriteLine("\nYou're not walking anywhere!"); break;
            }

            Console.ReadLine();
        }
    }
}
