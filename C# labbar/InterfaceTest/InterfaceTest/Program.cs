using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var mower = new LawnMower();
            var car = new Car();

            mower.Start();
            car.Start();
            mower.Stop();
            mower.Start();
            car.Stop();

            Console.ReadLine();
        }
    }
}
