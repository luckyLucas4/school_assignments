using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Båtspelet
{
    public class Submarine : FloatingObject
    {
        // Konstruktorn för FloatingObject klassen ska användas
        public Submarine(PictureBox box, int speed) : base(box, speed) { }

        public void Move(int acceleration, int rightLimit)
        {
            // Ubåten ska bara flyttas om den är vid liv
            if (alive)
            {
                // Ubåten flyttas åt höger, med summan av ubåtens fart 
                // och accelerationen som har byggts upp
                box.Left += speed + acceleration;

                // När ubåtens vänstra kant når den högra gränsen flyttas
                // ubäten istället utanför den vänstra kanten
                if (box.Left > rightLimit)
                    box.Left = -box.Width;
            }
        }
    }
}