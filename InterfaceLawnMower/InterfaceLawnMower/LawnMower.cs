using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLawnMower
{
    public class LawnMower : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Lawn mower started");
            return true;
            
        }

        public bool Stop()
        {
            throw new NotImplementedException();
        }
    }
}
