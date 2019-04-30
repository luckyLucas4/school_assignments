using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RoadConnect rc1 = new RoadConnect();

        private void Button1_Click(object sender, EventArgs e)
        {
            rc1.Start();
        }
    }
}
