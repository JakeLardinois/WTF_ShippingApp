using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTFClassLibrary
{
    public class ItemHistoryJob
    {
        public int ReceivedItemAccumulatorID { get; set; }
        public string JobNumber { get; set; }
        public int Suffix { get; set; }
        public string JobOrderNumber { get; set; }
        public int TotalQuantity { get; set; }
        public string LastUpdate { get; set; }
    }
}
