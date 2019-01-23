using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_C_sharp_StenSaxPåse
{

    public partial class Form1 : Form
    {
        Statistics stats = new Statistics(0, 0);
        string current = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void pcbRock_Click(object sender, EventArgs e)
        {
            
            current = "rock";
            ResetBackgrounds();
            ResetImages();
            pcbRock.BackColor = SystemColors.ActiveCaption;

        }

        private void pcbPaper_Click(object sender, EventArgs e)
        {
            current = "paper";
            ResetBackgrounds();
            ResetImages();
            pcbPaper.BackColor = SystemColors.ActiveCaption;
        }

        private void pcbScissors_Click(object sender, EventArgs e)
        {
            current = "scissors";
            ResetBackgrounds();
            ResetImages();
            pcbScissors.BackColor = SystemColors.ActiveCaption;
        }

        public void ResetBackgrounds()
        {
            pcbRock.BackColor = SystemColors.Control;
            pcbPaper.BackColor = SystemColors.Control;
            pcbScissors.BackColor = SystemColors.Control;
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            if(current == "rock" || current == "paper" || current == "scissors")
            {
                ResetImages();
                Random rnd = new Random();
                int choice = rnd.Next(3);
                switch (current)
                {
                    case "rock":
                        if (choice == 0)
                        { 
                            pcbCompRock.Visible = true;
                        }
                        else if(choice == 1)
                        {
                            stats.pc++;
                            pcbCompPaper.Visible = true;
                        }
                        else
                        {
                            stats.player++;
                            pcbCompScissors.Visible = true;
                        }
                        break;

                    case "paper":
                        if (choice == 0)
                        {
                            stats.player++;
                            pcbCompRock.Visible = true;
                        }
                        else if (choice == 1)
                        {
                            pcbCompPaper.Visible = true;
                        }
                        else
                        {
                            stats.pc++;
                            pcbCompScissors.Visible = true;
                        }
                        break;

                    case "scissors":
                        if (choice == 0)
                        {
                            stats.pc++;
                            pcbCompRock.Visible = true;
                        }
                        else if (choice == 1)
                        {
                            stats.player++;
                            pcbCompPaper.Visible = true;
                        }
                        else
                        {
                            pcbCompScissors.Visible = true;
                        }
                        break;
                }
                UpdateScore();
            }
        }

        private void UpdateScore()
        {
            lblPlayer.Text = stats.player.ToString();
            lblComputer.Text = stats.pc.ToString();
        }

        private void ResetImages()
        {
            pcbCompRock.Visible = false;
            pcbCompPaper.Visible = false;
            pcbCompScissors.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stats.Reset();
            UpdateScore();
        }
    }

    public class Statistics
    {
        public int player { get; set; }
        public int pc { get; set; }
        public Statistics(int player, int pc)
        {
            this.player = player;
            this.pc = pc;
        }

        public void Reset()
        {
            player = 0;
            pc = 0;
        }
    }
}
