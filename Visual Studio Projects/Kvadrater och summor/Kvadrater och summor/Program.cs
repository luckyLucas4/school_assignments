using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadrater_och_summor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            for(int i = 1; i <= 100; i++)
            {
                int kvadrat = i * i;
                Console.Write(kvadrat + "  ");
                lista.Add(kvadrat);
            }
            Console.WriteLine("Summa: " + lista.Sum());
            Console.ReadLine();

            List<int> lista2 = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                lista2.Add(i);
            }
            Console.WriteLine("Summan av de första 100 talen är: " + lista2.Sum());
            int summaAvKvadrat = lista2.Sum() * lista2.Sum();

            Console.WriteLine("Kvadraten av summan är {0} !",summaAvKvadrat);
            Console.WriteLine("Skillnaden äe {0} .", summaAvKvadrat - lista.Sum());
            Console.ReadLine();
        }
    }
}
