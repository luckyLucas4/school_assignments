using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_6
{
    class Tjänsteman : Anställd
    {
        public string position;
        public Tjänsteman(string namn, int ålder, int lön, string position) : base(namn, ålder, lön)
        {
            this.position = position;
        }
        public override void Lönesamtal()
        {
            Console.WriteLine("Lönesamtal för tjänsteman har ägt rum");
        }
    }
}
