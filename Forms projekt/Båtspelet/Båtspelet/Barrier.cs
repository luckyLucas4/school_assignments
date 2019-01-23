using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Båtspelet
{
    public class Barrier : FloatingObject
    {
        // Definierar att konstruktorn från FloatingObject klassen ska användas
        public Barrier(PictureBox box, int speed) : base(box, speed) { }
    }
}
