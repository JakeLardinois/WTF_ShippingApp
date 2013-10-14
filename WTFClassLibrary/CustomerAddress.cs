using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WTFClassLibrary;
using System.Data;
using System.Data.SqlClient;


namespace WTFClassLibrary
{
    public class CustomerAddress : Address
    {
        public string CustomerNumber { get; set; }
        public CustomerAddress() { }
        public CustomerAddress(string strCustomerNumber)
        {
            CustomerAddress objTemp = Search(strCustomerNumber, 1).First();

            CustomerNumber = objTemp.CustomerNumber;
            Name = objTemp.Name;
            AddressLine1 = objTemp.AddressLine1;
            AddressLine2 = objTemp.AddressLine2;
            AddressLine3 = objTemp.AddressLine3;
            AddressLine4 = objTemp.AddressLine4;
            City = objTemp.City;
            State = objTemp.State;
            ZipCode = objTemp.ZipCode;
            Country = objTemp.Country;
        }

        public static SortableSearchableBindingList<CustomerAddress> Find(string strCustomerNumber)//Retrieves a list of addresses of the specified customer
        {
            SortableSearchableBindingList<CustomerAddress> objCustomerAddressList;
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter;
            SqlCommand objSQLCommand;
            CustomerAddress objCustomerAddress;
            string strSQL;


            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            strSQL = QueryDefinitions.GetQuery("SelectCustomerAddresses", new string[] { strCustomerNumber });
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
            objDataAdapter = new SqlDataAdapter(objSQLCommand);
            objDataAdapter.Fill(objDataTable);

            objCustomerAddressList = new SortableSearchableBindingList<CustomerAddress>();

            if (objDataTable.Rows.Count > 0)
            {
                foreach (DataRow objRow in objDataTable.Rows)
                {
                    objCustomerAddress = new CustomerAddress();

                    objCustomerAddress.CustomerNumber = objRow["cust_num"].ToString();
                    objCustomerAddress.Name = objRow["Name"].ToString();
                    objCustomerAddress.AddressLine1 = objRow["Addr##1"].ToString();
                    objCustomerAddress.AddressLine2 = objRow["Addr##2"].ToString();
                    objCustomerAddress.AddressLine3 = objRow["Addr##3"].ToString();
                    objCustomerAddress.AddressLine4 = objRow["Addr##4"].ToString();
                    objCustomerAddress.City = objRow["City"].ToString();
                    objCustomerAddress.State = objRow["State"].ToString();
                    objCustomerAddress.ZipCode = objRow["ZIP"].ToString();
                    objCustomerAddress.Country = objRow["country"].ToString();

                    objCustomerAddressList.Add(objCustomerAddress);
                }
            }
            return objCustomerAddressList;
        }

        public static SortableSearchableBindingList<CustomerAddress> Search(string strCustomerNumber, int intMaxRecordCount = 100, string strSearchBy = "cust_num")//Retrieves a list of customers that match the customer number
        {
            SortableSearchableBindingList<CustomerAddress> objCustomerAddressList;
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter;
            SqlCommand objSQLCommand;
            CustomerAddress objCustomerAddress;
            string strSQL;


            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            strSQL = QueryDefinitions.GetQuery("SelectTopNCustomerAddresses", new string[] { intMaxRecordCount.ToString(), strSearchBy, strCustomerNumber.Trim(), strSearchBy });
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
            objDataAdapter = new SqlDataAdapter(objSQLCommand);
            objDataAdapter.Fill(objDataTable);

            objCustomerAddressList = new SortableSearchableBindingList<CustomerAddress>();

            if (objDataTable.Rows.Count > 0)
            {
                foreach (DataRow objRow in objDataTable.Rows)
                {
                    objCustomerAddress = new CustomerAddress();

                    objCustomerAddress.CustomerNumber = objRow["cust_num"].ToString();
                    objCustomerAddress.Name = objRow["Name"].ToString();
                    objCustomerAddress.AddressLine1 = objRow["Addr##1"].ToString();
                    objCustomerAddress.AddressLine2 = objRow["Addr##2"].ToString();
                    objCustomerAddress.AddressLine3 = objRow["Addr##3"].ToString();
                    objCustomerAddress.AddressLine4 = objRow["Addr##4"].ToString();
                    objCustomerAddress.City = objRow["City"].ToString();
                    objCustomerAddress.State = objRow["State"].ToString();
                    objCustomerAddress.ZipCode = objRow["ZIP"].ToString();
                    objCustomerAddress.Country = objRow["country"].ToString();

                    objCustomerAddressList.Add(objCustomerAddress);
                }
            }
            return objCustomerAddressList;
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
