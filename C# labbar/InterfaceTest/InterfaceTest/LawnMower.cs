using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class LawnMower : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Började klippa");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Slutade klippa");
            return true;
        }
    }
}
