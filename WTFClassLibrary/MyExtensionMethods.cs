using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;


namespace WTFClassLibrary
{
    public static class MyExtensionMethods
    {
        public static long GetNextSequence(this Label source)
        {
            return GetNextSequenceNumber("SHIPPING_LABELS");
        }

        public static string GetInternalNotes(this Order source)
        {
            StringBuilder objStringBuilder = new StringBuilder();

            foreach (Note objNote in GetNotesListByGUID(source.RowPointer))
                if (!objNote.IsInternalNote)
                    objStringBuilder.Append(objNote.Notes);

            return objStringBuilder.ToString();
        }

        public static List<Note> GetNotes(this Order source)
        {
            return GetNotesListByGUID(source.RowPointer);
        }

        public static string GetInternalNotes(this OrderLine source)
        {
            StringBuilder objStringBuilder = new StringBuilder();

            foreach (Note objNote in GetNotesListByGUID(source.RowPointer))
                if (!objNote.IsInternalNote)
                    objStringBuilder.Append(objNote.Notes);

            return objStringBuilder.ToString();
        }

        public static List<Note> GetNotes(this OrderLine source)
        {
            return GetNotesListByGUID(source.RowPointer);
        }

        private static List<Note> GetNotesListByGUID(string strGUID)
        {
            SqlCommand objSQLCommand;
            string strSQL;
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
            SqlDataReader objDataReader;
            Note objNote;
            List<Note> objNoteList;


            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            strSQL = QueryDefinitions.GetQuery("SelectNotesByGUID", new string[] { strGUID });
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objSQLCommand = objSL8_WTF_DataBaseSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            objDataReader = objSQLCommand.ExecuteReader();

            objNoteList = new List<Note>();
            if (objDataReader.HasRows)
            {
                while (objDataReader.Read())
                {
                    objNote = new Note();

                    objNote.Description = objDataReader["Description"].ToString();
                    objNote.Notes = objDataReader["Note"].ToString();
                    objNote.IsSpecificNote = objDataReader["IsSpecificNote"].ToString().Equals("0") ? false : true;
                    objNote.TableName = objDataReader["TableName"].ToString();
                    objNote.RefRowPointer = objDataReader["RefRowPointer"].ToString();
                    objNote.IsInternalNote = objDataReader["IsInternalNote"].ToString().Equals("0") ? false : true;

                    objNoteList.Add(objNote);
                }
            }

            return objNoteList;
        }

        private static long GetNextSequenceNumber(string strTableName)
        {
            SqlCommand objSQLCommand;
            string strSQL;
            long lngSequenceNo;
            string strGUID;
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            SqlDataReader objDataReader;


            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery("GetNextSequenceNumber", new string[] { strTableName });
            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;

            objDataReader = objSQLCommand.ExecuteReader();

            if (objDataReader.Read())
            {
                long.TryParse(objDataReader["NextSequence"].ToString(), out lngSequenceNo);
                strGUID = objDataReader["GUID"].ToString();
            }
            else
                throw new Exception("Unable to get record from TableSequence. TABLE: " + strTableName);

            lngSequenceNo = ++lngSequenceNo;

            if (UpdateNextSequenceNumber(lngSequenceNo, strTableName, strGUID) == 1)
                return lngSequenceNo;
            else
            {
                throw new Exception("Failed to update TableSequence on Table: " + strTableName);
            }

        }

        private static int UpdateNextSequenceNumber(long lngNextSequenceNo, string strTableName, string strGUID)
        {
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            SqlCommand objSQLCommand;
            string strSQL;

            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();
            strSQL = QueryDefinitions.GetQuery("UpdateNextSequenceNumber", new string[] { lngNextSequenceNo.ToString(), GetGUID(), strTableName, strGUID });
            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = new SqlCommand(strSQL, objExtraSytelineTableSettings.SQLConnection);

            return objSQLCommand.ExecuteNonQuery();
        }

        private static string GetGUID()
        {
            return Guid.NewGuid().ToString().ToUpper();
        }

        /*This extension method gets a property value of type T from an anonymously typed object a good example is in frmOSAIFileUtility
         ex. object objObject = new {commandName = "CreateFile"}
         *   objObject.GetValueFromAnonymousType<string>("commandName");*/
        public static T GetValueFromAnonymousType<T>(this object dataitem, string itemkey)
        {
            System.Type type = dataitem.GetType();


            T itemvalue = (T)type.GetProperty(itemkey).GetValue(dataitem, null);
            return itemvalue;
        }

        //Splits a comma separated string into a list
        public static IEnumerable<string> SplitNTrim(this string source)
        {
            string[] strArray;


            strArray = source.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (strArray.Length > 0)
            {
                return source.Split(',').Select(s => s.Trim());
            }
            else
                return new List<string>();


        }
    }
}
