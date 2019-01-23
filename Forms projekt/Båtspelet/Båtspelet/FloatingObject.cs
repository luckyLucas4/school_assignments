using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Båtspelet
{
    public class FloatingObject
    {

        public bool alive;      // Är föremålet vid liv?
        public int respawnTimer;// Håller koll på hur länge föremålet har varit "dött"
        public PictureBox box;  // Lådan på skärmen som ska flyttas runt
        public int speed;       // Farten

        protected Point startPoint;   // Här sparar vi koordinaterna som föremålet skapas vid

        // En konstruktor som tar in en Picturebox och en fart
        public FloatingObject(PictureBox box, int speed)
        {
            alive = true;
            respawnTimer = 0;
            startPoint = new Point(box.Left, box.Top);

            this.box = box;
            this.speed = speed;
        }

        public void WaitForRespawn()
        {
            // Om föremålet inte är vid liv ska vi fortsätta nedräkningen för att återuppliva den
            if (alive == false)
            {
                // Timern tickar uppåt
                respawnTimer++;

                // Om det har gått 4 och en halv sekund ska föremålet återupplivas utanför skärmens vänstra kant
                if (respawnTimer > 450)
                {
                    box.Left = -box.Width;
                    box.Image = Properties.Resources.sub;
                    box.Visible = true;
                    alive = true;
                    respawnTimer = 0;
                }
                // Om det har gått en halv sekund är explosionen klar
                else if (respawnTimer > 50)
                {
                    box.Visible = false;
                }
            }
        }

        // Anropas när spelet startar om
        public void Respawn()
        {
            box.Left = startPoint.X;
            box.Top = startPoint.Y;
            box.Image = Properties.Resources.sub;
            box.Visible = true;
            alive = true;
        }

        // Föremålet flyttas varje hundradels sekund
        public void Move(int rightLimit)
        {
            // Föremålet ska bara flyttas om den är vid liv
            if (alive)
            {
                // Föremålet flyttas åt höger, med summan av ubåtens fart 
                box.Left += speed;

                // När föremålets vänstra kant når den högra gränsen flyttas
                // föremålet utanför den vänstra kanten
                if (box.Left > rightLimit)
                    box.Left = -box.Width;
            }
        }
    }
}
