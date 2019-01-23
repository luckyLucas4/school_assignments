using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Hej_Världen_med_färger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Hej Världen");
            }
            Console.ReadLine();
        }
    }
}
