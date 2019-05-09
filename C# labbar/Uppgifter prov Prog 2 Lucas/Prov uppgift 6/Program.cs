using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_uppgift_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbetare arb1 = new Arbetare("Göran", 40, 25000, false);
            Robot rob1 = new Robot("Mutte", "Monterare", "7B65");
            Tjänsteman tj1 = new Tjänsteman("Klas", 50, 50000, "VD");

            List<Resurs> resurser = new List<Resurs>();
            resurser.Add(arb1);
            resurser.Add(rob1);
            resurser.Add(tj1);

            List<ILöneutbetalning> löner = new List<ILöneutbetalning>();
            löner.Add(arb1);
            löner.Add(tj1);

            foreach(Resurs resurs in resurser)
            {
                resurs.VisaInfo();
            }

            foreach(ILöneutbetalning lön in löner)
            {
                lön.Lönesamtal();
            }

            Console.Read();
        }
    }
}
