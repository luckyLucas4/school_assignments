using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Figurer
{
    class Program
    { 
        static void Main(string[] args)
        {
            Rektangel rekt1 = new Rektangel(12, 6);
            Rektangel rekt2 = new Rektangel(2, 4);
            Rektangel rekt3 = new Rektangel(48, 9);

            rekt1.Rita(true);
            rekt2.Rita(true);
            rekt3.Rita(true);

            Triangel tri1 = new Triangel(20, 10);
            Triangel tri2 = new Triangel(30, 10);
            Triangel tri3 = new Triangel(5, 8);
            Triangel tri4 = new Triangel(25, 10);

            tri1.Rita(true);
            tri2.Rita(true);
            tri3.Rita(true);
            tri4.Rita(true);

            Rhomb romb1 = new Rhomb(10);

            romb1.Rita(true);

            Console.ReadLine();
        }
    }
}
