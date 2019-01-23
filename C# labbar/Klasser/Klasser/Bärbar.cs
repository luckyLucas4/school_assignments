using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Bärbar : Dator
    {
        private double vikt;

        public Bärbar(double vikt, int pris) : base(pris)
        {
            this.vikt = vikt;
        }

        public Bärbar(double vikt, int pris, string cpu, string gpu) : base(pris, cpu, gpu)
        {
            this.vikt = vikt;
        }

        public void VisaEgenskaper()
        {
            Console.WriteLine($"Datorn kostar {pris}, har {cpu} som cpu, {gpu} som gpu och väger {vikt}kg.");
        }
    }
}
