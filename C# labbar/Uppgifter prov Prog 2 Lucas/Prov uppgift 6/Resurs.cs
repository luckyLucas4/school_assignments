using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_6
{
    class Resurs
    {
        protected string namn;

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
