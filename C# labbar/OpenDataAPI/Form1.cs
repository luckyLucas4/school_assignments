using Google.Apis.Services;
using SmhiWeather;
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
        ISmhi smhi;
        public Form1()
        {
            InitializeComponent();
            requests = rc.ReturnRequests();
            smhi = new Smhi(num_lon.Value, num_lat.Value, new TimeSpan(0, 0, 1));
            UpdateSmhi();
        }
        void UpdateSmhi()
        {
            smhi.CoordLon = num_lon.Value;
            smhi.CoordLat = num_lat.Value;
            var currentWeather = smhi.GetCurrentWeather();
            rtb_smhi.Text = Convert.ToString(currentWeather);
        }
        
        RoadConnect rc = new RoadConnect();

        public static string dataTxt = "";
        public static bool fetchingData = false;
        public static string errorMessage = "";

        public static List<string> requests;
        public static int currentRequest = 0;

        string fetchInput = "";
        private void XmlTricker(string xmlData)
        {
            lv_tags.Clear();
            rtb_xml.Text = xmlData;
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(xmlData);
            writer.Flush();
            stream.Position = 0;
            XmlTextReader xtr = new XmlTextReader(stream);
            while (xtr.Read() == true)
            {
                if (xtr.IsStartElement())
                    lv_tags.Items.Add(new ListViewItem(xtr.Name));
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchInput.Text != null && searchInput.Text.Length >= 3 && dataTxt.Length > 0)
            {
                var stream = new MemoryStream();
                var writer = new StreamWriter(stream);
                writer.Write(dataTxt);
                writer.Flush();
                stream.Position = 0;
                XmlTextReader xtr = new XmlTextReader(stream);

                while (xtr.Read() == true)
                {
                    if(xtr.NodeType == XmlNodeType.Element && xtr.Name == searchInput.Text)
                    {
                        rtb_search.Text = xtr.ReadInnerXml();
                    }
                }

                //    XmlDocument doc = new XmlDocument();

                //    foreach (XmlNode node in doc.DocumentElement)
                //    {
                //        string name = node.Attributes[0].InnerText;
                //        if (name == searchInput.Text)
                //        {
                //            foreach (XmlNode child in node.ChildNodes)
                //            {
                //                lv_searchResults.Items.Add(child.InnerText);
                //            }
                //        }
                //    }
            }
            else
            {
                MessageBox.Show("Invalid input");
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
            lbl_error.Text = errorMessage;
            if(fetchingData == false)
                syncTimer.Enabled = false;

            if (dataTxt.Length > 0)
            {
                XmlTricker(dataTxt);
                rtb_xml.Text = dataTxt;
                lbl_Fetch.Text = $"Data hämtad från \n{fetchInput}";
            }
        }

        string CleanString(string text)
        {
            text = text.Replace("Ã¥", "å");
            text = text.Replace("Ã¤", "ä");
            text = text.Replace("Ã¶", "ö");

            text = text.Replace("Ã…", "Å");
            text = text.Replace("Ã„", "Ä");
            text = text.Replace("Ã–", "Ö");

            return text;
        }

        private void Num_lon_ValueChanged(object sender, EventArgs e)
        {
            UpdateSmhi();
        }

        private void Num_lat_ValueChanged(object sender, EventArgs e)
        {
            UpdateSmhi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rb_fetch1_CheckedChanged(object sender, EventArgs e)
        {
            currentRequest = 0;
        }

        private void Rb_fetch2_CheckedChanged(object sender, EventArgs e)
        {
            currentRequest = 1;
        }
    }
}
