using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Stationär : Dator
    {
        private string skärm;

        public Stationär(string skärm, int pris, string cpu, string gpu) : base(pris, cpu, gpu)
        {
            this.skärm = skärm;
        }

        public void VisaEgenskaper()
        {
            Console.WriteLine($"Datorn kostar {pris}, har {cpu} som cpu, {gpu} som gpu och har en {skärm} skärm.");
        }
    }
}
