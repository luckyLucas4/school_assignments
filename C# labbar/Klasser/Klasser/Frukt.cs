using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Frukt
    {
        protected string smak;
        protected string färg;

        public Frukt(string smak, string färg)
        {
            this.smak = smak;
            this.färg = färg;
        }
    }
}
