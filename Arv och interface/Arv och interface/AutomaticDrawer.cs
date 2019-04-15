using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_och_interface
{
    class AutomaticDrawer : ILock // AutomaticDrawer implementerar ILock, det visar att lådan kan låsas
    {
        public bool locked { get; set; } = true; // Låset är från början låst
        public bool opened = false; // Lådan är från början stängd

        public bool Lock()  // Låser lådan (lådan stängs automatiskt)
        {
            locked = true;  // Låser lådan
            opened = false; // Lådan stängs
            return true;    // Visar att handlingen var lyckad
        }

        public bool Unlock() // Låser upp lådan (lådan öppnas automatiskt)
        {
            locked = false; // Låser upp lådan
            opened = true;  // Lådan öppnas
            return true;    // Visar att handlingen var lyckad
        }
    }
}
