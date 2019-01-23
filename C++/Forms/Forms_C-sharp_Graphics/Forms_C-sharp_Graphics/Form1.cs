using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_C_sharp_Graphics
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        // Används av huvud-timern
        int second = 0;
        int minute = 0;
        string sec;
        string min;

        // Används av timern som räknar ner
        int switchTimer = 5; // Minskar varje sekund 
        int secondsToSwitch = 5; // Timern återställs till det här värdet, 5 är standard

        // Ändras av start/stopp knappen
        bool stop = true;

        // Rektangel- och färgobjekt skapas från respektive klass, kommer användas till bakgrunden
        Rectangle backRect = new Rectangle(240, 150, 120, 300);
        Color backClor = Color.Black;

        // Objekt och färg för ljuset, startar som röd
        Rectangle ellipse = new Rectangle(260, 160, 80, 80);
        Color frontClor = Color.Red;

        // De olika punkterna dit ljuset ska fyttas
        Point upPoint = new Point(260, 160);
        Point middlePoint = new Point(260, 260);
        Point downPoint = new Point(260, 360);
        
        // Håller koll på ljusets position
        int position = 0;

        // Funktionen som ritar på skärmen
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Objektet som används för att rita
            Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();

            // Skapar en pensel och använder den för att rita bakgrunden till trafikljuset
            Brush backBrush = new SolidBrush(backClor);
            graphicsObj.FillRectangle(backBrush, backRect);

            // Skapar en pensel och använder den för att rita ljuset
            Brush frontBrush = new SolidBrush(frontClor);
            graphicsObj.FillEllipse(frontBrush, ellipse);
        }

        // "Slå om"-knappen, aktiverar funktionen för att rita ljusen och återställer nedräkningen
        private void button1_Click(object sender, EventArgs e)
        {
            DrawLights();
            switchTimer = secondsToSwitch;
        }

        // Ändrar position och färg för ljuset beroende av den nuvarande positionen, flyttar positionen ett steg
        private void DrawLights()
        {
            if (position == 0)
            {
                ellipse.Location = middlePoint;
                frontClor = Color.Orange;
                position++;
            }
            else if (position == 1)
            {
                ellipse.Location = downPoint;
                frontClor = Color.Green;
                position++;
            }
            else if (position == 2)
            {
                ellipse.Location = middlePoint;
                frontClor = Color.Orange;
                position++;
            }
            else
            {
                ellipse.Location = upPoint;
                frontClor = Color.Red;
                position = 0;
            }

            this.Refresh(); // Signalerar att fönstret ska ritas om
        }

        // Aktiveras av timern varje sekund
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            if (switchTimer <= 0) // Om nedräkningen för byte har nått noll
            {
                switchTimer = secondsToSwitch; // Återställ nedräkningen
                DrawLights(); // Rita ljuset på en ny position
            }

            lblSwitch.Text = switchTimer.ToString(); // Skriv texten som visar nedräkningen

            if (!stop) // Om stoppknappen inte har aktiverats
            {
                switchTimer--; // Fortsätt räkna ned
            }

            second++; // Öka huvudtimern

            // Räkna minuterna
            if(second == 60)
            {
                second = 0;
                minute++;
            }

            // Skriv ut värdena för huvudtimern, formaterat som två siffror på varje värde
            sec = second.ToString();
            min = minute.ToString();

            lblTime.Text = String.Format("{0:D2}:{1:D2}", minute, second);
        }

        // Sätter nytt startvärde för nedräkningen när nummerväljaren har ändrats
        private void numCountdown_ValueChanged(object sender, EventArgs e)
        {
            secondsToSwitch = Convert.ToInt32(numCountdown.Value);
        }

        // När start/stop knappen aktiveras
        private void button2_Click(object sender, EventArgs e)
        {
            if (stop) // Om timern har stannat
            {
                stop = false; // Kommer starta nedräkningen
                button2.Text = "Stanna"; // Ändra texten på knappen
            }
            else
            {
                switchTimer = secondsToSwitch; // Återställ nedräkningen
                stop = true;  // Kommer stanna nedräkningen
                button2.Text = "Starta"; // Ändra texten på knappen
            }
        }

        // Funktionerna körs när knapparna för att manuellt ändra färgen aktiveras
        // Ljuset ändras till rätt position ritas genom DrawLights() funktionen
        private void btnRed_Click(object sender, EventArgs e)
        {
            position = 3;
            DrawLights();
        }

        private void btnGul_Click(object sender, EventArgs e)
        {
            position = 0;
            DrawLights();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            position = 1;
            DrawLights();
        }
    }
}
