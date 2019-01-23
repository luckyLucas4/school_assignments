using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Figurer
{
    class Rektangel : Figur
    {

        public Rektangel(int dimX, int dimY)
        {
            this.dimX = dimX;
            this.dimY = dimY;
        }

        public void Rita(bool sleep)
        {
            for (int p = 0; p < dimY; p++)
            {
                for (int i = 0; i < dimX; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if (sleep)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
