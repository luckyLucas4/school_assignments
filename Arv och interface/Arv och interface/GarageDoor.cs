using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_och_interface
{
    class GarageDoor : Door // Garageporten ärver från basklassen Door
    {
        public int height { get; } // En variabel för höjden, kan bara hämtas

        public GarageDoor(bool opened, int height) : base(opened) // Konstruktorn skickar ett värde för "opened" till basklassens konstruktor
        {
            this.height = height; // Sätter ett värde på dörrens höjden
        }

        public override bool Open() // En funktion för att öppna dörren, skriver över hur funktionen är definierad i basklassen
        {
            if (base.Open() == true)
            {
                Console.WriteLine("rrrrRRRR"); // Skriver till konsolen
                return true; // Visar att handlingen var lyckad
            }
            else
            {
                Console.WriteLine("A garage door was unable to open"); // Skriver till konsolen
                return false; // Visar att handlingen var misslyckad
            }
        }

        public override bool Close() // En funktion för att stänga dörren, skriver över hur funktionen är definierad i basklassen
        {
            if (base.Close() == true)
            {
                Console.WriteLine("RRRRrrrr"); // Skriver till konsolen
                return true; // Visar att handlingen var lyckad
            }
            else
            {
                Console.WriteLine("A garage door was unable to close"); // Skriver till konsolen
                return false; // Visar att handlingen var misslyckad
            }
        }
    }
}
