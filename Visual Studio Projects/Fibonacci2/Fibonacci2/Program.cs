using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    class Program
    {
        static void Main(string[] args)
        {
            long föregående = 0;
            long nuvarande = 1;
            List<long> lista = new List<long>();
            for(int i = 0; i < 40; i++)
            {
                nuvarande = nuvarande + föregående;
                föregående = nuvarande - föregående;

                long rest = nuvarande % 2;
                if(rest == 0)
                {
                    lista.Add(nuvarande);
                }
            }
            Console.WriteLine("Summan av jämna Fibonacci tal under 40 är " + lista.Sum() );
            Console.ReadLine();
        }
    }
}
