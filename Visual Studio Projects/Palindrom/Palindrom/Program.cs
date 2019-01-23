using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läser in palindromen
            Console.WriteLine("Skriv en palindrom!");
            string palindrom = Console.ReadLine();

            //Omvandlar till rätt läge
            palindrom = palindrom.ToLower();

            string shortened = palindrom.Replace(" ", "");

            //Till char för att vända
            char[] array = shortened.ToCharArray();

            Array.Reverse(array);

            string reverse = new string(array);

            //Kolla om det är en palindrom
            if(shortened == reverse)
            {
                Console.WriteLine(shortened + " är en palindrom!");
            }
            else
            {
                Console.WriteLine(shortened + " är inte en palindrom...");
            }


            Console.ReadLine();
        }
    }
}
