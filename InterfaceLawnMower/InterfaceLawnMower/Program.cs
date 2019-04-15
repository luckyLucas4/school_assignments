using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLawnMower
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var mower = new LawnMower();
            var air = new Airplane();

            Start(car);
            Start(mower);
            Start(air);

            Console.Read();
        }

        static void Start(IMachine m)
        {
            m.Start();
        }
    }
}
