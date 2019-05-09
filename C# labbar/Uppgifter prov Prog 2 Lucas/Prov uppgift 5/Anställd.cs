using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_5
{
    class Anställd : Resurs
    {
        protected int ålder, lön;
        public Anställd(string namn, int ålder, int lön): base(namn)
        {
            this.ålder = ålder;
            this.lön = lön;
        }
        public override void VisaInfo()
        {
            base.VisaInfo();
            Console.WriteLine($"{namn} är {ålder} år gammal och har {lön} i lön");
        }
    }
}
