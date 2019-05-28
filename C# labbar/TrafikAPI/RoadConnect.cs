using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TrafikAPI
{
    class RoadConnect
    {
        public void Start(string location)
        {
            WebClient webclient = new WebClient();
            webclient.Headers.Add("Referer", "http://www.example.com"); // Replace with your domain here
            // Registrer a handler that will execute when download is completed.
            webclient.UploadStringCompleted += (obj, arguments) =>
            {
                if (arguments.Cancelled == true)
                {
                    // Console.Write("Request cancelled by user");
                }
                else if (arguments.Error != null)
                {
                    // Console.WriteLine(arguments.Error.Message);
                    // Console.Write("Request Failed");
                }
                else
                {
                    Form1.dataTxt = formatXML(arguments.Result);
                    Form1.fetchingData = false;
                    // Console.Write("Data downloaded");
                }
                // Console.WriteLine(", press 'X' to exit.");
            };

            try
            {
                // API server url
                Uri address = new Uri("http://api.trafikinfo.trafikverket.se/v1/data.xml");
                string requestBody = "<REQUEST>" +
                                        // Use your valid authenticationkey
                                        "<LOGIN authenticationkey='daa56d50f0d149c4bb98c6c1c27090f5'/>" +
                                        //"<QUERY objecttype='WeatherStation' >" +
                                        //    "<FILTER>" +
                                        //        $"<IN name='Name' value='{location}'/>" +
                                        //    "</FILTER>" +
                                        //    "<INCLUDE>Measurement.Air.Temp</INCLUDE>" + 
                                        //    "<INCLUDE>Measurement.MeasureTime</INCLUDE>" +
                                        //    "<INCLUDE>Measurement.Wind.Force</INCLUDE>" +
                                        //"</QUERY>" +
                                        "<QUERY objecttype='TrainMessage' schemaversion='1.3'>" +
                                            "<FILTER>" +
                                                $"<EQ name='AffectedLocation' value='Cst'/>" +
                                            "</FILTER>" +
                                            "<INCLUDE>StartDateTime</INCLUDE>" +
                                            "<INCLUDE>LastUpdateTime</INCLUDE>" +
                                            "<INCLUDE>ReasonCodeText</INCLUDE>" +
                                            "<INCLUDE>ExternalDescription</INCLUDE>" +
                                        "</QUERY>" +
                                    "</REQUEST>";

                webclient.Headers["Content-Type"] = "text/xml";
                // Console.WriteLine("Fetching data ... (press 'C' to cancel)");
                webclient.UploadStringAsync(address, "POST", requestBody);
            }
            catch (UriFormatException)
            {
                // Console.WriteLine("Malformed url, press 'X' to exit.");
            }
            //catch (Exception ex)
            //{
            //    // Console.WriteLine(ex.Message);
            //    // Console.WriteLine("An error occured, press 'X' to exit.");
            //}

            //char keychar = ' ';
            //while (keychar != 'X')
            //{
            //    keychar = Char.ToUpper(Console.ReadKey().KeyChar);
            //    if (keychar == 'C')
            //    {
            //        webclient.CancelAsync();
            //    }
            //}
        }

        // Format xml so it is readable by humans.
        private static string formatXML(string xml)
        {
            // Format xml.
            XDocument rxml = XDocument.Parse(xml);
            XmlWriterSettings xmlsettings = new XmlWriterSettings();
            xmlsettings.OmitXmlDeclaration = true;
            xmlsettings.Indent = true;
            xmlsettings.IndentChars = "      ";
            var sb = new StringBuilder();
            using (XmlWriter xmlWriter = XmlWriter.Create(sb, xmlsettings))
            {
                rxml.WriteTo(xmlWriter);
            }
            return sb.ToString();
        }
    }
}
