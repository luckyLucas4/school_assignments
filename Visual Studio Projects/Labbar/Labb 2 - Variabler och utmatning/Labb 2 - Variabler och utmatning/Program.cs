using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Variabler_och_utmatning
{
    class Program
    {
        static void Main(string[] args)
        {
            string minText = "Hej på dej!";
            int mittTal = 21;

            Console.WriteLine(minText);
            minText = "Hej igen!";
            Console.WriteLine("Variablen minText innehåller nu: " + minText);

            Console.WriteLine(mittTal);
            mittTal = mittTal + 1;
            Console.WriteLine("Variabeln mittTal innehåller nu: " + mittTal);

            
           
            
            Console.WriteLine("Lucas Granberg");
            Console.WriteLine("14 år");

            
            
            string mittNamn = "Lucas Granberg";
            int minÅlder = 14;
            
            Console.WriteLine(mittNamn);
            Console.WriteLine(minÅlder);


            int tal1 = 5;
            int tal2 = 8;
            int summa = tal1 + tal2;

            Console.WriteLine("Variabeln tal1 har värdet: " + tal1);

            Console.ReadLine();
        }
    }
}
