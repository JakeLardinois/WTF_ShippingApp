using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTFClassLibrary
{
    public class StockLocation
    {
        public string Location { get; set; }
        public string LocationDescription { get; set; }
        public char LocationType { get; set; }
        public int Rank { get; set; }

        public override string ToString()
        {
            return Location;
        }
    }
}
