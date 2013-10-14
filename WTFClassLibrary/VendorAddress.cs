using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WTFClassLibrary;
using System.Data;
using System.Data.SqlClient;

namespace WTFClassLibrary
{
    public class VendorAddress : Address
    {
        public string VendorNumber { get; set; }
        public VendorAddress() { }
        public VendorAddress(string strVendorNumber)
        {
            VendorAddress objTemp = Search(strVendorNumber, 1).First();

            VendorNumber = objTemp.VendorNumber;
            Name = objTemp.Name;
            AddressLine1 = objTemp.AddressLine1;
            AddressLine2 = objTemp.AddressLine2;
            AddressLine3 = objTemp.AddressLine3;
            AddressLine4 = objTemp.AddressLine4;
            City = objTemp.City;
            State = objTemp.State;
            ZipCode = objTemp.ZipCode;
        }
        public static SortableSearchableBindingList<VendorAddress> Search(string strVendorNumber, int intMaxRecordCount = 100, string strSearchBy = "vend_num")//Retrieves a list of customers that match the customer number
        {
            SortableSearchableBindingList<VendorAddress> objVendorAddressList;
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter;
            SqlCommand objSQLCommand;
            VendorAddress objVendorAddress;
            string strSQL;


            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            strSQL = QueryDefinitions.GetQuery("SelectTopNVendorAddresses", new string[] { intMaxRecordCount.ToString(), strSearchBy, strVendorNumber, strSearchBy });
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
            objDataAdapter = new SqlDataAdapter(objSQLCommand);
            objDataAdapter.Fill(objDataTable);

            objVendorAddressList = new SortableSearchableBindingList<VendorAddress>();

            if (objDataTable.Rows.Count > 0)
            {
                foreach (DataRow objRow in objDataTable.Rows)
                {
                    objVendorAddress = new VendorAddress();

                    objVendorAddress.VendorNumber = objRow["vend_num"].ToString();
                    objVendorAddress.Name = objRow["Name"].ToString();
                    objVendorAddress.AddressLine1 = objRow["Addr##1"].ToString();
                    objVendorAddress.AddressLine2 = objRow["Addr##2"].ToString();
                    objVendorAddress.AddressLine3 = objRow["Addr##3"].ToString();
                    objVendorAddress.AddressLine4 = objRow["Addr##4"].ToString();
                    objVendorAddress.City = objRow["City"].ToString();
                    objVendorAddress.State = objRow["State"].ToString();
                    objVendorAddress.ZipCode = objRow["ZIP"].ToString();
                    objVendorAddress.Country = objRow["country"].ToString();

                    objVendorAddressList.Add(objVendorAddress);
                }
            }
            return objVendorAddressList;
        }
        public override string ToString()
        {
            StringBuilder objStrBldr = new StringBuilder();


            objStrBldr.Append(Name);
            objStrBldr.Append(AddressLine1.Length > 0 ? "\r\n" + AddressLine1 : string.Empty);
            objStrBldr.Append(AddressLine2.Length > 0 ? "\r\n" + AddressLine2 : string.Empty);
            objStrBldr.Append(AddressLine3.Length > 0 ? "\r\n" + AddressLine3 : string.Empty);
            objStrBldr.Append(AddressLine4.Length > 0 ? "\r\n" + AddressLine4 : string.Empty);
            objStrBldr.Append("\r\n" + City + ", " + State + " " + ZipCode + " " + Country);

            return objStrBldr.ToString();
        }
    }
}
