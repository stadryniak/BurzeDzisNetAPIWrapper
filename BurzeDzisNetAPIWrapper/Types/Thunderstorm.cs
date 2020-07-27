using System;
using System.Collections.Generic;
using System.Text;
using BurzeAPI;

namespace BurzeDzisAPIWrapper.Types
{
    class Thunderstorm
    {
        public int Count { get; set; }
        public float Distance { get; set; }
        public string Direction { get; set; }
        public int Period { get; set; }
    }
}
