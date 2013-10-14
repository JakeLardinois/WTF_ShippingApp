using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WTFClassLibrary
{
    public class Label
    {
        public string Name { get; set; }
        public int AddressLineCount { get; set; }
        public string Description { get; set; }
        public string LabelFile { get; set; }
        public string CustomerNumber { get; set; }
        public long CustomerLabelID { get; set; }
        public string SupplierNumber { get; set; }
        public long Sequence { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
