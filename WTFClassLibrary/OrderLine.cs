using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTFClassLibrary
{
    public class OrderLine
    {
        public string CustomerOrderNumber { get; set; }
        public string CustomerNumber { get; set; }
        public int CustomerOrderLine { get; set; }
        public int CustomerOrderRelease { get; set; }
        public int QtyOrdered { get; set; }
        public int QtyShipped { get; set; }
        public int QtyBackOrdered { get; set; }
        public string CustomerPO { get; set; }
        public string Salesman { get; set; }
        public string ItemID { get; set; }
        public string DrawingNumber { get; set; }
        public string ShippingAppItemNo { get; set; }
        public string ItemDescription { get; set; }
        public string ItemRevision { get; set; }
        public int QtyReady { get; set; }
        //public DateTime ShipDate { get; set; }//This value references the last date that product shipped.
        public DateTime PromiseDate { get; set; }
        public DateTime DueDate { get; set; }
        public string CustomerItemNumber { get; set; }
        public string CustomerName { get; set; }
        public string Contact { get; set; }
        public string ShipCodeDescription { get; set; }
        public string TermsDescription { get; set; }
        public string OrderStatus { get; set; }
        public string LineOrReleaseStatus { get; set; }
        public string UnitOfMeasure { get; set; }
        public string RowPointer { get; set; }
        public string Notes { get; set; }
    }
}
