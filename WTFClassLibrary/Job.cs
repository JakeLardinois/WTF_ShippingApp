using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WTFClassLibrary
{
    public class Job
    {
        public string  JobNumber { get; set; }
        public int Suffix { get; set; }
        public string FormattedJobNumber {
            get
            {
                int intTemp;
                foreach (var strPrefix in Settings.JobPrefixes)
                    if (JobNumber.StartsWith(strPrefix))
                    {
                        //return int.TryParse(JobNumber.ToUpper().Replace(strPrefix, string.Empty), out intTemp) ? strPrefix + intTemp.ToString().PadLeft(9, '0') : string.Empty;

                        Regex objRegex = new Regex("^(" + strPrefix + ")", RegexOptions.IgnoreCase);
                        return int.TryParse(objRegex.Replace(JobNumber, string.Empty), out intTemp) ? strPrefix + intTemp.ToString().PadLeft(10 - strPrefix.Length, '0') : string.Empty;
                    }

                return JobNumber;
                //return int.TryParse(JobNumber.ToUpper().Replace("B", string.Empty), out intTemp) ? "B" + intTemp.ToString().PadLeft(9,'0') : string.Empty;
            }
        }
        public DateTime JobDate { get; set; }
        public int JobOrderRelease { get; set; }
        public string JobOrderNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerOrderNumber { get; set; }
        public int CustomerOrderRelease { get; set; }
        public int CustomerOrderLine { get; set; }
        public string CustomerName { get; set; }
        //public string CustomerItem { get; set; }
        public string CustomerPO { get; set; }
        //public int CustomerOrderKey { get; set; }
        public double QtyReleased { get; set; }
        public DateTime DueDate { get; set; }
        //public long TotalQuantity { get; set; }
        //public long ReceivedItemAccumulatorID { get; set; }
        //public string ItemID { get; set; }
        public string Salesman { get; set; }
        public double QtyOrdered { get; set; }
        public double QtyShipped { get; set; }
        public double QtyReady { get; set; }
        public double QtyComplete { get; set; }
        public DateTime ShipDate { get; set; }
        public string ShipCodeDescription { get; set; }
        public string Terms { get; set; }
        //public int NotesKey { get; set; }
        //public int bln_noteskey { get; set; }
        //public string DrawingNbr { get; set; }
        public string ItemDescription { get; set; }
        public string Revision { get; set; }
        public string UnitOfMeasure { get; set; }
        //public string Contact { get; set; }
        //public Order SelectedOrder { get; set; }
        public Operation SelectedOperation { get; set; }
        public Operation LastOperation {
            get
            {
                SortableSearchableBindingList<Operation> objOperationList = new SortableSearchableBindingList<Operation>();
                Operation objOperation;
                SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
                DataTable objDataTable = new DataTable();
                SqlDataAdapter objDataAdapter;
                SqlCommand objSQLCommand;
                string strSQL;
                int intTemp;
                double dblTemp;


                strSQL = QueryDefinitions.GetQuery("SelectJobOperations", new string[] { FormattedJobNumber, "DESC" });

                objSL8_WTF_DataBaseSettings.SQLConnection.Open();
                objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
                objDataAdapter = new SqlDataAdapter(objSQLCommand);
                objDataAdapter.Fill(objDataTable);

                objOperation = new Operation();
                //The sort is done in sql, so I just take the first record returned by the collection which is the last operation.
                objOperation.OperationNumber = objDataTable.Rows[0]["oper_num"].ToString();

                objOperation.WorkCenter = objDataTable.Rows[0]["wc"].ToString();

                objOperation.QtyComplete = double.TryParse(objDataTable.Rows[0]["qty_complete"].ToString(), out dblTemp) ? (int)dblTemp : 0;

                objOperation.QtyScrapped = double.TryParse(objDataTable.Rows[0]["qty_scrapped"].ToString(), out dblTemp) ? (int)dblTemp : 0;

                objOperation.QtyMoved = double.TryParse(objDataTable.Rows[0]["qty_moved"].ToString(), out dblTemp) ? (int)dblTemp : 0;

                objOperation.Status = int.TryParse(objDataTable.Rows[0]["Status"].ToString(), out intTemp) ? intTemp : 0;

                return objOperation;
            }
        }
        public SortableSearchableBindingList<Operation> Operations 
        {
            get
            {
                SortableSearchableBindingList<Operation> objOperationList = new SortableSearchableBindingList<Operation>();
                Operation objOperation;
                SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
                DataTable objDataTable = new DataTable();
                SqlDataAdapter objDataAdapter;
                SqlCommand objSQLCommand;
                string strSQL;
                int intTemp;
                double dblTemp;
                

                strSQL = QueryDefinitions.GetQuery("SelectJobOperations", new string[] { FormattedJobNumber, "ASC" });

                objSL8_WTF_DataBaseSettings.SQLConnection.Open();
                objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
                objDataAdapter = new SqlDataAdapter(objSQLCommand);
                objDataAdapter.Fill(objDataTable);

                for (int intCounter = 0; intCounter < objDataTable.Rows.Count; intCounter++)
                {
                    objOperation = new Operation();

                    objOperation.OperationNumber = objDataTable.Rows[intCounter]["oper_num"].ToString();

                    objOperation.WorkCenter = objDataTable.Rows[intCounter]["wc"].ToString();

                    objOperation.QtyComplete = double.TryParse(objDataTable.Rows[intCounter]["qty_complete"].ToString(), out dblTemp) ? (int)dblTemp : 0;

                    objOperation.QtyScrapped = double.TryParse(objDataTable.Rows[intCounter]["qty_scrapped"].ToString(), out dblTemp) ? (int)dblTemp : 0;

                    objOperation.QtyMoved = double.TryParse(objDataTable.Rows[intCounter]["qty_moved"].ToString(), out dblTemp) ? (int)dblTemp : 0;

                    objOperation.Status = int.TryParse(objDataTable.Rows[intCounter]["Status"].ToString(), out intTemp) ? intTemp : 0;

                    try
                    {
                        objOperation.NextOperation = new Operation
                        {
                            OperationNumber = objDataTable.Rows[intCounter + 1]["oper_num"].ToString(),
                            WorkCenter = objDataTable.Rows[intCounter + 1]["wc"].ToString(),
                            QtyComplete = int.TryParse(objDataTable.Rows[intCounter + 1]["qty_complete"].ToString(), out intTemp) ? intTemp : 0,
                            QtyScrapped = int.TryParse(objDataTable.Rows[intCounter + 1]["qty_scrapped"].ToString(), out intTemp) ? intTemp : 0,
                            QtyMoved = int.TryParse(objDataTable.Rows[intCounter + 1]["qty_moved"].ToString(), out intTemp) ? intTemp : 0,
                            Status = int.TryParse(objDataTable.Rows[intCounter + 1]["Status"].ToString(), out intTemp) ? intTemp : 0
                        };
                    }
                    catch { objOperation.NextOperation = new Operation { OperationNumber = "NULL" }; };

                    objOperationList.Add(objOperation);
                }

                //foreach (DataRow objRow in objDataTable.Rows)
                //{
                //    objOperation = new Operation();

                //    objOperation.OperationNumber = objRow["oper_num"].ToString();

                //    objOperation.WorkCenter = objRow["wc"].ToString();

                //    objOperation.QtyComplete = int.TryParse(objRow["qty_complete"].ToString(), out intTemp) ? intTemp : 0;

                //    objOperation.QtyScrapped = int.TryParse(objRow["qty_scrapped"].ToString(), out intTemp) ? intTemp : 0;

                //    objOperation.QtyMoved = int.TryParse(objRow["qty_moved"].ToString(), out intTemp) ? intTemp : 0;

                //    objOperation.Status = int.TryParse(objRow["Status"].ToString(), out intTemp) ? intTemp : 0;

                //    objOperationList.Add(objOperation);
                //}

                return objOperationList;
            }
        }
        public SortableSearchableBindingList<Operation> OpenOperations
        {
            get
            {
                SortableSearchableBindingList<Operation> objList = new SortableSearchableBindingList<Operation>();


                foreach (Operation objOperation in Operations.Where(o => o.Status == 0).ToList())
                    objList.Add(objOperation);
                return objList;
            }
        }
    }
}
