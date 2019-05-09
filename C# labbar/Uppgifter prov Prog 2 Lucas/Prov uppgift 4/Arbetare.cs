using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_4
{
    class Arbetare
    {
        private string namn;
        private int ålder, lön;

        public Arbetare(string namn, int ålder, int lön)
        {
            this.namn = namn;
            this.ålder = ålder;
            this.lön = lön;
        }

        public void VisaInfo()
        {
            Console.WriteLine($"{namn} är {ålder} år gammal och har {lön} i lön");
        }
    }
}
