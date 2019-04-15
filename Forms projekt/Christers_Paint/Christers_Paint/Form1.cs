using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Christers_Paint
{
    public partial class Form1 : Form
    {

        FigurRektangel rekt;
        FigurCirkel cirkel;

        public Form1()
        {
            InitializeComponent();
            rekt = new FigurRektangel(new Point(0,0));
            this.Controls.Add(rekt);
            cirkel = new FigurCirkel(new Point(300, 0), new Size(400,300));
            this.Controls.Add(cirkel);
        }
    }
}
