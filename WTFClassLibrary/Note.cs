using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTFClassLibrary
{
    public class Note
    {
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool IsSpecificNote { get; set; }
        public string TableName { get; set; }
        public string RefRowPointer { get; set; }
        public bool IsInternalNote { get; set; }
    }
}
