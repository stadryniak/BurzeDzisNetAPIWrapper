using System;
using System.Collections.Generic;
using System.Text;

namespace BurzeDzisAPIWrapper.Types
{
    public class City
    {
        public float X { get; set; }
        public float Y { get; set; }

        public City(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
