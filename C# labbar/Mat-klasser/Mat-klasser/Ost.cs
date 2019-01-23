using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mat_klasser
{
    class Ost : Smörgåsmat
    {
        private int lagringstid; 
        public int hålstorlek { get; }

        public Ost(int l, int h)
        {
            lagringstid = l;
            hålstorlek = h;
        }
    }
}
