using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_7
{
    class Robot : Resurs
    {
        private string typ, modell;

        public Robot(string namn, string typ, string modell) : base(namn)
        {
            this.typ = typ;
            this.modell = modell;
        }

        public override void VisaInfo()
        {
            base.VisaInfo();
            Console.WriteLine($"Roboten {namn} av modell {modell} är av typ {typ}");
        }
    }
}
