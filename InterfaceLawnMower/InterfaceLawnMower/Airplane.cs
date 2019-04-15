using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLawnMower
{
    public class Airplane : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Airplane started");
            return true;
        }

        public bool Stop()
        {
            throw new NotImplementedException();
        }
    }
}
