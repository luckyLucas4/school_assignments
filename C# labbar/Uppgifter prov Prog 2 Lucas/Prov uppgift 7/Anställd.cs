using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_7
{
    class Anställd : Resurs, ILöneutbetalning
    {
        public int ålder, lön;
        public Anställd(string namn, int ålder, int lön): base(namn)
        {
            this.ålder = ålder;
            this.lön = lön;
        }

        public virtual void Lönesamtal()
        {
            Console.WriteLine("Lönesamtal för anställd har ägt rum");
        }

        public override void VisaInfo()
        {
            base.VisaInfo();
            Console.WriteLine($"{namn} är {ålder} år gammal och har {lön} i lön");
        }
    }
}
