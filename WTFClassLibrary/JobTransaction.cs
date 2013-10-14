using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;


namespace WTFClassLibrary
{
    public class JobTransaction
    {
        public int TransactionNumber { get; set; }
        public string JobNumber { get; set; }
        public int Suffix { get; set; }
        public char TransactionType { get; set; }//This should always be M.  The values can be either M, I, S, R, etc. all uppercase
        public DateTime TransDate { get; set; }
        public double QtyComplete { get; set; }
        public double QtyScrapped { get; set; }
        public Operation Operation { get; set; }
        public double ActualHours { get; set; }
        public Operation NextOperation { get; set; }
        public string EmployeeNumber { get; set; }
        public int StartTime { get; set; }//seconds
        public int EndTime { get; set; } //seconds
        public string IndirectCode { get; set; }
        public char PayRate { get; set; } //1==True, 0==false
        public double QtyMoved { get; set; }
        public string Warehouse { get; set; }
        public StockLocation Location { get; set; }
        public string UserCode { get; set; }
        public bool CloseJob { get; set; }
        public bool CompleteOperation { get; set; }
        public string Shift { get; set; }//You may need to implement this, but most transactions leave it null
        public bool Posted { get; set; }//0 means it has NOT been posted 1 means it has
        public char TransactionClass { get; set; }//This should always be J (capital) on a material transaction
        public DateTime RecordDate { get; set; }
        public string RowPointer { get; set; }//this is a GUID that appears to be automatically created by the database.
        public string CreatedBy { get; set; }//This contains the username of the creator (debm, jayn, tony, sa, etc.)
        public string UpdatedBy { get; set; }//This containst eh username of the updater (debm, jayn, tony, sa, etc.)
        public DateTime CreateDate { get; set; }
        //public static SortableSearchableBindingList<StockLocation> StockLocations
        //{
        //    get
        //    {
        //        SortableSearchableBindingList<StockLocation> objStockLocationList = new SortableSearchableBindingList<StockLocation>();
        //        StockLocation objStockLocation;
        //        SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
        //        DataTable objDataTable = new DataTable();
        //        SqlDataAdapter objDataAdapter;
        //        SqlCommand objSQLCommand;
        //        string strSQL;


        //        strSQL = QueryDefinitions.GetQuery("SelectStockRoomLocations");

        //        objSL8_WTF_DataBaseSettings.SQLConnection.Open();
        //        objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
        //        objDataAdapter = new SqlDataAdapter(objSQLCommand);
        //        objDataAdapter.Fill(objDataTable);

        //        foreach (DataRow objRow in objDataTable.Rows)
        //        {
        //            objStockLocation = new StockLocation();

        //            objStockLocation.Location = objRow["loc"].ToString();

        //            objStockLocation.LocationDescription = objRow["description"].ToString();

        //            objStockLocation.LocationType = objRow["loc_type"].ToString()[0];

        //            objStockLocationList.Add(objStockLocation);
        //        }

        //        return objStockLocationList;
        //    }
        //}
        //public static BindingList<ComboBoxItem> StockLocations
        //{
        //    get
        //    {
        //        string strSQL;
        //        SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
        //        SqlCommand objSQLCommand;
        //        SqlDataAdapter objDataAdapter;
        //        DataTable objDataTable;
        //        BindingList<ComboBoxItem> objBindingList;


        //        objBindingList = new BindingList<ComboBoxItem>();
        //        objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
        //        strSQL = QueryDefinitions.GetQuery("SelectStockRoomLocations");
        //        objSL8_WTF_DataBaseSettings.SQLConnection.Open();
        //        objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
        //        objDataAdapter = new SqlDataAdapter(objSQLCommand);
        //        objDataTable = new DataTable();
        //        objDataAdapter.Fill(objDataTable);


        //        if (objDataTable.Rows.Count > 0)
        //        {
        //            objBindingList = new BindingList<ComboBoxItem>();
        //            //objBindingList.Add(new ComboBoxItem { Text = "--- Select Carrier ---", Value = "0" });
        //            for (int intCounter = 0; intCounter < objDataTable.Rows.Count; intCounter++)
        //                objBindingList.Add(new ComboBoxItem { Value = objDataTable.Rows[intCounter][0].ToString(), Text = objDataTable.Rows[intCounter][0].ToString() });
        //            return objBindingList;
        //        }
        //        else
        //            return objBindingList;


                
        //    }
        //}
        public bool Insert()
        {
            /*I used the command "GRANT INSERT ON [WTF_App].[dbo].[jobtran] TO WTFApp" to grant the insert priveleges
             * "REVOKE INSERT ON [WTF_App].[dbo].[jobtran] TO WTFApp" is the SQL to remove the privelege.
             * Note that I needed to make a new query in order for a successful execution; each time I tried to use an existing Query, it failed
             */
            SortableSearchableBindingList<Operation> objOperationList = new SortableSearchableBindingList<Operation>();
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            DataTable objDataTable = new DataTable();
            SqlCommand objSQLCommand;
            string strSQL;
            int intCompleteOperation, intCloseJob;


            intCompleteOperation = CompleteOperation ? 1 : 0;
            intCloseJob = CloseJob ? 1 : 0;

            strSQL = QueryDefinitions.GetQuery("InsertIntoJobTran", new string[] { JobNumber, Suffix.ToString(), TransactionType.ToString().ToUpper(), DateTime.Now.ToString(), QtyComplete.ToString(), Operation.ToString(), 
                QtyMoved.ToString(), Warehouse, Location.ToString(), TransactionClass.ToString().ToUpper(), Operation.WorkCenter, UserCode, intCompleteOperation.ToString(), intCloseJob.ToString(), NextOperation.ToString() });
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objSQLCommand = objSL8_WTF_DataBaseSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;
            if (objSQLCommand.ExecuteNonQuery() == 1) //the appropriate record was affected
                return true;
            else
                return false;
        }
    }
}
