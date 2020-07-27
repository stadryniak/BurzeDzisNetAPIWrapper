using System;
using System.Collections.Generic;
using System.Text;
using BurzeAPI;

namespace BurzeDzisAPIWrapper.Types
{
    class WeatherWarning
    {
        //Thunderstorm
        public bool Thunderstorm { get; set; }
        public DateTime ThunderstormStart { get; set; }
        public DateTime ThunderstormEnd { get; set; }
        //Cold
        public bool Cold { get; set; }
        public DateTime ColdStart { get; set; }
        public DateTime ColdEnd { get; set; }
        //Heat
        public bool Heat { get; set; }
        public DateTime HeatStart { get; set; }
        public DateTime HeatEnd { get; set; }
        //Wind
        public bool Wind { get; set; }
        public DateTime WindStart { get; set; }
        public DateTime WindEnd { get; set; }
        //Rain
        public bool Rain { get; set; }
        public DateTime RainStart { get; set; }
        public DateTime RainEnd { get; set; }
        //Tornado
        public bool Tornado { get; set; }
        public DateTime TornadoStart { get; set; }
        public DateTime TornadoEnd { get; set; }
    }
}
