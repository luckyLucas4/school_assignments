using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mat_klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Ost minOstskiva = new Ost(3, 78);
            Bröd minBrödskiva = new Bröd();
            Skinka minSkinka = new Skinka();
            Smör mittSmör = new Smör();

            fixaMackan(minBrödskiva, mittSmör, minOstskiva,  minSkinka );
        }

        static void fixaMackan(Ost ost, Skinka skinka)
        {
            Macka enkelmackan = new Macka(ost, skinka);
            enkelmackan.Ät();
        }

        static void fixaMackan( Bröd bröd, Smör smör, Ost ost, Skinka skinka)
        {
            Macka dubbelmackan = new Macka(bröd, smör, ost, skinka);
            dubbelmackan.Ät();
        }
        
    }
}
