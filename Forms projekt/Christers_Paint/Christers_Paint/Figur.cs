using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Christers_Paint
{
    class Figur : Panel
    {
        protected Point startPos;
        protected Point currentPos;
        protected bool drawing;
        protected List<Rectangle> figures = new List<Rectangle>();

        public Figur()
        {
            BackColor = Color.Azure;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected Rectangle GetRectangle()
        {
            return new Rectangle(
                Math.Min(startPos.X, currentPos.X),
                Math.Min(startPos.Y, currentPos.Y),
                Math.Abs(startPos.X - currentPos.X),
                Math.Abs(startPos.Y - currentPos.Y)
                );
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            currentPos = startPos = e.Location;
            drawing = true;
        }
    }
}
