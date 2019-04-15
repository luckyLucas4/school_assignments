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
    class FigurCirkel : Figur
    {
        public FigurCirkel(Point position) : base(position) { }

        public FigurCirkel(Point position, Size size) : base(position, size) { }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                currentPos = e.Location;
                var rc = GetRectangle();

                if (rc.Width > 0 & rc.Height > 0)
                {
                    ellipses.Add(rc);
                }

                this.Invalidate(); // Rita om fönstret
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(ellipses.Count > 0)
            {
                foreach (Rectangle r in ellipses)
                {
                    e.Graphics.DrawEllipse(Pens.Black, r);
                }
            }

            if (drawing)
            {
                e.Graphics.DrawEllipse(Pens.Red, GetRectangle());
            }
        }
    }
}
