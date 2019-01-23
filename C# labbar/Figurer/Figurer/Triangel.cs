using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Figurer
{
    class Triangel : Figur
    {

        public Triangel(int dimX, int dimY)
        {
            if(dimX >= dimY){
                this.dimX = dimX;
                this.dimY = dimY;
            }
            else
            {
                this.dimX = dimY;
                this.dimY = dimX;
            }
        }

        public void Rita(bool sleep)
        {
            int length = dimX;
            for (int p = 0; p < dimY; p++)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                length -= Convert.ToInt32(dimX/dimY);
            }
            Console.WriteLine();
            if (sleep)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
