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
        
        public static string dataTxt = "";



        private void Button1_Click(object sender, EventArgs e)
        {
            rc1.Start(textBox1.Text);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(dataTxt.Length > 0)
            {
                string forceValue = "none";
                string tempValue = "none";
                
                int pos1 = dataTxt.IndexOf("<Temp>", 0) + "<Temp>".Length;
                int pos2 = dataTxt.IndexOf("</Temp>", 0);

                if (pos1 >= 0 && pos2 >= 0)
                    tempValue = dataTxt.Substring(pos1, pos2 - pos1);

                int pos3 = dataTxt.IndexOf("<Force>", 0) + "<Force>".Length;
                int pos4 = dataTxt.IndexOf("</Force>", 0);
                if(pos3 >= 0 && pos4 >= 0)
                    forceValue = dataTxt.Substring(pos3, pos4 - pos3);

                temp.Text = dataTxt;
                lbl_Force.Text = forceValue;
                lbl_Temp.Text = tempValue;
            }
        }
    }
}
