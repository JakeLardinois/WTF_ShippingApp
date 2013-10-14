using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;


namespace WTFClassLibrary
{
    public class BillOfLading
    {
        public double GrossWeight { get; set; }
        public double TareWeight { get; set; }
        public double NetWeight { get { return GrossWeight - TareWeight; } }
        public int Quantity { get; set; }
        //public string Supplier { get; set; }
        //public int Cartons { get; set; }
        public double AveragePieceWeight { get; set; }
        public int PalletCount { get; set; }
        public string CarrierDescription { get; set; }
        //public string ItemRef { get; set; }
        //public int Sequence { get; set; }
        public string CustomerAddress { get; set; }
        public string FreightCharges { get; set; }
        public string Notes { get; set; }
        public BindingList<ComboBoxItem> ShippingCarriers
        {
            get
            {
                return GetList("SelectShippingCarriers");
            }
        }
        public BindingList<ComboBoxItem> ShippingClassifications
        {
            get
            {
                return GetList("SelectShippingClassifications");
            }
        }
        private BindingList<ComboBoxItem> GetList(string strSelectStatement)
        {
            string strSQL;
            ExtraSytelineTablesSettings objExtraSytelineTablesSettings;
            SqlCommand objSQLCommand;
            SqlDataAdapter objDataAdapter;
            DataTable objDataTable;
            BindingList<ComboBoxItem> objBindingList;


            objBindingList = new BindingList<ComboBoxItem>();
            objExtraSytelineTablesSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery(strSelectStatement);
            objExtraSytelineTablesSettings.SQLConnection.Open();
            objSQLCommand = new SqlCommand(strSQL, objExtraSytelineTablesSettings.SQLConnection);
            objDataAdapter = new SqlDataAdapter(objSQLCommand);
            objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);


            if (objDataTable.Rows.Count > 0)
            {
                objBindingList = new BindingList<ComboBoxItem>();
                //objBindingList.Add(new ComboBoxItem { Text = "--- Select Carrier ---", Value = "0" });
                for (int intCounter = 0; intCounter < objDataTable.Rows.Count; intCounter++)
                    objBindingList.Add(new ComboBoxItem { Value = objDataTable.Rows[intCounter][0].ToString(), Text = objDataTable.Rows[intCounter][1].ToString() });
                return objBindingList;
            }
            else
                return objBindingList;
        }

        //public override string ToString()
        //{
        //    StringBuilder objStrBldr = new StringBuilder();

        //    foreach (string objString in ShippingCarriers)
        //        objStrBldr.Append(objString + "\r\n");

        //    return objStrBldr.ToString();
        //}
    }
}
