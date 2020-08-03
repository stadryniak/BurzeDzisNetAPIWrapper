using System;
using BurzeAPI;

namespace BurzeDzisAPIWrapper.Types
{
    public class WeatherWarning
    {
        //Thunderstorm
        public byte Thunderstorm { get; }
        public DateTime ThunderstormStart { get; }
        public DateTime ThunderstormEnd { get; }

        //Cold
        public byte Cold { get; }
        public DateTime ColdStart { get; }
        public DateTime ColdEnd { get; }

        //Heat
        public byte Heat { get; }
        public DateTime HeatStart { get; }
        public DateTime HeatEnd { get; }

        //Wind
        public byte Wind { get; }
        public DateTime WindStart { get; }
        public DateTime WindEnd { get; }

        //Rain
        public byte Rain { get; }
        public DateTime RainStart { get; }
        public DateTime RainEnd { get; }

        //Tornado
        public byte Tornado { get; }
        public DateTime TornadoStart { get; }
        public DateTime TornadoEnd { get; }

        public WeatherWarning(MyComplexTypeOstrzezenia warnings)
        {
            //Check parameters
            if (warnings.burza == null || warnings.upal == null || warnings.mroz == null ||
                warnings.wiatr == null || warnings.opad == null || warnings.traba == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }

            //Thunderstorm
            Thunderstorm = (byte)warnings.burza;
            if (Thunderstorm > 0)
            {
                ThunderstormStart = DateTime.Parse(warnings.burza_od_dnia).ToLocalTime();
                ThunderstormEnd = DateTime.Parse(warnings.burza_do_dnia).ToLocalTime();
            }
            //Cold
            Cold = (byte)warnings.mroz;
            if (Cold > 0)
            {
                ColdStart = DateTime.Parse(warnings.mroz_od_dnia).ToLocalTime();
                ColdEnd = DateTime.Parse(warnings.mroz_do_dnia).ToLocalTime();
            }
            //Heat
            Heat = (byte)warnings.upal;
            if (Heat > 0)
            {
                HeatStart = DateTime.Parse(warnings.upal_od_dnia).ToLocalTime();
                HeatEnd = DateTime.Parse(warnings.upal_do_dnia).ToLocalTime();
            }
            //Wind
            Wind = (byte)warnings.wiatr;
            if (Wind > 0)
            {
                WindStart = DateTime.Parse(warnings.wiatr_od_dnia).ToLocalTime();
                WindEnd = DateTime.Parse(warnings.burza_do_dnia).ToLocalTime();
            }
            //Rain
            Rain = (byte)warnings.opad;
            if (Rain > 0)
            {
                RainStart = DateTime.Parse(warnings.opad_od_dnia).ToLocalTime();
                RainEnd = DateTime.Parse(warnings.burza_do_dnia).ToLocalTime();
            }
            //Tornado
            Tornado = (byte)warnings.traba;
            if (Tornado > 0)
            {
                TornadoStart = DateTime.Parse(warnings.traba_od_dnia).ToLocalTime();
                TornadoEnd = DateTime.Parse(warnings.traba_do_dnia).ToLocalTime();
            }
        }
    }
}