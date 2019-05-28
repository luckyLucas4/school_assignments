using System;
using System.Collections.Generic;
using System.Text;

namespace SmhiWeather
{
    public interface ISmhi
    {
        decimal CoordLat { get; set; }

        decimal CoordLon { get; set; }

        bool GetForecast(ref Forecast forecast);

        ForecastTimeSerie GetCurrentWeather();
    }
}