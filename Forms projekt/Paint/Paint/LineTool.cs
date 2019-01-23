using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    class LineTool : Tool
    {
        public LineTool(int size, Color color) : base(size, color) { }

        public override void Draw(Point position, Graphics g)
        {

        }

        public override void Draw(Point startPos, Point endPos, Graphics g)
        {

        }
    }
}
