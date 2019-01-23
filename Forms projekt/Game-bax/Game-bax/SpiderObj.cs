using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game_bax
{
    class SpiderObj : SpelMall
    {
        public int speed;

        public SpiderObj(Form mf, Image i, Rectangle rect, int spd) : base(mf, i, rect)
        {
            speed = spd;
        }

        public void OutOfBounds(Rectangle bounds, int i, List<SpiderObj> spindlar)
        {
            if (pictureBox.Top >= bounds.Height)
            {
                //pictureBox.Dispose();
                //spindlar.Remove(this);
                pictureBox.Top = -pictureBox.Height;
            }
        }

        public void MoveSpider(Rectangle bounds, int i, List<SpiderObj> spindlar)
        {
            pictureBox.Top += speed;
            OutOfBounds(bounds, i, spindlar);
        }

        public void RemoveSpider(List<SpiderObj> spindlar)
        {
            pictureBox.Dispose();
            spindlar.Remove(this);
        }

        public void FormPaint(object sender, PaintEventArgs e)
        {
            Graphics formGraphics = e.Graphics;
            int fontSize = 20;
            Font drawFont = new Font("Cambria", fontSize, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.BurlyWood);
        }
    }
}
