using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelbaraTal1_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            // your code goes here
            List<int> lista = new List<int>();
            int rest3;
            int rest5;
            for (int i = 1000; i > 0; i--)
            {
                rest3 = i % 3;
                rest5 = i % 5;
                if (rest3 == 0)
                {
                    lista.Add(i);
                }

                else if (rest5 == 0)
                {
                    lista.Add(i);
                }
            }
            Console.WriteLine("Summan av tal jämnt delbara med 3 och 5 mellan 1 och 1000 är: " + lista.Sum());
            Console.WriteLine("Talen är:");

            foreach (int element in lista)
            {
                Console.Write(element + " ");
            }
            Console.ReadLine();

        }
    }
}
