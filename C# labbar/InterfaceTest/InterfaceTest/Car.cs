using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class Car : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Startede");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Stannade");
            return true;
        }
    }
}
