using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Banan : Frukt
    {
        private int böj = 4;

        public Banan(int böj, string smak, string färg):base(smak,färg) // Konstruktor -Har samma namn som klassen -Har ingen returtyp -Körs när objektet skapas
        {
            this.böj = böj;
        }

        public void VisaEgenskaper()
        {
            Console.WriteLine("Den gule bananens böjning är {0}, smaken är {1} och färgen är {2}", böj, smak, färg);
        }
    }
}
