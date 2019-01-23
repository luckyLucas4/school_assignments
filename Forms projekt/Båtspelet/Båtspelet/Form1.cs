using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Båtspelet
{
    public partial class båtspelet : Form
    {
        // Håller koll på om spelet är igång
        bool gameActive = true;

        // Håller koll på om en bomb är aktiv
        bool fire = false;

        // Används för att avgöra om skeppet kan skjuta en bomb
        bool bombReady = true;

        // Används för att kunna kontrollera hastigheten på Ariel och accelerationen
        int arielTimer = 0;
        int accTimer = 0;

        // Håller reda på poängen
        int score = 0;

        // En lista som ska samla alla ubåtar
        List<Submarine> subs = new List<Submarine>();

        // En lista för att samla alla hinder
        List<Barrier> barriers = new List<Barrier>();

        // Innehåller alla resultat
        List<Resultat> results = new List<Resultat>();

        // Används för att accelerera farten på alla ubåtar
        int accelerate = 0;

        public båtspelet()
        {
            InitializeComponent();
        }

        // Anropas när spelet laddar
        private void Båtspelet_Load(object sender, EventArgs e)
        {
            // Skapar ett Submarine objekt för varje PictureBox som har skapats
            // och samlar dem i en lista
            subs.Add(new Submarine(submarine1, 3));
            subs.Add(new Submarine(submarine2, 2));
            subs.Add(new Submarine(submarine3, 1));

            // Länkar varje hinder som har skapats i designern
            // till Barrier objekt och lägger till dem i en lista
            barriers.Add(new Barrier(barrier2, 5));
            barriers.Add(new Barrier(barrier3, 3));
            barriers.Add(new Barrier(barrier4, 4));
            barriers.Add(new Barrier(barrier5, 2));
        }

        // Anropas när man trycker på en knapp
        private void Båtspelet_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Om spelet är igång
            if (gameActive)
            {
                // "A" flyttar skeppet åt vänster, "D" flyttar skeppet åt höger och "W" används för att släppa bomber
                if (("a" == e.KeyChar.ToString() || "A" == e.KeyChar.ToString()) && ship.Left > 0)
                    ship.Left -= 10;
                if (("d" == e.KeyChar.ToString() || "D" == e.KeyChar.ToString()) && ship.Left + ship.Width < vatten.Width)
                    ship.Left += 10;
                if ("w" == e.KeyChar.ToString() || "W" == e.KeyChar.ToString())
                    fire = true;
            }
        }

        // Anropas varje hundradels sekund
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Två variabler används för att räkna antalet ticks från timern
            arielTimer++;
            accTimer++;

            // Flyttar Ariel åt vänster 
            // när 5 millisekunder har passerat och spelet är aktivt
            if(arielTimer > 5 && gameActive)
            {
                ariel.Left -= 1;
                arielTimer = 0;
            }

            // Ökar på variabeln som accelerar ubåtarna 
            // när 100 millisekunder har passerat och spelet är aktivt
            if(accTimer > 100 && gameActive)
            {
                accelerate++;
                accTimer = 0;
            }

            // Spelet avslutas och game over texten visas om Ariel når skeppet
            if (ariel.Left < ship.Left + ship.Size.Width - 5 && gameActive)
            {
                gameActive = false;
                lbl_gameOver.Visible = true;
            }

            // Om spelet är igång flyttas alla ubåtar genom att .Move funktionen anropas
            if(gameActive)
            {
                foreach (Submarine sub in subs)
                    sub.Move(accelerate, vatten.Width);

                foreach (Barrier barrier in barriers)
                    barrier.Move(vatten.Width);
            }

            // Om spelet är igång och fire är "true" ska bomben fortsätta att falla
            // Fire ändras till true när knappen för att skjuta trycks ned, och blir falsk när bomben försvinner
            if (fire && gameActive)
            {
                // Om en ny bomb är redo ska den visas vid skeppet
                if (bombReady)
                {
                    bomb.Visible = true;
                    bomb.Left = ship.Left + 20;
                    bomb.Top = 0; // Längst upp inne i den PictureBox bomben ligger i
                    bombReady = false;
                }

                // Om bomben har sjunkit nedanför slutet på vattnet kan vi släppa en ny bomb,
                // den gamla försvinner, och vi sätter fire till "false" så att bomben slutar falla
                if(bomb.Top > vatten.Height)
                {
                    fire = false;
                    bombReady = true;
                    bomb.Visible = false;
                }

                // Bomben sjunker ner
                bomb.Top += 5;
            }

            // Kollisioner med ubåtar
            // Går igenom alla ubåtar i listan
            foreach (Submarine sub in subs)
            {
                // Funktionen för att kollision används för att kolla 
                // om någon av ubåtarna som är vid liv har blivit träffade
                if(CheckCollision(bomb, sub.box) && sub.alive)
                {
                    sub.alive = false;
                    sub.box.Image = Properties.Resources.Explode_fire; // Startar en explosions-animation
                    BombHit(1); // Träff av ubåt ger ett poäng
                }

                // Funktionen WaitForRespawn avgör om ubåten ska återupplivas
                sub.WaitForRespawn();
            }

            // Går igenom alla hinder och kollar om någon har kolliderat med en bomb
            foreach (Barrier barrier in barriers)
            {
                if (CheckCollision(bomb, barrier.box) && barrier.alive)
                    BombHit(0); // En kollision med ett hinder ger inga poäng
            }
        }

        // Funktionen anropas när en bomb har träffat en ubåt
        private void BombHit(int points)
        {
            // Poängen ökas och visas på skärmen
            score += points;
            scoreText.Text = score.ToString();

            // Bomben görs redo för att kunna släppas igen
            fire = false;
            bombReady = true;
            bomb.Visible = false;
        }

        // Undersöker om två bildlådor har krockat
        private bool CheckCollision(PictureBox obj1, PictureBox obj2)
        {
            // Kollar separat för x- och y-värden om någon av objektens hörn överlappar
            bool insideX = obj1.Left + obj1.Size.Width > obj2.Left 
                && obj1.Left < obj2.Left + obj2.Size.Width;

            bool insideY = obj1.Top + obj1.Size.Height > obj2.Top
                && obj1.Top < obj2.Top + obj2.Size.Height;

            // Om lådorna överlappar i båda leden och båda leden är synliga returneras "true",
            // annars returneras "false"
            if(insideX && insideY && obj1.Visible && obj2.Visible)
                return true;
            else
                return false;
        }

        // Anropas när omstartsknappen klickas
        private void restart_Click(object sender, EventArgs e)
        {
            // Om något har skrivits in i textrutan kan poängen sparas och spelet startas om,
            // annars byter textrutan färg och en varning visas
            if(tb_namn.Text.Length > 0)
            {
                SaveScore();
                Restart();
            }
            else
            {
                tb_namn.BackColor = Color.LightSalmon;
                lbl_varning.Visible = true;
            }
        }

        private void SaveScore()
        {
            bool noDuplicate = true; // Försäkrar att det inte finns någon dublett
            Resultat toRemove = null; // Här kan vi lägga in ett resultat som ska raderas
            // Går igenom alla namn och kollar om det redan finns ett resultat 
            // med samma namn och samma eller lägre poäng, isåfall avslutas funktionen direkt
            foreach (Resultat resultat in results)
            {
                if (resultat.name == tb_namn.Text && resultat.score <= score)
                {
                    toRemove = resultat;
                    break;
                }
                else if(resultat.name == tb_namn.Text)
                {
                    noDuplicate = false;
                    break;
                }
            }
            // Om det finns ett resultat i variabeln raderas den från listan
            if(toRemove != null)
            {
                results.Remove(toRemove);
            }

            // Om det inte finns någon dublett
            if(noDuplicate == true)
            {
                // Lägger till ett nytt resultat-objekt i listan och sorterar listan i stigande ordning
                // (resultat-objekt sorteras efter deras poäng)
                results.Add(new Resultat(tb_namn.Text, score));
                results.Sort();
                results.Reverse();
            }

            // Rensar bort allt som tidigare fanns i list-view fönstret
            lv_resultat.Items.Clear();

            // Loopar en gång för varje resultat-objekt i listan
            for (int i = 0; i < results.Count; i++)
            {
                // Skapar en ny rad med samma namn som numret i ordningen
                ListViewItem lv1 = new ListViewItem((i + 1).ToString(), 0);
                // Lägger till namn och poäng på raden
                lv1.SubItems.Add(results[i].name);
                lv1.SubItems.Add(results[i].score.ToString());

                // Lägger in raden i list-view fönstret
                lv_resultat.Items.Add(lv1);
            }

            // Ser till att inmatningsfältet har vit backgrund (kan ändras vid felaktig inmatning)
            // och att varningen försvinner
            tb_namn.BackColor = Color.White;
            lbl_varning.Visible = false;

            // Tar bort focus från textrutan, så att data från knapptryckningarna inte skickas dit
            ActiveControl = null;
        }

        // Funktionen används för att placera alla bilder rätt och starta om spelet
        private void Restart()
        {
            // Återställer poängen till 0
            score = 0;
            scoreText.Text = score.ToString();

            // Sätter skeppet vid vänstra kanten och Ariel vid högra kanten
            ship.Left = 37;
            ariel.Left = vatten.Width - ariel.Width;

            // Nollställer accelerationen på ubåtarna
            accelerate = 0;

            // Återupplivar alla ubåtar
            foreach (Submarine sub in subs)
                sub.Respawn();

            // Döljer game-over texten
            lbl_gameOver.Visible = false;
            
            // Spelet är nu igång
            gameActive = true;
        }

        // När anropar SaveScore när spara-knappen blir klickad
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveScore();
        }
    }
}
