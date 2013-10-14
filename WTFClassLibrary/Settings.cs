using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.IO;


namespace WTFClassLibrary
{
    public class SL8WebServiceSettings
    {
        public SL8WebServiceSettings()
        {
            UserName = "JakeL";
            Password = "00pilot";
            ConfigName = "WTF";
            WebService = new IDOWebServiceReference.DOWebServiceSoapClient();
            SessionToken = WebService.CreateSessionToken(UserName, Password, ConfigName);
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfigName { get; set; }
        public IDOWebServiceReference.DOWebServiceSoapClient WebService { get; set; }
        public string SessionToken { get; set; }
    }

    public class ExtraSytelineTablesSettings
    {
        public ExtraSytelineTablesSettings()
        {
            string strSQLConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ExtraSytelineTablesConnectionString"].ConnectionString;
            SQLConnection = new SqlConnection(strSQLConnectionString);
        }

        public SqlConnection SQLConnection { get; set; }

    }

    public class SL8_WTF_DataBaseSettings
    {
        public SL8_WTF_DataBaseSettings()
        {
            string strSQLConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SL8_WTF_DataBaseConnectionString"].ConnectionString;
            SQLConnection = new SqlConnection(strSQLConnectionString);
        }

        public SqlConnection SQLConnection { get; set; }
    }

    public static class QueryDefinitions
    {
        static System.Resources.ResourceManager objResourceManager = new System.Resources.ResourceManager("WTFClassLibrary.QueryDefs", System.Reflection.Assembly.GetExecutingAssembly());
        static StringBuilder strSQL;


        public static string GetQuery(string strQueryName)
        {
            strSQL = new StringBuilder();
            strSQL.Append(objResourceManager.GetString(strQueryName));

            return strSQL.ToString();
        }

        public static string GetQuery(string strQueryName, string[] strParams)
        {
            strSQL = new StringBuilder();
            strSQL.Append(objResourceManager.GetString(strQueryName));
            //strSQL.Append(QueryDefs.DeleteOldestItemUnitWeightHistory);

            //for (int intCounter = 0; intCounter < strParams.Length; intCounter++)
            for (int intCounter = strParams.Length - 1; intCounter > -1; intCounter--)
            {
                string strTemp = "~p" + intCounter;
                strSQL.Replace(strTemp, strParams[intCounter]);
            }

            return strSQL.ToString();
        }
    }

    public static class Settings
    {
        public static string GetLabelPath()
        {
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            SqlCommand objSQLCommand;
            SqlDataReader objDataReader;
            string strSQL;


            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery("SelectSetting", new string[] { "LabelPath" });

            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            objDataReader = objSQLCommand.ExecuteReader();
            objDataReader.Read();
            
            if (string.IsNullOrEmpty(objDataReader["Setting"].ToString()) || !Directory.Exists(objDataReader["Setting"].ToString()))
                throw new Exception("Unable to get a Valid File Path from LabelPath record of the Settings Table.");
            else
                return objDataReader["Setting"].ToString();
        }

        public static int GetMaxItemPieceUnitWeightHistoryCount()
        {
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            SqlCommand objSQLCommand;
            SqlDataReader objDataReader;
            string strSQL;
            int intTemp;


            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery("SelectSetting", new string[] { "ItemPieceWeightHistoryCount" });

            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            objDataReader = objSQLCommand.ExecuteReader();
            objDataReader.Read();

            if (int.TryParse(objDataReader["Setting"].ToString(), out intTemp))
                return intTemp;
            else
                throw new Exception("Unable to get a valid ItemPieceWeightHistoryCount from the Settings Table.");
        }
    }

    public static class SharedVariables
    {
        public static DateTime MINDATE = new DateTime(1900, 1, 1);
        public static DateTime MAXDATE = new DateTime(2999, 1, 1);
    }
}
