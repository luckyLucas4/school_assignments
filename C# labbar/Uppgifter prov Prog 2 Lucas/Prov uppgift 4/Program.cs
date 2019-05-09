using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbetare arb1 = new Arbetare("Stig", 35, 30000);

            arb1.VisaInfo();

            Console.Read();
        }
    }
}
