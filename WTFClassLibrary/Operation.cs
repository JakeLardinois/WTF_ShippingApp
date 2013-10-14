using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTFClassLibrary
{
    public class Operation
    {
        public string OperationNumber { get; set; }
        public string WorkCenter { get; set; }
        public int QtyComplete { get; set; }
        public int QtyScrapped { get; set; }
        public int QtyMoved { get; set; }
        public int Status { get; set; }
        public Operation NextOperation { get; set; }
        //public string NextOperationNumber { get; set; }

        public override string ToString()
        {
            return OperationNumber.ToString();
        }
    }
}
