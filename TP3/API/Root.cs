using System;
using System.Collections.Generic;
namespace TP3.API
{
    public class Root
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public Datum data { get; set; }
        


    }
}

