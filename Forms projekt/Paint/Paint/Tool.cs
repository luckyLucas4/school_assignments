using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    abstract class Tool
    {
        public int size;
        public Color color;

        public Tool(int size, Color color)
        {
            this.size = size;
            this.color = color;
        }

        public abstract void Draw(Point position, Graphics g);


        public abstract void Draw(Point startPos, Point endPos, Graphics g);

    }
}
