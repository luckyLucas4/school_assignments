using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Dator
    {
        protected int pris;
        protected string cpu = "Intel i5";
        protected string gpu = "NVIDIA 760";

        public Dator(int pris)
        {
            this.pris = pris;
        }

        public Dator(int pris, string cpu, string gpu)
        {
            this.pris = pris;
            this.cpu = cpu;
            this.gpu = gpu;
        }
    }
}
