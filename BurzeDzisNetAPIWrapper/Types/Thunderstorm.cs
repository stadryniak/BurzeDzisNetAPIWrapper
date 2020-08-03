using System;
using BurzeAPI;

namespace BurzeDzisAPIWrapper.Types
{
    public class Thunderstorm
    {
        public int Count { get; }
        public float Distance { get; }
        public string Direction { get; }
        public int Period { get; }

        public Thunderstorm(MyComplexTypeBurza thunder)
        {
            if (thunder.liczba == null || thunder.odleglosc == null || thunder.okres == null)
            {
                throw new ArgumentNullException(nameof(thunder));
            }
            Count = (int)thunder.liczba;
            if (Count <= 0)
            {
                return;
            }
            Distance = (float)thunder.odleglosc;
            Direction = thunder.kierunek;
            Period = (int)thunder.okres;
        }
    }
}
