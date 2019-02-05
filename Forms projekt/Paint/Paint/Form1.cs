using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class MyPaint : Form
    {
        bool draw = false;

        int pX = -1;
        int pY = -1;

        Bitmap drawing;

        public MyPaint()
        {
            InitializeComponent();

            drawing = new Bitmap(pbx_drawArea.Width, pbx_drawArea.Height, pbx_drawArea.CreateGraphics());
            Graphics.FromImage(drawing).Clear(Color.White);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics panel = Graphics.FromImage(drawing);

                Pen pen = new Pen(Color.Black, 14);

                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.Round;

                panel.DrawLine(pen, pX, pY, e.X, e.Y);

                pbx_drawArea.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
            }

            pX = e.X;
            pY = e.Y;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;

            pX = e.X;
            pY = e.Y;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void pbx_drawArea_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(drawing, new Point(0, 0));
        }
    }
}
