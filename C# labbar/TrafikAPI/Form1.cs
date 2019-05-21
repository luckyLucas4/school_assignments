using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TrafikAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RoadConnect rc = new RoadConnect();

        public static string dataTxt;
        public static bool fetchingData = false;
        string fetchInput = "";
        private void XmlTricker(string xmlData)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(xmlData);
            writer.Flush();
            stream.Position = 0;
            XmlTextReader xtr = new XmlTextReader(stream);
            while(xtr.Read() == true)
            {
                if(xtr.NodeType == XmlNodeType.Element && xtr.Name == "Force")
                {
                    lbl_Fetch.Text = xtr.ReadElementString(); 
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchInput.Text != null && searchInput.Text.Length >= 3)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Cars.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].InnerText;
                    if (name == searchInput.Text)
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            searchResults.Items.Add(child.InnerText);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
                searchInput.Text = string.Empty;
                searchInput.Focus();
            }
        }

        private void FetchButton_Click(object sender, EventArgs e)
        {
            rc.Start(textBox1.Text);
            syncTimer.Enabled = true;
            fetchingData = true;
            fetchInput = textBox1.Text;
            lbl_Fetch.Text = $"Hämtar data från \n{fetchInput}";
        }

        private void SyncTimer_Tick(object sender, EventArgs e)
        {
            if(fetchingData == false)
                syncTimer.Enabled = false;

            if (dataTxt.Length > 0)
            {
                XmlTricker(dataTxt);
                lbl_Fetch.Text = $"Data hämtad från \n{fetchInput}";
            }

        }
    }
}
