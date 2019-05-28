using System;
using System.Linq;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using TrafikAPI;

namespace SmhiWeather
{
    /// <summary>
    /// A class representing the SMHI API service interface of type Pmp3g version 2, that can be asked for the weather forecast.
    /// For SMHI's own documentation on weather parameters, see https://opendata.smhi.se/apidocs/metfcst/parameters.html.
    /// </summary>
    public class Smhi : ISmhi
    {
        private readonly TimeSpan _refreshInterval = new TimeSpan(1, 0, 0);
        private Forecast _cachedForecast = null;
        private DateTime _lastRequestUtcTime = DateTime.MinValue;

        /// <summary>
        /// Creates an SMHI object. The SMHI object is the main object representing the SMHI API interface of SMHI's pmp3g version 2.
        /// </summary>
        /// <param name="lat">The decimal latitude.</param>
        /// <param name="lon">The decimal longitude.</param>
        /// <param name="refreshInterval">The refresh interval, telling the object how often it is ok to contact the SMHI web interface. 
        /// Don't do it more often than necessary, or you will risk that SMHI will block your access.</param>
        public Smhi(decimal lon, decimal lat, TimeSpan refreshInterval)
        {
            CoordLon = lon;
            CoordLat = lat;
            _refreshInterval = refreshInterval;
        }

        /// <summary>
        /// Creates an SMHI object with a refresh interval of one hour. The SMHI object is the main object representing the SMHI 
        /// API interface of SMHI's pmp3g version 2.
        /// </summary>
        /// <param name="lat">The decimal latitude.</param>
        /// <param name="lon">The decimal longitude.</param>
        public Smhi(decimal lon, decimal lat)
            : this(lon, lat, new TimeSpan(1, 0, 0))
        {
        }

        /// <summary>
        /// Gets the decimal longitude.
        /// </summary>
        public decimal CoordLon { get; set; }

        /// <summary>
        /// Gets the decimal latitude.
        /// </summary>
        public decimal CoordLat { get; set; }

        /// <summary>
        /// Gets the complete SMHI forecast for the days ahead.
        /// </summary>
        /// <returns>A forecast for the days ahead.</returns>
        public bool GetForecast(ref Forecast forecastRef)
        {
            Form1.fetchingData = true;
            if (_cachedForecast == null || _lastRequestUtcTime + _refreshInterval < DateTime.UtcNow)
            {
                string lat = CoordLat.ToString("0").Replace(",", ".");
                string lon = CoordLon.ToString("0").Replace(",", ".");
                string uri = $"http://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/{lon}/lat/{lat}/data.json";
                HttpWebRequest webRequest = WebRequest.CreateHttp(uri);


                try
                {
                    using (var webResponse = (HttpWebResponse)webRequest.GetResponse())
                    using (var reader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        //JavaScriptSerializer js = new JavaScriptSerializer();
                        string sJson = reader.ReadToEnd();
                        //var forecast = (Forecast)js.Deserialize(sJson, typeof(Forecast));

                        Forecast forecast = JsonConvert.DeserializeObject<Forecast>(sJson);

                        _lastRequestUtcTime = DateTime.UtcNow;
                        _cachedForecast = forecast;
                        forecastRef = forecast;
                        Form1.errorMessage = "";
                        return true;
                    } 
                }
                catch (Exception e)
                {
                    Form1.errorMessage = e.Message;
                    forecastRef = _cachedForecast;
                    return false;
                }
            }
            else
            {
                forecastRef = _cachedForecast;
                return true;
            }
        }

        /// <summary>
        /// Gets the SMHI forecast time serie for the current hour, of for the first hour that exists in the forecast (may be a bit in the future).
        /// </summary>
        /// <returns>The forecasted weather (time serie) for the current hour.</returns>
        public ForecastTimeSerie GetCurrentWeather()
        {
            DateTime utcNow = DateTime.UtcNow;
            Forecast forecast = null;
            if (GetForecast(ref forecast))
            {
                foreach (var timeSerie in forecast.timeseries.OrderBy(ts => ts.validTime))
                {
                    var universalTime = timeSerie.validTime.ToUniversalTime();
                    var localTime = timeSerie.validTime.ToLocalTime();

                    if (universalTime.AddMinutes(30) > utcNow)
                    {
                        return timeSerie;
                    }
                } 
            }

            return null;
        }
    }
}
