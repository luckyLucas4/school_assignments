using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game_bax
{
    class Arrow : SpelMall
    {
        public int speed;
        public ulong spiderHit;

        public Arrow(Form mf, Image i, Rectangle rect, int spd) : base(mf, i, rect)
        {
            speed = spd;
            spiderHit = 2;
        }

        public void OutOfBounds(Rectangle bounds, ref List<Arrow> pilar)
        {
            if (pictureBox.Left >= bounds.Width)
            {
                pictureBox.Dispose();
                pilar.Remove(this);
            }
        }

        public void MoveArrow(Rectangle bounds, ref List<Arrow> pilar)
        {
            pictureBox.Left += speed;
            OutOfBounds(bounds, ref pilar);
        }

        public bool Collision(Rectangle rect)
        {
            if (pictureBox.Bounds.IntersectsWith(rect))
            {
                return true;
            }
            return false;
        }

        public void FormPaint(object sender, PaintEventArgs e)
        {
            int fontSize = 18;
            Graphics formGraphics = e.Graphics;
            Font drawFont = new Font("Cambria", fontSize, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.BurlyWood);
            int x = pictureBox.Left;
            int y = pictureBox.Top - (fontSize * 2);
            Point pos = new Point(x, y);
            formGraphics.DrawString("Spooderman", drawFont, drawBrush, x, y);
        }
    }
}
