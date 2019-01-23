using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Banan denGule = new Banan(4, "söt", "gul");
            //Banan denPrickige = new Banan(3, "söt", "brungul");

            //Apelsin denStore = new Apelsin(7, "sötsur", "orange");
            //Apelsin denKlyftige = new Apelsin(12, "sötsur", "ljusorange");


            //denGule.VisaEgenskaper();
            //denPrickige.VisaEgenskaper();

            //denStore.VisaEgenskaper();
            //denKlyftige.VisaEgenskaper();

            Stationär gamingRig = new Stationär("ASUS", 19500, "Intel i9", "NVIDIA 1080Ti");

            Bärbar spelDator = new Bärbar(1.5, 5000, "Intel i5", "AMD Integrated");
            Bärbar skolDator = new Bärbar(1.2, 3000);

            gamingRig.VisaEgenskaper();
            spelDator.VisaEgenskaper();
            skolDator.VisaEgenskaper();

            Console.ReadLine();
        }
    }
}
