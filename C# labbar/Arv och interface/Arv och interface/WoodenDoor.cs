using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arv_och_interface
{
    class WoodenDoor : Door // Trädörren ärver från basklassen Door
    {
        public string woodType { get; } // Dörrens träslag kan bara hämtas

        public WoodenDoor(bool opened, string woodType) : base(opened) // Konstruktorn skickar ett värde för "opened" till basklassens konstruktor
        {
            this.woodType = woodType; // Bestämmer dörrens träslag
        }

        public override bool Open() // En funktion för att öppna dörren, skriver över hur funktionen är definierad i basklassen
        {
            if (base.Open() == true) // Använder basklassens definition av Open för att öppna dörren, en boolean returneras som visar om handlingen var lyckad
            {
                Console.WriteLine("eeeeEEEE"); // Skriver till konsolen
                return true; // Visar att handlingen var lyckad
            }
            else
            {
                Console.WriteLine("A wooden door was unable to open"); // Skriver till konsolen
                return false; // Visar att handlingen var misslyckad
            }
        }

        public override bool Close() // En funktion för att stänga dörren, skriver över hur funktionen är definierad i basklassen
        {
            if (base.Close() == true) // Använder basklassens definition av Close för att stänga dörren, en boolean returneras som visar om handlingen var lyckad
            {
                Console.WriteLine("EEEEeeee"); // Skriver till konsolen
                return true; // Visar att handlingen var lyckad
            }
            else
            {
                Console.WriteLine("A wooden door was unable to close"); // Skriver till konsolen
                return false; // Visar att handlingen var misslyckad
            }
        }
    }
}
