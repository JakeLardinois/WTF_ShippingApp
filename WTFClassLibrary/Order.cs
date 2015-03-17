using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;


namespace WTFClassLibrary
{
    public class Order
    {
        /*This application has 2 different ways of getting order lines; via the Item and via the Order. This is because the application is either Item centric where the order lines need to pertain to the item or
         the application is Order centric where the lines pertain to the order.*/
        public string CustomerOrderNumber { get; set; }
        public string CustomerOrderLine { get; set; }
        public string CustomerPO { get; set; }
        public string CustomerItemNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public int PackingSlipPrintSequence { get; set; }
        public int SelectedAddressNo { get; set; }
        public bool IsBlanketOrder { get; set; }
        public string RowPointer { get; set; }
        public string Notes { get; set; }
        public Order() { }
        public Order(string strOrderNumber)
        {
            SqlCommand objSQLCommand;
            string strSQL;
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
            SqlDataReader objDataReader;
            DateTime dtmTemp;
            double dblTemp;
            int intTemp;


            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            strSQL = QueryDefinitions.GetQuery("SelectTopNOrders", new string[] { "1", "co.co_num", strOrderNumber.Trim(), "co.co_num" });
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objSQLCommand = objSL8_WTF_DataBaseSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            objDataReader = objSQLCommand.ExecuteReader();

            if (objDataReader.HasRows)
            {
                objDataReader.Read();

                CustomerOrderNumber = objDataReader["co_num"].ToString();
                IsBlanketOrder = objDataReader["type"].ToString().ToUpper().Trim().Equals("B") ? true : false;//Types are either B-Blanket, R-Regular or E-?
                CustomerPO = objDataReader["cust_po"].ToString();
                CustomerNumber = objDataReader["cust_num"].ToString();
                CustomerName = objDataReader["name"].ToString();
                OrderDate = DateTime.TryParse(objDataReader["order_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;
                RowPointer = objDataReader["RowPointer"].ToString();
                PackingSlipPrintSequence = double.TryParse(objDataReader["decifld1"].ToString(), out dblTemp) ? (int)dblTemp : 0;
                SelectedAddressNo = int.TryParse(objDataReader["cust_seq"].ToString(), out intTemp) ? intTemp : 0;
                //Notes = this.GetInternalNotes();
            }
            else
                throw new Exception("Order does not exist!");
        }
        public OrderLine SelectedOrderLine { get; set; }
        /*The ShipVia field on the order MUST BE FILLED IN FOR THE ORDER LINES TO SHOW UP. This is because of the join that is done in the query.
         *The Terms field on the order MUST BE FILLED IN FOR THE ORDER LINES TO SHOW UP -- THIS SHOULD BE SPECIFIED ON THE CUSTOMER UNDER THE CREDIT TAB SO THAT IT DEFAULTS ON THE ORDER*/
        public SortableSearchableBindingList<OrderLine> OrderLines {
            get
            {
                SortableSearchableBindingList<OrderLine> objOrderReleaseList = new SortableSearchableBindingList<OrderLine>();
                OrderLine objOrderLine;
                SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
                DataTable objDataTable = new DataTable();
                SqlDataAdapter objDataAdapter;
                SqlCommand objSQLCommand;
                string strSQL;
                int intTemp;
                double dblTemp;
                DateTime dtmTemp;


                strSQL = QueryDefinitions.GetQuery("SelectOrderOrderLines", new string[] { CustomerOrderNumber.Trim() });

                objSL8_WTF_DataBaseSettings.SQLConnection.Open();
                objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
                objDataAdapter = new SqlDataAdapter(objSQLCommand);
                objDataAdapter.Fill(objDataTable);

                foreach (DataRow objRow in objDataTable.Rows)
                {
                    objOrderLine = new OrderLine();

                    objOrderLine.CustomerOrderNumber = objRow["co_num"].ToString();

                    objOrderLine.CustomerNumber = objRow["cust_num"].ToString();

                    objOrderLine.CustomerOrderLine = int.TryParse(objRow["co_line"].ToString(), out intTemp) ? intTemp : 0;

                    objOrderLine.CustomerOrderRelease = int.TryParse(objRow["co_release"].ToString(), out intTemp) ? intTemp : 0;

                    objOrderLine.QtyOrdered = double.TryParse(objRow["qty_ordered"].ToString(), out dblTemp) ? (int)dblTemp : 0;

                    objOrderLine.QtyShipped = double.TryParse(objRow["qty_shipped"].ToString(), out dblTemp) ? (int)dblTemp : 0;

                    objOrderLine.CustomerPO = objRow["cust_po"].ToString();

                    objOrderLine.Salesman = objRow["slsman"].ToString();

                    objOrderLine.ItemID = objRow["item"].ToString();

                    objOrderLine.DrawingNumber = objRow["drawing_nbr"].ToString();

                    objOrderLine.ShippingAppItemNo = objRow["charfld1"].ToString();

                    objOrderLine.ItemDescription = objRow["ItemDescription"].ToString();

                    objOrderLine.ItemRevision = objRow["revision"].ToString();

                    objOrderLine.QtyReady = int.TryParse(objRow["qty_ready"].ToString(), out intTemp) ? intTemp : 0;

                    //objOrderLine.ShipDate = DateTime.TryParse(objRow["ship_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;//I changed this to promise date because shipdate only tells when it was shipped last; need to change this implementation.
                    objOrderLine.PromiseDate = DateTime.TryParse(objRow["promise_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;

                    objOrderLine.DueDate = DateTime.TryParse(objRow["due_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;

                    objOrderLine.CustomerItemNumber = objRow["cust_item"].ToString();

                    objOrderLine.CustomerName = objRow["name"].ToString();

                    objOrderLine.ShipCodeDescription = objRow["ShipCodeDescription"].ToString();

                    objOrderLine.TermsDescription = objRow["TermsDescription"].ToString();

                    objOrderLine.OrderStatus = objRow["OrderStatus"].ToString();

                    objOrderLine.LineOrReleaseStatus = objRow["stat"].ToString();

                    objOrderLine.UnitOfMeasure = objRow["u_m"].ToString();

                    objOrderLine.RowPointer = this.IsBlanketOrder ? objRow["BlanketLineRowPointer"].ToString() : objRow["RegularLineRowPointer"].ToString();

                    objOrderLine.Contact = objRow["contact"].ToString();

                    //objOrderLine.Notes = objOrderLine.GetInternalNotes();

                    objOrderReleaseList.Add(objOrderLine);
                }

                return objOrderReleaseList;
            }
        }
        public bool IncrementPackingSlipSuffix()
        {
            /*I used the command "GRANT UPDATE ON [WTF_App].[dbo].[co] TO WTFApp" to grant the update priveleges
             * "REVOKE UPDATE ON [WTF_App].[dbo].[co] TO WTFApp" is the SQL to remove the privelege.
             * Note that I needed to make a new query in order for a successful execution; each time I tried to use an existing Query, it failed
             */
            SqlCommand objSQLCommand;
            string strSQL;
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;


            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            strSQL = QueryDefinitions.GetQuery("UpdatePackingSlipPrintSequence", new string[] { CustomerOrderNumber.Trim() });
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objSQLCommand = objSL8_WTF_DataBaseSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            if (objSQLCommand.ExecuteNonQuery() == 1)//appropriate row was affected
                return true;
            else
                return false;
        }
        public void SavePackingSlips(List<PackingSlip> objPackingSlips)
        {
            ExtraSytelineTableDb db = new ExtraSytelineTableDb();

            foreach (var objPackingSlip in objPackingSlips)
                db.PackingSlips.Add(new PackingSlip
                {
                    PackingSlipNo = objPackingSlip.PackingSlipNo,
                    OrderLinePrefix = objPackingSlip.OrderLinePrefix,
                    CustomerOrderNumber = objPackingSlip.CustomerOrderNumber,
                    OrderNotes = objPackingSlip.OrderNotes,
                    CustomerAddress = objPackingSlip.CustomerAddress,
                    CustomerNumber = objPackingSlip.CustomerNumber,
                    CustomerOrderSuffix = objPackingSlip.CustomerOrderSuffix,
                    ActualShipDate = objPackingSlip.ActualShipDate,
                    GrossWeight = objPackingSlip.GrossWeight,
                    NoOfCartons = objPackingSlip.NoOfCartons,
                    NoOfPallets = objPackingSlip.NoOfPallets,
                    JobNumber = objPackingSlip.JobNumber,
                    PrintDate = objPackingSlip.PrintDate,
                    CustomerOrderLine = objPackingSlip.CustomerOrderLine,
                    CustomerOrderRelease = objPackingSlip.CustomerOrderRelease,
                    PromiseDate = objPackingSlip.PromiseDate,
                    ItemID = objPackingSlip.ItemID,
                    ItemDescription = objPackingSlip.ItemDescription,
                    QtyOrdered = objPackingSlip.QtyOrdered,
                    QtyShipped = objPackingSlip.QtyShipped,
                    QtyBackOrdered = objPackingSlip.QtyBackOrdered,
                    Revision = objPackingSlip.Revision,
                    CustomerPO = objPackingSlip.CustomerPO
                });

            db.SaveChanges();
        }
    }
}
