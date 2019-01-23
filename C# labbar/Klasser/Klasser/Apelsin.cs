using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Apelsin : Frukt 
    {
        private int klyftor;

        public Apelsin(int klyftor, string smak, string färg):base(smak, färg)
        {
            this.klyftor = klyftor;
        }

        public void VisaEgenskaper()
        {
            Console.WriteLine("Den store apelsinen har {0} klyftor, smakar {1} och har en {2} färg", klyftor, smak, färg);
        }
    }
}
