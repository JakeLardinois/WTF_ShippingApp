﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace WTFClassLibrary
{
    public class ItemHistoryTransaction
    {
        public int RecievedItemID { get; set; }
        public string Job { get; set; }
        public int Suffix { get; set; }
        public string FormattedJobNumber
        {
            get
            {
                int intTemp;
                foreach (var strPrefix in Settings.JobPrefixes)
                    if (Job.StartsWith(strPrefix))
                    {
                        //return int.TryParse(JobNumber.ToUpper().Replace(strPrefix, string.Empty), out intTemp) ? strPrefix + intTemp.ToString().PadLeft(9, '0') : string.Empty;

                        Regex objRegex = new Regex("^(" + strPrefix + ")", RegexOptions.IgnoreCase);
                        return int.TryParse(objRegex.Replace(Job, string.Empty), out intTemp) ? strPrefix + intTemp.ToString().PadLeft(10 - strPrefix.Length, '0') : string.Empty;
                    }

                return Job;
                //return int.TryParse(Job.ToUpper().Replace("B", string.Empty), out intTemp) ? "B" + intTemp.ToString().PadLeft(9, '0') : string.Empty;
            }
        }
        public string ItemID { get; set; }
        public int Quantity { get; set; }
        public string RecievedTimeStamp { get; set; }
        public string Operator { get; set; }
        public double GrossWeight { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string ShippedTimeStamp{ get; set; }
        public int LabelSequence { get; set; }
        public int PalletCount { get; set; }
        public bool isSelected { get; set; }
        //public bool Shipped {
        //    get
        //    {
        //        return !string.IsNullOrEmpty(ShippedTimeStamp);
        //    }
        //    set { } 
        //}
    }
}
