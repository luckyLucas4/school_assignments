using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_och_interface
{
    interface ILock // Ett interface för saker som kan låsas
    {
        bool locked { get; set; } // Är låset låst?

        bool Lock(); // Funktion för att låsa

        bool Unlock(); // Funktion för att låsa upp
    }
}
