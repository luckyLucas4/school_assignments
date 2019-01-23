using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Inmatning_av_text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv något kul: ");
            string returvärde = Console.ReadLine();
            Console.WriteLine("Ha-ha-ha! " + returvärde);
            Console.ReadLine();

            //Nytt program
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("Hej " + namn);
            Console.ReadLine();
            
        }
    }
}
