using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Figurer
{
    class Rhomb
    {
        private int r;

        public Rhomb(int radius)
        {
            r = radius;
        }

        public void Rita(bool sleep)
        {
            int spaces = r;
            for (int p = 0; p < r; p++)
            {
                for (int i = 0; i < r * 2; i++)
                {
                    if(i < spaces || i > r*2 - spaces)
                        Console.Write("  ");

                    else
                        Console.Write("**");
                }
                Console.WriteLine();
                spaces--;
            }
            for (int p = 0; p < r; p++)
            {
                for (int i = 0; i < r * 2; i++)
                {
                    if (i <= spaces || i >= r * 2 - spaces)
                        Console.Write("  ");

                    else
                        Console.Write("**");
                }
                Console.WriteLine();
                spaces++;
            }
            Console.WriteLine();
            if (sleep)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
