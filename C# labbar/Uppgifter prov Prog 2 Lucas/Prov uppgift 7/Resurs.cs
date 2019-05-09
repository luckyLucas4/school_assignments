using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_7
{
    class Resurs
    {
        public string namn { get; }

        public Resurs(string namn)
        {
            this.namn = namn;
        }
        public virtual void VisaInfo()
        {
            Console.WriteLine($"Resursens namn är {namn}");
        }
    }
}
