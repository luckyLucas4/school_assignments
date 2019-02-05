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
    class FigurRektangel : Figur
    {
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                var rc = GetRectangle();
                
            }
        }
    }
}
