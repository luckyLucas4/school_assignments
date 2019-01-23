using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long nuvarande = 1;
            long föregående = 0;
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine(nuvarande);
                nuvarande = nuvarande + föregående;
                föregående = nuvarande - föregående;
            }
            Console.ReadLine();
        }
    }
}
