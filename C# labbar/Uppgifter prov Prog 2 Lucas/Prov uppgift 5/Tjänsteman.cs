using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_5
{
    class Tjänsteman : Anställd
    {
        public string position;
        public Tjänsteman(string namn, int ålder, int lön, string position) : base(namn, ålder, lön)
        {
            this.position = position;
        }
    }
}
