using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Slumptal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomobjekt = new Random();
            int slumpTal = randomobjekt.Next(1, 11);

            Console.Write("Gissa på ett tal mellan 1 och 11 ");
            string indata = Console.ReadLine();
            int gissatTal = Convert.ToInt32(indata);

            if(gissatTal == slumpTal)
            {
                Console.WriteLine("Rätt gissat!");
            }
            else
            {
                Console.WriteLine("Fel! Rätt tal är: " + slumpTal);
            }
            Console.ReadLine();


            //Nytt program
            int slumpTal1 = randomobjekt.Next(1, 101);
            int slumpTal2 = randomobjekt.Next(1, 101);
            int slumpTal3 = randomobjekt.Next(1, 101);
            int slumpTal4 = randomobjekt.Next(1, 101);
            int slumpTal5 = randomobjekt.Next(1, 101);
            
            List<int> lista = new List<int>();
            lista.AddRange(new int[] {slumpTal1, slumpTal2, slumpTal3, slumpTal4, slumpTal5});
            
            foreach(int tal in lista)
            {
                Console.WriteLine("Tal: {0}", tal);
            }
            Console.ReadLine();


            //Nytt program
            int slumpatTal1 = randomobjekt.Next(1, 7);
            int slumpatTal2 = randomobjekt.Next(1, 7);

            if(slumpatTal1 == slumpatTal2)
            {
                Console.WriteLine("Ett par i " + slumpatTal1);
            }
            else
            {
                Console.WriteLine("Talen är " + slumpatTal1 + " och " + slumpatTal2);
            }
            Console.ReadLine();
        }
    }
}
