using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_och_interface
{
    class Door : ILock // Klassen Door implementerar ILock, det visar att dörren kan låsas
    {
        public bool locked { get; set; } // Är låset upplåst?
        public bool opened { get; set; } // Är dörren öppen?

        public Door(bool opened) // Konstruktorn sätter värdet på "opened"
        {
            this.opened = opened; 
        }

        public bool Lock()  // En funktion för att låsa dörren
        {
            locked = true;  // Låser låset
            return true;    // Visar att handlingen var lyckad
        }

        public bool Unlock() // En funktion för att låsa upp dörren
        {
            locked = false; // Låser upp låset
            return true;    // Visar att handlingen var lyckad
        }

        public virtual bool Open() // En funktion för att öppna dörren
        {
            if (locked == false && opened == false) // Om dörren är upplåst och inte redan öppnad
            {
                opened = true;  // Öppnar dörren
                return true;    // Visar att handlingen var lyckad
            }
            else
                return false;   // Visar att handlingen var misslyckad
        }

        public virtual bool Close() // En funktion för att stänga dörren
        {
            if (locked == false && opened == true) // Om dörren är upplåst och inte redan stängd
            {
                opened = false; // Stänger dörren
                return true;    // Visar att handlingen var lyckad
            }
            else
                return false;   // Visar att handlingen var misslyckad
        }
    }
}
