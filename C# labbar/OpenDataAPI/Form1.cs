using Google.Apis.Services;
using Piksel.SMHISharp;
using Piksel.SMHISharp.Structures;
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
        ApiClient _smhi;
        private Station[] _stations;
        public Form1()
        {
            //bc.Run().Wait();
            InitializeComponent();

            _smhi = new ApiClient();

            wizard.PageDisplayed(tpParameters, (prev) =>
            {
                if (!prev)
                {
                    pLoadParameters.Visible = true;
                    olvParameters.Visible = false;
                    _smhi.GetResources(res =>
                    {
                        olvParameters.SetObjects(res);
                        pLoadParameters.Visible = false;
                        olvParameters.Visible = true;
                    });
                }
            });

            wizard.NextFunction(tpParameters, () => olvParameters.SelectedIndex != -1);

            wizard.PageDisplayed(tpStations, (prev) =>
            {
                var resource = tpParameters.SelectedObject as Resource;
                if (resource == null) return;

                if (!prev)
                {
                    pLoadStations.Visible = true;
                    scStations.Visible = false;
                    _smhi.GetStations(resource.Key, stations => {
                        _stations = stations;
                        olvStations.SetObjects(stations);
                        pLoadStations.Visible = false;
                        scStations.Visible = true;
                    });
                }
            });

            wizard.NextFunction(tpStations, () => olvStations.SelectedIndex != -1);

            wizard.PageDisplayed(tpPeriods, (prev) =>
            {
                var resource = tpParameters.SelectedObject as Resource;
                var station = olvStations.SelectedObject as Station;

                if (station == null || resource == null) return;

                if (!prev)
                {
                    pLoadPeriods.Visible = true;
                    olvPeriods.Visible = false;
                    _smhi.GetPeriods(resource.Key, station.Key, periods =>
                    {
                        olvPeriods.SetObjects(periods);
                        pLoadPeriods.Visible = false;
                        olvPeriods.Visible = true;
                    });
                }
            });

            wizard.NextFunction(tpPeriods, () => olvPeriods.SelectedIndex != -1);

            wizard.PageDisplayed(tpData, (prev) =>
            {
                var resource = tpParameters.SelectedObject as Resource;
                var station = olvStations.SelectedObject as Station;
                var period = olvPeriods.SelectedObject as PeriodResult;

                if (station == null || resource == null || period == null) return;

                if (!prev)
                {
                    pLoadData.Visible = true;
                    chartData.Visible = false;

                    _smhi.GetData(resource.Key, station.Key, period.Key, (dataPoints, exception) => {
                        if (exception == null)
                        {
                            chartData.Series[0].Points.Clear();
                            foreach (var dataPoint in dataPoints)
                                chartData.Series[0].Points.AddXY(dataPoint.Date.LocalDateTime, dataPoint.Value);
                            pLoadData.Visible = false;
                            chartData.Visible = true;
                            chartData.Update();
                        }
                        else
                        {
                            MessageBox.Show("Error getting data: " + exception.Message, "Error getting data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pLoadData.Visible = false;
                        }
                    });
                }
            });
        }

        RoadConnect rc = new RoadConnect();
        BookConnect bc = new BookConnect();

        public static string dataTxt = "";
        public static bool fetchingData = false;
        string fetchInput = "";
        private void XmlTricker(string xmlData)
        {
            rtb_xml.Text = xmlData;
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(xmlData);
            writer.Flush();
            stream.Position = 0;
            XmlTextReader xtr = new XmlTextReader(stream);
            while (xtr.Read() == true)
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Force")
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
                dataTxt = CleanString(dataTxt);
                XmlTricker(dataTxt);
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
    }
}
