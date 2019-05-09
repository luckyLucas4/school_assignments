using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_7
{
    class Arbetarregister
    {
        public List<Arbetare> arbetare;

        public Arbetarregister(List<Arbetare> arbetare)
        {
            this.arbetare = arbetare;
        }

        public void visaArbetare()
        {
            Console.WriteLine("\nInfo om arbetare i registret:");
            foreach(Arbetare arbetare in arbetare)
            {
                arbetare.VisaInfo();
            }
        }

        public bool taBortArbetare(string namn)
        {
            return taBortArbetare(namn, false);
        }

        public bool taBortArbetare(string namn, bool caseSensitive)
        {
            
            bool arbetareHittad = false;
            foreach(Arbetare a in arbetare)
            {
                if (a.namn.ToLower() == namn.ToLower())
                {
                    if(a.namn != namn && caseSensitive == true)
                    {
                        continue;
                    }
                    arbetare.Remove(a);
                    arbetareHittad = true;
                    break;
                }
            }
            return arbetareHittad;
        }

        public void sorteraEfterLön()
        {
            List<Arbetare> temp1 = new List<Arbetare>(arbetare);
            List<Arbetare> temp2 = new List<Arbetare>();

            while(temp1.Count > 0)
            {
                Arbetare lägst = temp1[0];
                foreach(Arbetare a in temp1)
                {
                    if (a.lön <= lägst.lön)
                    {
                        lägst = a;
                    }
                }
                temp2.Add(lägst);
                temp1.Remove(lägst);
            }
            arbetare = temp2;
        }

        public void sorteraEfterÅlder()
        {
            List<Arbetare> temp1 = new List<Arbetare>(arbetare);
            List<Arbetare> temp2 = new List<Arbetare>();

            while (temp1.Count > 0)
            {
                Arbetare lägst = temp1[0];
                foreach (Arbetare a in temp1)
                {
                    if (a.ålder <= lägst.ålder)
                    {
                        lägst = a;
                    }
                }
                temp2.Add(lägst);
                temp1.Remove(lägst);
            }
            arbetare = temp2;
        }
    }
}
