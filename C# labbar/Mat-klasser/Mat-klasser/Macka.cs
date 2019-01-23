using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mat_klasser
{
    class Macka
    {
        Bröd skogaholm = new Bröd();
        Smör bregott = new Smör();
        Ost edamer;
        Skinka pärssons;

        public Macka(Ost o, Skinka sk)
        {
            edamer = o;
            pärssons = sk;
        }

        public Macka(Bröd b, Smör sm, Ost o,  Skinka sk)
        {
            skogaholm = b;
            bregott = sm;
            edamer = o;
            pärssons = sk;
        }

        public void Ät()
        {
            edamer.hålstorlek = 20;
            Console.WriteLine("Mackan var god, men osten hade för många hål");
            if(edamer.hålstorlek > 7)
            {
                Console.WriteLine("Hålen var äckliga");
            }
            else
            {
                Console.WriteLine("Lagom hål!");
            }
        }
    }
}
