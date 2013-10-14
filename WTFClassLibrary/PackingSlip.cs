using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTFClassLibrary
{
    public class PackingSlip
    {
        //public PackingSlip()
        //{
        //    ModifiedOrderLines = new List<OrderLine>();
        //}
        public Order Order { get; set; }
        public List<OrderLine> ModifiedOrderLines { get; set; }
        public string SpecialInstructions { get; set; }//These are actually the notes on the order
        public double GrossWeight { get; set; }
        public int NoOfCartons { get; set; }
        public int NoOfPallets { get; set; }
        public DateTime ActualShipDate { get; set; }
    }
}
