using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Data.SqlClient;
using System.ComponentModel;
using System.Data.SqlTypes;

using System.Text.RegularExpressions;


namespace WTFClassLibrary
{
    public class Item
    {
        public string ItemID { get; set; }
        public string CustomerItem { get; set; }
        public string Description { get; set; }
        public Single PieceWgt { get; set; }
        public bool IsSubItem { get; set; }//Changed property from IsMFG to IsSubItem to better describe properties use
        public int UnitWeightHistoryCount { get { return mUnitWeightHistoryCount; } }
        private int mUnitWeightHistoryCount;
        public int MaxUnitWeightHistoryCount { get; set; }
        //public bool HasBlanketOrder { get; set; }
        public string CustomerOrderNumber { get; set; }
        public double QtyOnHand { get; set; }
        public string DrawingNumber { get; set; }
        public string ShippingAppItemNo { get; set; }
        public bool SearchFilledOrders { get; set; }
        public bool IsPulledFromInventory { get; set; }
        public long LabelSequence { get; set; }
        public string Revision { get; set; }
        public int AvailableInventory
        {
            get
            {
                SqlCommand objSQLCommand;
                ExtraSytelineTablesSettings objExtraSytelineTableSettings;
                SqlDataReader objDataReader;
                string strSQL;


                objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
                strSQL = QueryDefinitions.GetQuery("SelectItemAccumulatorAvailableInventory", new string[] { ItemID });

                objExtraSytelineTableSettings.SQLConnection.Open();
                objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
                objSQLCommand.CommandText = strSQL;

                objDataReader = objSQLCommand.ExecuteReader();

                if (objDataReader.Read())
                    return int.Parse(objDataReader[0].ToString());
                else
                    return 0;
            }
        }
        public string LastReceiveDate
        {
            get
            {
                SqlCommand objSQLCommand;
                ExtraSytelineTablesSettings objExtraSytelineTableSettings;
                SqlDataReader objDataReader;
                string strSQL;


                objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
                strSQL = QueryDefinitions.GetQuery("SelectLastRecievedItemHistoryDate", new string[] { ItemID });

                objExtraSytelineTableSettings.SQLConnection.Open();
                objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
                objSQLCommand.CommandText = strSQL;

                objDataReader = objSQLCommand.ExecuteReader();

                if (objDataReader.Read())
                    return string.Format("{0:MM/dd/yyyy hh:mm:ss tt}", objDataReader[0]);
                else
                    return string.Empty;
            }
        }
        public string LastShipDate
        {
            get
            {
                SqlCommand objSQLCommand;
                ExtraSytelineTablesSettings objExtraSytelineTableSettings;
                SqlDataReader objDataReader;
                string strSQL;


                objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
                strSQL = QueryDefinitions.GetQuery("SelectLastShippedItemHistoryDate", new string[] { ItemID });

                objExtraSytelineTableSettings.SQLConnection.Open();
                objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
                objSQLCommand.CommandText = strSQL;

                objDataReader = objSQLCommand.ExecuteReader();

                if (objDataReader.Read())
                    return string.Format("{0:MM/dd/yyyy hh:mm:ss tt}", objDataReader[0]);
                else
                    return string.Empty;
            }
        }
        public Order SelectedOrder { get; set; }
        public SortableSearchableBindingList<Order> Orders
        {
            get
            {
                SortableSearchableBindingList<Order> objOrderList = new SortableSearchableBindingList<Order>();
                Order objOrder;
                SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
                DataTable objDataTable = new DataTable();
                SqlDataAdapter objDataAdapter;
                SqlCommand objSQLCommand;
                string strSQL;
                DateTime dtmTemp;
                int intTemp;
                double dblTemp;
                Match objMFGMatch, objDashIntMatch;


                objMFGMatch = Regex.Match(ItemID, @"-MFG\Z", RegexOptions.IgnoreCase);
                objDashIntMatch = Regex.Match(ItemID, @"-[0-9]\Z", RegexOptions.IgnoreCase);
                if (SearchFilledOrders)
                {
                    if (IsSubItem)
                    {
                        //strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrdersFilled", new string[] { ItemID.ToUpper().Replace("-MFG", "") });
                        if (objMFGMatch.Success)//I implemented this so that I could also use the isMFG functionality to get orders for a -1, -2, etc. item
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrdersFilled", new string[] { ItemID.Replace(objMFGMatch.Value, "") });
                        else if (objDashIntMatch.Success)
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrdersFilled", new string[] { ItemID.Replace(objDashIntMatch.Value, "") });
                        else
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrdersFilled", new string[] { CustomerItem });//this is for the scenario where we have a sub item that isn't an mfg or dash item
                            //strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrdersFilled", new string[] { ItemID });//like where a part is painted 2 different colors and we need to tie the item to an order.
                    }
                    else
                    {
                        strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrdersFilled", new string[] { ItemID });
                    }
                }
                else
                {
                    if (IsSubItem)
                    {
                        //strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrders", new string[] { ItemID.ToUpper().Replace("-MFG", "") });
                        if (objMFGMatch.Success)
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrders", new string[] { ItemID.Replace(objMFGMatch.Value, "") });
                        else if (objDashIntMatch.Success)
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrders", new string[] { ItemID.Replace(objDashIntMatch.Value, "") });
                        else
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrders", new string[] { ItemID });
                    }
                    else
                    {
                        strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrders", new string[] { ItemID });
                    }
                }

                objSL8_WTF_DataBaseSettings.SQLConnection.Open();
                objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
                objDataAdapter = new SqlDataAdapter(objSQLCommand);
                objDataAdapter.Fill(objDataTable);

                foreach (DataRow objRow in objDataTable.Rows)
                {
                    objOrder = new Order();

                    objOrder.CustomerOrderNumber = objRow["co_num"].ToString();

                    objOrder.IsBlanketOrder = objRow["type"].ToString().ToUpper().Trim().Equals("B") ? true : false;//Types are either B-Blanket, R-Regular or E-?

                    objOrder.CustomerOrderLine = objRow["co_line"].ToString();

                    objOrder.CustomerPO = objRow["cust_po"].ToString();

                    objOrder.CustomerItemNumber = objRow["cust_item"].ToString();

                    objOrder.CustomerNumber = objRow["cust_num"].ToString();

                    objOrder.CustomerName = objRow["name"].ToString();

                    objOrder.OrderDate = DateTime.TryParse(objRow["order_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;

                    objOrder.SelectedAddressNo = int.TryParse(objRow["cust_seq"].ToString(), out intTemp) ? intTemp : 0;

                    objOrder.PackingSlipPrintSequence = double.TryParse(objRow["decifld1"].ToString(), out dblTemp) ? (int)dblTemp : 0;

                    objOrderList.Add(objOrder);
                }

                return objOrderList;
            }

        }
        public OrderLine SelectedOrderLine { get; set; }
        public SortableSearchableBindingList<OrderLine> OrderLines
        {
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
                Match objMFGMatch, objDashIntMatch;


                objMFGMatch = Regex.Match(ItemID, @"-MFG\Z", RegexOptions.IgnoreCase);
                objDashIntMatch = Regex.Match(ItemID, @"-[0-9]\Z", RegexOptions.IgnoreCase);
                if (SearchFilledOrders)
                {
                    if (IsSubItem)
                    {
                        //strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrderLinesFilled", new string[] { ItemID.ToUpper().Replace("-MFG", ""), CustomerOrderNumber.Trim() });
                        if (objMFGMatch.Success)//I implemented this so that I could also use the isMFG functionality to get order lines for a -1, -2, etc. item
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrderLinesFilled", new string[] { ItemID.Replace(objMFGMatch.Value, ""), CustomerOrderNumber.Trim() });
                        else if (objDashIntMatch.Success)
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrderLinesFilled", new string[] { ItemID.Replace(objDashIntMatch.Value, ""), CustomerOrderNumber.Trim() });
                        else
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrderLinesFilled", new string[] { ItemID, CustomerOrderNumber.Trim() });
                    }
                    else
                    {
                        strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrderLinesFilled", new string[] { ItemID, CustomerOrderNumber.Trim() });
                    }
                }
                else
                {
                    if (IsSubItem)
                    {
                        //strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrderLines", new string[] { ItemID.ToUpper().Replace("-MFG", ""), CustomerOrderNumber.Trim() });
                        if (objMFGMatch.Success)
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrderLines", new string[] { ItemID.Replace(objMFGMatch.Value, ""), CustomerOrderNumber.Trim() });
                        else if (objDashIntMatch.Success)
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrderLines", new string[] { ItemID.Replace(objDashIntMatch.Value, ""), CustomerOrderNumber.Trim() });
                        else
                            strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrderLines", new string[] { ItemID, CustomerOrderNumber.Trim() });
                    }
                    else
                    {
                        strSQL = QueryDefinitions.GetQuery("SelectMFGItemOrderLines", new string[] { ItemID, CustomerOrderNumber.Trim() });
                    }
                }

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

                    objOrderLine.QtyReady = double.TryParse(objRow["qty_ready"].ToString(), out dblTemp) ? (int)dblTemp : 0;

                    //objOrderLine.ShipDate = DateTime.TryParse(objRow["ship_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;
                    objOrderLine.PromiseDate = DateTime.TryParse(objRow["promise_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;

                    objOrderLine.DueDate = DateTime.TryParse(objRow["due_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;

                    objOrderLine.CustomerItemNumber = objRow["cust_item"].ToString();

                    objOrderLine.CustomerName = objRow["name"].ToString();

                    objOrderLine.ShipCodeDescription = objRow["ShipCodeDescription"].ToString();

                    objOrderLine.TermsDescription = objRow["TermsDescription"].ToString();

                    objOrderLine.OrderStatus = objRow["OrderStatus"].ToString();//***

                    objOrderLine.LineOrReleaseStatus = objRow["stat"].ToString();//***

                    objOrderReleaseList.Add(objOrderLine);
                }

                return objOrderReleaseList;
            }
        }
        public Job SelectedJob { get; set; }
        public Job SpecifiedJob { get; set; }
        public SortableSearchableBindingList<Job> Jobs
        {
            get
            {
                SortableSearchableBindingList<Job> objJobList = new SortableSearchableBindingList<Job>();
                DataTable objDataTable = new DataTable();
                SqlDataAdapter objDataAdapter;
                SqlCommand objSQLCommand;
                Job objJob;
                string strSQL;
                int intTemp;
                double dblTemp;
                //DateTime dtmTemp;

                SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;

                objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
                strSQL = QueryDefinitions.GetQuery("SelectMFGItemJobs", new string[] { ItemID });
                objSL8_WTF_DataBaseSettings.SQLConnection.Open();
                objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
                objDataAdapter = new SqlDataAdapter(objSQLCommand);
                objDataAdapter.Fill(objDataTable);

                //MODIFIED by JakeL on 8-26-2014
                if (objDataTable.Rows.Count == 0)
                {
                    var objStrBldr = new StringBuilder();
                    var objHistoryJobList = this.JobsInInventory;

                    foreach (var objHistoryJob in objHistoryJobList)//looks in job history for a job list in case the job was closed before 
                        objStrBldr.Append("'" + objHistoryJob.JobNumber + "', ");

                    if (SpecifiedJob != null)//Modified 4/21/2015- allows the user to specify a specific job 
                        objStrBldr.Clear().Append("'" + SpecifiedJob.JobNumber + "', ");

                    strSQL = QueryDefinitions.GetQuery("SelectMFGItemJobsByJobList", new string[] { ItemID, objStrBldr.ToString().Remove(objStrBldr.Length - 2) });
                    //objSL8_WTF_DataBaseSettings.SQLConnection.Open();
                    objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
                    objDataAdapter = new SqlDataAdapter(objSQLCommand);
                    objDataAdapter.Fill(objDataTable);
                }

                QtyOnHand = double.TryParse(objDataTable.Rows[0]["qty_on_hand"].ToString(), out dblTemp) ? dblTemp : 0.0;

                DrawingNumber = objDataTable.Rows[0]["drawing_nbr"].ToString();

                ShippingAppItemNo = objDataTable.Rows[0]["charfld1"].ToString();

                foreach (DataRow objRow in objDataTable.Rows)
                {
                    objJob = new Job();

                    objJob.JobNumber = objRow["job"].ToString();

                    objJob.Suffix = int.TryParse(objRow["suffix"].ToString(), out intTemp) ? intTemp : 0;

                    objJob.QtyReleased = double.TryParse(objRow["qty_released"].ToString(), out dblTemp) ? dblTemp : 0.0;

                    objJob.QtyComplete = double.TryParse(objRow["qty_complete"].ToString(), out dblTemp) ? dblTemp : 0.0;

                    objJob.ItemDescription = objRow["description"].ToString();

                    objJob.UnitOfMeasure = objRow["u_m"].ToString();

                    objJob.JobOrderRelease = int.TryParse(objRow["ord_release"].ToString(), out intTemp) ? intTemp : 0;

                    objJob.JobOrderNumber = objRow["ord_num"].ToString();

                    objJobList.Add(objJob);
                }
                
                //if (IsMFG)
                //{
                //    SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;

                //    objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
                //    strSQL = QueryDefinitions.GetQuery("SelectMFGItemJobs", new string[] { ItemID });
                //    objSL8_WTF_DataBaseSettings.SQLConnection.Open();
                //    objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
                //    objDataAdapter = new SqlDataAdapter(objSQLCommand);
                //    objDataAdapter.Fill(objDataTable);

                //    QtyOnHand = double.TryParse(objDataTable.Rows[0]["qty_on_hand"].ToString(), out dblTemp) ? dblTemp : 0.0;

                //    DrawingNumber = objDataTable.Rows[0]["drawing_nbr"].ToString();

                //    foreach (DataRow objRow in objDataTable.Rows)
                //    {
                //        objJob = new Job();

                //        objJob.JobNumber = objRow["job"].ToString();

                //        objJob.QtyReleased = double.TryParse(objRow["qty_released"].ToString(), out dblTemp) ? dblTemp : 0.0;

                //        objJob.QtyComplete = double.TryParse(objRow["qty_complete"].ToString(), out dblTemp) ? dblTemp : 0.0;

                //        objJob.ItemDescription = objRow["description"].ToString();

                //        objJob.UnitOfMeasure = objRow["u_m"].ToString();

                //        objJob.JobOrderRelease = int.TryParse(objRow["ord_release"].ToString(), out intTemp) ? intTemp : 0;

                //        objJob.JobOrderNumber = objRow["ord_num"].ToString();

                //        objJobList.Add(objJob);
                //    }
                //}
                ////else if (HasBlanketOrder)//This references SelectItemBlanketJobs which would not ever be used
                ////{
                ////    SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;

                ////    objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
                ////    strSQL = QueryDefinitions.GetQuery("SelectItemBlanketJobs", new string[] { ItemID, CustomerOrderNumber.Trim() });
                ////    objSL8_WTF_DataBaseSettings.SQLConnection.Open();
                ////    objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
                ////    objDataAdapter = new SqlDataAdapter(objSQLCommand);
                ////    objDataAdapter.Fill(objDataTable);


                ////    QtyOnHand = double.TryParse(objDataTable.Rows[0]["qty_on_hand"].ToString(), out dblTemp) ? dblTemp : 0.0;

                ////    DrawingNumber = objDataTable.Rows[0]["drawing_nbr"].ToString();

                ////    CustomerItem = objDataTable.Rows[0]["cust_item"].ToString();

                ////    foreach (DataRow objRow in objDataTable.Rows)
                ////    {
                ////        objJob = new Job();

                ////        objJob.JobNumber = objRow["job"].ToString();

                ////        objJob.CustomerOrderNumber = objRow["co_num"].ToString();

                ////        objJob.CustomerOrderRelease = int.TryParse(objRow["co_release"].ToString(), out intTemp) ? intTemp : 0;

                ////        objJob.QtyReleased = double.TryParse(objRow["qty_released"].ToString(), out dblTemp) ? dblTemp : 0.0;

                ////        objJob.QtyComplete = double.TryParse(objRow["qty_complete"].ToString(), out dblTemp) ? dblTemp : 0.0;

                ////        objJob.ItemDescription = objRow["description"].ToString();

                ////        objJob.UnitOfMeasure = objRow["u_m"].ToString();

                ////        objJob.CustomerPO = objRow["cust_po"].ToString();

                ////        objJob.JobOrderRelease = int.TryParse(objRow["ord_release"].ToString(), out intTemp) ? intTemp : 0;

                ////        objJob.JobOrderNumber = objRow["ord_num"].ToString();

                ////        objJob.CustomerName = objRow["name"].ToString();

                ////        objJob.CustomerNumber = objRow["cust_num"].ToString();

                ////        objJob.ShipCodeDescription = objRow["ShipCodeDescription"].ToString();

                ////        objJob.Terms = objRow["Terms"].ToString();

                ////        objJob.DueDate = DateTime.TryParse(objRow["due_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;

                ////        objJobList.Add(objJob);
                ////    }
                ////}
                //else
                //{
                //    SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;

                //    objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
                //    strSQL = QueryDefinitions.GetQuery("SelectItemJobs", new string[] { ItemID });
                //    objSL8_WTF_DataBaseSettings.SQLConnection.Open();
                //    objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
                //    objDataAdapter = new SqlDataAdapter(objSQLCommand);
                //    objDataAdapter.Fill(objDataTable);


                //    QtyOnHand = double.TryParse(objDataTable.Rows[0]["qty_on_hand"].ToString(), out dblTemp) ? dblTemp : 0.0;

                //    DrawingNumber = objDataTable.Rows[0]["drawing_nbr"].ToString();

                //    CustomerItem = objDataTable.Rows[0]["cust_item"].ToString();

                //    foreach (DataRow objRow in objDataTable.Rows)
                //    {
                //        objJob = new Job();

                //        objJob.JobNumber = objRow["job"].ToString();

                //        objJob.JobOrderNumber = objRow["ord_num"].ToString();

                //        objJob.CustomerOrderNumber = objRow["co_num"].ToString();

                //        objJob.CustomerOrderLine = int.TryParse(objRow["co_line"].ToString(), out intTemp) ? intTemp : 0;

                //        objJob.CustomerOrderRelease = int.TryParse(objRow["co_release"].ToString(), out intTemp) ? intTemp : 0;

                //        objJob.QtyReleased = double.TryParse(objRow["qty_released"].ToString(), out dblTemp) ? dblTemp : 0.0;

                //        objJob.QtyOrdered = double.TryParse(objRow["qty_ordered"].ToString(), out dblTemp) ? dblTemp : 0.0;

                //        objJob.QtyShipped = double.TryParse(objRow["qty_shipped"].ToString(), out dblTemp) ? dblTemp : 0.0;

                //        objJob.QtyReady = double.TryParse(objRow["qty_ready"].ToString(), out dblTemp) ? dblTemp : 0.0;

                //        objJob.CustomerPO = objRow["cust_po"].ToString();

                //        objJob.ShipDate = DateTime.TryParse(objRow["ship_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;

                //        objJob.DueDate = DateTime.TryParse(objRow["due_date"].ToString(), out dtmTemp) ? dtmTemp : DateTime.MinValue;

                //        objJob.CustomerName = objRow["name"].ToString();

                //        objJob.ShipCodeDescription = objRow["ShipCodeDescription"].ToString();

                //        objJob.Terms = objRow["Terms"].ToString();

                //        objJob.Salesman = objRow["slsman"].ToString();

                //        objJob.ItemDescription = objRow["description"].ToString();

                //        objJob.Revision = objRow["revision"].ToString();

                //        objJob.CustomerNumber = objRow["cust_num"].ToString();

                //        objJobList.Add(objJob);
                //    }
                //}
                return objJobList;
            }

        }
        public List<ItemHistoryTransaction> SelectedHistoryTransactions { get; set; }
        public SortableSearchableBindingList<ItemHistoryTransaction> GetHistory(ItemHistoryView enuItemHistoryView, string strJobNo = null, int intSuffix = 0)
        {
            SortableSearchableBindingList<ItemHistoryTransaction> objItemHistoryList = new SortableSearchableBindingList<ItemHistoryTransaction>();
            ItemHistoryTransaction objItemHistoryTransaction;
            SqlCommand objSQLCommand;
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            SqlDataReader objDataReader;
            string strSQL;
            string strJobParameter;


            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();

            if (strJobNo != null)
                strJobParameter = " AND job = '" + strJobNo + "' AND suffix = " + intSuffix.ToString();
            else
                strJobParameter = string.Empty;

            switch (enuItemHistoryView)
            {
                case ItemHistoryView.All:
                    strSQL = QueryDefinitions.GetQuery("SelectAllItemHistory", new string[] { ItemID, strJobParameter });
                    break;
                case ItemHistoryView.Shipped:
                    strSQL = QueryDefinitions.GetQuery("SelectShippedItemHistory", new string[] { ItemID, strJobParameter });
                    break;
                case ItemHistoryView.Recieved:
                    strSQL = QueryDefinitions.GetQuery("SelectRecievedItemHistory", new string[] { ItemID, strJobParameter });
                    break;
                default:
                    strSQL = string.Empty;
                    break;
            }

            
            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            objDataReader = objSQLCommand.ExecuteReader();

            while (objDataReader.Read())
            {
                objItemHistoryTransaction = new ItemHistoryTransaction();

                objItemHistoryTransaction.LabelSequence = int.Parse(objDataReader["LabelSequence"].ToString());
                objItemHistoryTransaction.ItemID = objDataReader["item"].ToString();
                objItemHistoryTransaction.Job = objDataReader["job"].ToString();
                objItemHistoryTransaction.CustomerOrderNumber = objDataReader["co"].ToString();
                objItemHistoryTransaction.Quantity = int.Parse(objDataReader["Quantity"].ToString());
                objItemHistoryTransaction.RecievedTimeStamp = string.Format("{0:MM/dd/yyyy hh:mm:ss tt}", objDataReader["ReceivedTimestamp"]);
                objItemHistoryTransaction.ShippedTimeStamp = string.Format("{0:MM/dd/yyyy hh:mm:ss tt}", objDataReader["ShippedTimestamp"]);
                objItemHistoryTransaction.Operator = objDataReader["operator"].ToString();
                objItemHistoryTransaction.GrossWeight = double.Parse(objDataReader["GrossWgt"].ToString());
                objItemHistoryTransaction.PalletCount = int.Parse(objDataReader["PalletCt"].ToString());
                objItemHistoryTransaction.RecievedItemID = int.Parse(objDataReader["ReceivedItemID"].ToString());
                objItemHistoryTransaction.Suffix = int.Parse(objDataReader["suffix"].ToString());

                objItemHistoryList.Add(objItemHistoryTransaction);
            }

            return objItemHistoryList;
        }
        public ItemHistoryJob SelectedItemHistoryJob { get; set; }//needed this property to get the total available quantity in frmShipItem
        public SortableSearchableBindingList<ItemHistoryJob> JobsInInventory
        {
            get
            {
                SortableSearchableBindingList<ItemHistoryJob> objItemHistoryJobList = new SortableSearchableBindingList<ItemHistoryJob>();
                DataTable objDataTable = new DataTable();
                SqlDataAdapter objDataAdapter;
                SqlCommand objSQLCommand;
                ItemHistoryJob objItemHistoryJob;
                string strSQL;
                int intTemp;
                ExtraSytelineTablesSettings objExtraSytelineTableSettings;


                objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
                strSQL = QueryDefinitions.GetQuery("SelectItemJobsFromInventory", new string[] { ItemID, "> 0" });//only get the jobs with qty > 0
                objExtraSytelineTableSettings.SQLConnection.Open();
                objSQLCommand = new SqlCommand(strSQL, objExtraSytelineTableSettings.SQLConnection);
                objDataAdapter = new SqlDataAdapter(objSQLCommand);
                objDataAdapter.Fill(objDataTable);

                foreach (DataRow objRow in objDataTable.Rows)
                {
                    objItemHistoryJob = new ItemHistoryJob();

                    objItemHistoryJob.JobNumber = objRow["job"].ToString();

                    objItemHistoryJob.JobOrderNumber = objRow["JobOrderNumber"].ToString();

                    objItemHistoryJob.TotalQuantity = int.TryParse(objRow["TotalQuantity"].ToString(), out intTemp) ? intTemp : 0;

                    objItemHistoryJob.LastUpdate = string.Format("{0:MM/dd/yyyy hh:mm:ss tt}", objRow["LastUpdate"].ToString());

                    objItemHistoryJob.ReceivedItemAccumulatorID = int.TryParse(objRow["ReceivedItemAccumulatorID"].ToString(), out intTemp) ? intTemp : 0;

                    objItemHistoryJob.Suffix = int.TryParse(objRow["suffix"].ToString(), out intTemp) ? intTemp : 0;

                    objItemHistoryJobList.Add(objItemHistoryJob);
                }

                return objItemHistoryJobList;
            }
        }
        public Item() { }
        public Item(string strItemNo)
        {
            SqlCommand objSQLCommand;
            string strSQL;
            double dblTemp;
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
            SqlDataReader objDataReader;
            Match objMFGMatch, objDashIntMatch;


            objMFGMatch = Regex.Match(strItemNo, @"-MFG\Z", RegexOptions.IgnoreCase);
            objDashIntMatch = Regex.Match(strItemNo, @"-[0-9]\Z", RegexOptions.IgnoreCase);

            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            strSQL = QueryDefinitions.GetQuery("SelectTopNItems", new string[] { "1", "item.item", strItemNo, "item.item" });
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objSQLCommand = objSL8_WTF_DataBaseSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            objDataReader = objSQLCommand.ExecuteReader();

            if (objDataReader.HasRows)
            {
                objDataReader.Read();

                ItemID = objDataReader["Item"].ToString();
                Description = objDataReader["Description"].ToString();
                Revision = objDataReader["revision"].ToString();
                QtyOnHand = double.TryParse(objDataReader["qty_on_hand"].ToString(), out dblTemp) ? dblTemp : 0.0;
                //CustomerItem = objDataReader["drawing_nbr"].ToString();  
                CustomerItem = objDataReader["charfld1"].ToString(); 

                //IsMFG = ItemID.ToUpper().EndsWith("MFG");
                IsSubItem = objMFGMatch.Success || objDashIntMatch.Success;//Implemented so isMFG functionality could be utilized for -1, -2, etc items
                SetAvgUnitWeight();
                try
                {
                    MaxUnitWeightHistoryCount = Settings.GetMaxItemPieceUnitWeightHistoryCount();
                }
                catch
                {
                    throw new Exception("Unable to get ItemPieceWeightHistoryCount from the Settings Table.");
                }
                
            }
            else
                throw new Exception("Item does not exist!");
            

            //SL8WebServiceSettings objSL8WebServiceSettings;
            //DataSet objDataSet;


            //ValidateItemNo(strItemNo);

            //objSL8WebServiceSettings = new SL8WebServiceSettings();
            //objDataSet = objSL8WebServiceSettings.WebService.LoadDataSet(objSL8WebServiceSettings.SessionToken, "SL.SLItems", "Item, Description", "Item LIKE '" + strItemNo + "'", "Item", string.Empty, 1);

            //if (objDataSet.Tables[0].Rows.Count > 0)
            //{
            //    ItemID = objDataSet.Tables[0].Rows[0]["Item"].ToString();
            //    Description = objDataSet.Tables[0].Rows[0]["Description"].ToString();
            //    IsMFG = ItemID.ToUpper().EndsWith("MFG");
            //    SetAvgUnitWeight();
            //    MaxUnitWeightHistoryCount = 5;
            //}
            //else
            //    throw new Exception("Item does not exist!");

        }
        public void UpdateAvgUnitWeightHistory(Single sngUnitWeight, int intQuantity)
        {
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            SqlCommand objSQLCommand;
            string strSQL;


            //if (sngUnitWeight <= 0.0)
            //    throw new Exception("Unit Weight cannot be < or = to 0.0");
            //if (intQuantity <= 0)
            //    throw new Exception("Quantity cannot be < or = to 0.0");

            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery("DeleteOldestItemUnitWeightHistory", new string[] { ItemID });
            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = new SqlCommand(strSQL, objExtraSytelineTableSettings.SQLConnection);
            for (int intCounter = UnitWeightHistoryCount - MaxUnitWeightHistoryCount; intCounter >= 0; --intCounter)
                objSQLCommand.ExecuteNonQuery();

            strSQL = QueryDefinitions.GetQuery("InsertNewItemUnitWeightHistory", new string[] { ItemID, sngUnitWeight.ToString(), intQuantity.ToString() });
            objSQLCommand = new SqlCommand(strSQL, objExtraSytelineTableSettings.SQLConnection);
            objSQLCommand.ExecuteNonQuery();

            objExtraSytelineTableSettings.SQLConnection.Close();
            SetAvgUnitWeight();
        }
        public bool Recieve(int intQuantity, string strOperator)
        {
            SqlCommand objSQLCommand;
            string strSQL;
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            SqlDataReader objDataReader;


            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery("SelectRecievedAccumulatorID", new string[] { ItemID, SelectedJob.JobNumber, SelectedJob.Suffix.ToString() });
            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            objDataReader = objSQLCommand.ExecuteReader();

            if (objDataReader.Read())
                strSQL = QueryDefinitions.GetQuery("UpdateRecievedItemAccumulator",
                    new string[] { "+ " + intQuantity, DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"), SelectedJob.JobOrderNumber, objDataReader["ReceivedItemAccumulatorID"].ToString() });
            else
                strSQL = QueryDefinitions.GetQuery("InsertIntoRecievedItemAccumulator",
                    new string[] { ItemID, SelectedJob.JobNumber, SelectedJob.JobOrderNumber, intQuantity.ToString(), SelectedJob.Suffix.ToString() });
            
            objDataReader.Close();
            objSQLCommand.CommandText = strSQL;
            if (objSQLCommand.ExecuteNonQuery() == 1)//the appropriate row was affected
                return true;
            else
                return false;

        }
        public bool AddToReceiveHistory(BillOfLading objBOL, string strOperator)
        {
            return AddToReceiveHistory(objBOL.Quantity, strOperator, objBOL.GrossWeight, objBOL.PalletCount);
        }
        public bool AddToReceiveHistory(int intQuantity, string strOperator, double dblGrossWeight, int intPalletCount)
        {
            SqlCommand objSQLCommand;
            string strSQL;
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;


            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery("InsertIntoRecievedItemHistory", new string[] { SelectedJob.JobNumber, ItemID, intQuantity.ToString(), 
                strOperator, dblGrossWeight.ToString(), LabelSequence.ToString(), SelectedOrder.CustomerOrderNumber, intPalletCount.ToString(), SelectedJob.Suffix.ToString() });
            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            if (objSQLCommand.ExecuteNonQuery() == 1) //appropriate row was affected
                return true;
            else
                return false;
        }
        public static bool ShipItem(int intRecieveditemID)
        {
            SqlCommand objSQLCommand;
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            string strSQL;


            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery("UpdateRecievedItemHistory", new string[] { DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"), intRecieveditemID.ToString() });

            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            if (objSQLCommand.ExecuteNonQuery() == 1)
                return true;
            else
                throw new Exception("Unable to update RecievedItemHistory ID " + intRecieveditemID);
        }
        public static bool ShipItemFromInventory(ItemHistoryTransaction objItemHistoryTransaction)
        {
            SqlCommand objSQLCommand;
            string strSQL;
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            SqlDataReader objDataReader;

            if (!string.IsNullOrEmpty(objItemHistoryTransaction.ShippedTimeStamp))
                throw new Exception("History Transaction " + objItemHistoryTransaction.RecievedItemID + " was already shipped on " + objItemHistoryTransaction.ShippedTimeStamp);

            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery("SelectRecievedAccumulatorID", new string[] { objItemHistoryTransaction.ItemID, objItemHistoryTransaction.Job, objItemHistoryTransaction.Suffix.ToString() });
            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            objDataReader = objSQLCommand.ExecuteReader();

            if (objDataReader.Read())
                strSQL = QueryDefinitions.GetQuery("UpdateRecievedItemAccumulator",//fix this
                    new string[] { "- " + objItemHistoryTransaction.Quantity, DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"), objDataReader["JobOrderNumber"].ToString(), objDataReader["ReceivedItemAccumulatorID"].ToString() });
            else
                throw new Exception("No accumulator record found for job " + objItemHistoryTransaction.Job);

            objDataReader.Close();
            objSQLCommand.CommandText = strSQL;
            if (objSQLCommand.ExecuteNonQuery() == 1)//the appropriate row was affected
                return ShipItem(objItemHistoryTransaction.RecievedItemID);
            else
                throw new Exception("Unable to update accumulator record for job " + objItemHistoryTransaction.Job);
        }
        private void ValidateItemNo(string strItemNo)
        {
            char[] arrchrInvalidChars = new char[] {'\\', '\'', '*', '%'};


            if (strItemNo.Trim().Length == 0)
                throw new Exception("No Item has been entered!");

            foreach (char chrTemp in arrchrInvalidChars)
                if (strItemNo.Contains(chrTemp))
                    throw new Exception("The Item contains invalid characters!");
        }
        public void SetAvgUnitWeight()
        {
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            SqlCommand objSQLCommand;
            SqlDataReader objReader;
            Single sngTemp = 0.0F;
            int intTemp = 0;
            string strSQL;


            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery("GetItemAvgUnitWeightAndCount", new string[] { ItemID });

            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = new SqlCommand(strSQL, objExtraSytelineTableSettings.SQLConnection);

            objReader = objSQLCommand.ExecuteReader();
            objReader.Read();

            Single.TryParse(objReader[0].ToString(), out sngTemp);
            PieceWgt = sngTemp;

            int.TryParse(objReader[1].ToString(), out intTemp);
            mUnitWeightHistoryCount = intTemp;

            objExtraSytelineTableSettings.SQLConnection.Close();
        }
        public SortableSearchableBindingList<StockLocation> ItemStockroomLocations
        {
            get
            {
                SortableSearchableBindingList<StockLocation> objStockLocationList = new SortableSearchableBindingList<StockLocation>();
                StockLocation objStockLocation;
                SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
                DataTable objDataTable = new DataTable();
                SqlDataAdapter objDataAdapter;
                SqlCommand objSQLCommand;
                string strSQL;
                int intTemp;


                strSQL = QueryDefinitions.GetQuery("SelectItemStockRoomLocations", new string[] {"MAIN", ItemID });

                objSL8_WTF_DataBaseSettings.SQLConnection.Open();
                objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
                objDataAdapter = new SqlDataAdapter(objSQLCommand);
                objDataAdapter.Fill(objDataTable);

                foreach (DataRow objRow in objDataTable.Rows)
                {
                    objStockLocation = new StockLocation();

                    objStockLocation.Location = objRow["loc"].ToString();

                    objStockLocation.Rank = int.TryParse(objRow["rank"].ToString(), out intTemp) ? intTemp : 0;
                    //objStockLocation.LocationDescription = objRow["description"].ToString();//not included in this table

                    objStockLocation.LocationType = objRow["loc_type"].ToString()[0];

                    objStockLocationList.Add(objStockLocation);
                }

                return objStockLocationList;
            }
        }

        public void AddWrongCount() 
        {
            ExtraSytelineTableDb objDb;


            objDb = new ExtraSytelineTableDb();
            objDb.WrongCounts.Add(new WrongCount { Item = this.ItemID, OccurranceDate = DateTime.Now });
            objDb.SaveChanges();
        }
    }
}
