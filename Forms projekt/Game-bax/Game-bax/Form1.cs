using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_bax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SpiderObj> spindlar = new List<SpiderObj>();
        SpiderObj spindelKalle;
        SpiderObj startSpindel;
        Image spiderImage = Properties.Resources.Spiderman;
        List<Arrow> pilar = new List<Arrow>();
        Image pil = Properties.Resources.Arrow;
        Random rnd = new Random();
        int spiderTimer = 0;
        ulong poäng = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            spindelKalle = new SpiderObj(this, spiderImage, 
                new Rectangle(Bounds.Width / 2, -200, 200, 200), rnd.Next(5, 10));
            spindlar.Add(spindelKalle);

            startSpindel = new SpiderObj(this, spiderImage, 
                new Rectangle(Bounds.Width / 2 - 100, -20, 0, 0), rnd.Next(5, 10));
            spindlar.Add(startSpindel);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach(SpiderObj spindel in spindlar)
            {
                spindel.FormPaint(this, e);
            }
        }

        public void CreateArrow()
        {
            Arrow pil1 = new Arrow(this, pil, 
                new Rectangle(pbx_Pilbåge.Left, pbx_Pilbåge.Top + pbx_Pilbåge.Height/2, 0, 0), 30);
            pilar.Add(pil1);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {


            spiderTimer++;
            if(spiderTimer > 20)
            {
                int height = rnd.Next(10, 200);
                spindlar.Add(new SpiderObj(this, spiderImage,
                    new Rectangle(Bounds.Width / 2 + rnd.Next(-Bounds.Width/5, Bounds.Width/5), -height, 0, height), rnd.Next(5, 10)));
                spiderTimer = 0;
            }

            for (int i = spindlar.Count - 1; i >= 0; i--)
            {
                spindlar[i].speed = 5;
                spindlar[i].MoveSpider(ClientRectangle, Bounds.Width/2 + rnd.Next(-Bounds.Width/4, Bounds.Width/2), spindlar);
            }

            for (int i = pilar.Count - 1; i >= 0; i--)
            {
                for (int j = spindlar.Count - 1; j>= 0; j--)
                {
                    if (pilar[i].Collision(spindlar[j].pictureBox.Bounds))
                    {
                        pilar[i].spiderHit = (ulong)Math.Pow(pilar[i].spiderHit, 2);
                        poäng += pilar[i].spiderHit;
                        spindlar[j].RemoveSpider(spindlar);
                    }
                }
                pilar[i].MoveArrow(ClientRectangle, ref pilar);
            }
            lbl_Poäng.Text = "Poäng: " + poäng;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("w" == e.KeyChar.ToString())
                pbx_Pilbåge.Top -= 20;
            if ("s" == e.KeyChar.ToString())
                pbx_Pilbåge.Top += 20;
            if ("d" == e.KeyChar.ToString())
            {
                if(pilar.Count < 3)
                    CreateArrow();
            }
        }
    }
}
