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
        protected List<Rectangle> rectangles = new List<Rectangle>();
        protected List<Rectangle> ellipses = new List<Rectangle>();

        public Figur(Point position)
        {
            BackColor = Color.Azure;
            this.Location = position;
            this.Size = new Size(200, 200);
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public Figur(Point position, Size size) 
        {
            BackColor = Color.Azure;
            this.Location = position;
            this.Size = size;
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

        protected override void OnMouseMove(MouseEventArgs e)
        {
            currentPos = e.Location;
            if (drawing)
            {
                this.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                currentPos = e.Location;
                var rc = GetRectangle();

                if (rc.Width > 0 & rc.Height > 0)
                {
                    rectangles.Add(rc);
                }

                this.Invalidate(); // Rita om fönstret
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(rectangles.Count > 0)
            {
                e.Graphics.DrawRectangles(Pens.Black, rectangles.ToArray());
            }

            if (drawing)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRectangle());
            }
        }
    }
}
