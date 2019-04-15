using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_och_interface
{
    class Program
    {
        static void Main(string[] args) // Funktionen utför automatiskt ett antal operationer på skapade dörrar
        {
            WoodenDoor wood = new WoodenDoor(true, "Oak");  // En öppnad trädörr av ek
            GarageDoor garage = new GarageDoor(false, 3);   // En 3 meter hög stängd garageport 
            AutomaticDrawer drawer = new AutomaticDrawer(); // En ny låda som automatiskt är låst

            List<ILock> lockable = new List<ILock>(); // En lista av saker som implementerar ILock och därför kan låsas
            lockable.Add(wood);     // Trädörren läggs till i listan
            lockable.Add(garage);   // Garageporten läggs till i listan
            lockable.Add(drawer);   // Lådan läggs till i listan

            List<Door> doors = new List<Door>(); // En lista av dörrar (objekt som ärver av Door)
            doors.Add(wood);    // Trädörren läggs till i listan
            doors.Add(garage);  // Garageporten läggs till i listan

            void CheckDrawer() // En funktion som kollar lådans status
            {
                // Skriver till konsolen, kollar värder på "opened" skriver därefter "opened" om lådan är öppen och "closed" om lådan är stängd
                Console.WriteLine($"The automatic drawer is {(drawer.opened ? "opened" : "closed")}"); 
            }

            void OpenDoors() // En funktion som öppnar alla dörrar i doors
            {
                Console.WriteLine("Opening all doors..."); // Skriver till konsolen
                foreach (Door d in doors) // Går igenom alla dörrar i "doors"
                    d.Open(); // Öppnar dörren
            }

            void CloseDoors() // En funktion som stänger alla dörrar
            {
                Console.WriteLine("Closing all doors..."); // Skriver till konsolen
                foreach (Door d in doors) // Går igenom alla dörrar i "doors"
                    d.Close(); // Stänger dörren
            }

            void LockAll() // En funktion som låser alla lås
            {
                Console.WriteLine("Locking all locks..."); // Skriver till konsolen
                foreach (ILock l in lockable) // Går igenom alla lås
                    l.Lock(); // Låser låset
            }

            void UnlockAll() // En funktion låser upp alla lås
            {
                Console.WriteLine("Unlocking all locks..."); // Skriver till konsolen
                foreach (ILock l in lockable) // Går igenom alla lås
                    l.Unlock(); // Låser upp lås
            }

            CheckDrawer();  // Kollar lådans status

            wood.Unlock();  // Låser upp trädörren
            wood.Close();   // Låser trädörren

            OpenDoors();    // Öppnar alla dörrar

            LockAll();      // Låser alla lås

            CloseDoors();   // Stänger alla dörrar

            UnlockAll();    // Låser upp alla lås

            CloseDoors();   // Stänger alla dörrar

            CheckDrawer();  // Kollar lådans status

            
            Console.Read(); // Programmet väntar på en knapptryckning
        }
    }
}
