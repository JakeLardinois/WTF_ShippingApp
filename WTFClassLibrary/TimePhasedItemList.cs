using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;


namespace WTFClassLibrary
{
    public class TimePhasedItemList : SortableBindingList<TimePhasedItem>
    {
        public TimePhasedItemList()
            : base()
        {
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
            SqlCommand objCmd;
            SqlDataAdapter objAdapter;
            DataSet objDataSet, objLoadDataSet;
            TimePhasedItem objTimePhasedInventoryItem;
            RepletionDepletionItem objRepletionDepletionItem;
            SL8DbDataContext objDB;
            int intTemp;


            objDB = new SL8DbDataContext();

            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();

            objCmd = new SqlCommand("CLM_ResourceGroupScheduleSp", objSL8_WTF_DataBaseSettings.SQLConnection);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.Add(new SqlParameter("@StartDate", "1/1/1753"));
            objCmd.Parameters.Add(new SqlParameter("@EndDate", "12/31/9999"));
            objCmd.Parameters.Add(new SqlParameter("@AltNum", 0));
            objAdapter = new SqlDataAdapter(objCmd);
            objLoadDataSet = new DataSet();
            objAdapter.Fill(objLoadDataSet);


            objCmd = new SqlCommand("SupDemBuildSp", objSL8_WTF_DataBaseSettings.SQLConnection);
            objCmd.CommandType = CommandType.StoredProcedure;


            foreach (var objItem in objDB.PurchasedItems)
            {
                objTimePhasedInventoryItem = new TimePhasedItem();
                objTimePhasedInventoryItem.ItemID = objItem.ItemID;
                objTimePhasedInventoryItem.ItemDescription = objItem.Description;
                objTimePhasedInventoryItem.UnitOfMeasure = objItem.UnitOfMeasure;

                objCmd.Parameters.Clear();
                objCmd.Parameters.Add(new SqlParameter("@Item", objTimePhasedInventoryItem.ItemID));
                objCmd.Parameters.Add(new SqlParameter("@Whse", "MAIN"));
                objCmd.Parameters.Add(new SqlParameter("@StartingDate", DateTime.Now.AddYears(-1).ToShortDateString()));
                objCmd.Parameters.Add(new SqlParameter("@Filter", DBNull.Value));//This was the only way I could get null passed as a parameter to the stored proc

                objAdapter = new SqlDataAdapter(objCmd);
                objDataSet = new DataSet();
                objAdapter.Fill(objDataSet);

                objTimePhasedInventoryItem.RepletionsAndDepletions = new SortableBindingList<RepletionDepletionItem>();
                foreach (var objAnonymousRepletionDepletion in objDataSet.Tables[0].AsEnumerable())
                {
                    objRepletionDepletionItem = new RepletionDepletionItem
                    {
                        DueDate = objAnonymousRepletionDepletion.Field<DateTime?>("DisplayDate") ?? DateTime.MinValue,//This was how I stopped the null errors from the null dates in the db
                        ProjectedOnHand = objAnonymousRepletionDepletion.Field<decimal>("QtyOnHand"),
                        Qty = objAnonymousRepletionDepletion.Field<decimal>("Qty"),
                        Status = objAnonymousRepletionDepletion.Field<string>("RcptRqmt"),
                        ReferenceData = objAnonymousRepletionDepletion.Field<string>("Reference"),
                        ItemID = objAnonymousRepletionDepletion.Field<string>("Parent"),
                        Job = objAnonymousRepletionDepletion.Field<string>("RefNum")
                    };

                    if (objRepletionDepletionItem.Job.ToUpper().Trim().Equals("INIT"))
                    {
                        objTimePhasedInventoryItem.QtyOnHand = objRepletionDepletionItem.ProjectedOnHand;
                        objRepletionDepletionItem.DueDate = DateTime.Now;
                    }
                    else if (!string.IsNullOrEmpty(objRepletionDepletionItem.Status) && objRepletionDepletionItem.Status.Equals("Q"))//it is a job, so get the workcenter
                    {
                        var objArray = objRepletionDepletionItem.ReferenceData.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        objRepletionDepletionItem.Job = objArray[1].Substring(0, objArray[1].IndexOf('-'));
                        objRepletionDepletionItem.Operation = int.TryParse(objArray[2], out intTemp) ? intTemp : 0;
                        objRepletionDepletionItem.Suffix = int.TryParse(objArray[1].Substring(objArray[1].IndexOf('-') + 1, objArray[1].Length - objArray[1].IndexOf('-') - 1), out intTemp) ? intTemp : 0;


                        var query = objLoadDataSet.Tables[0].AsEnumerable()
                            .Where(w => !string.IsNullOrEmpty(w.Field<string>("DerJob")) && w.Field<string>("DerJob").Equals(objRepletionDepletionItem.Job))
                            .Where(w => !w.IsNull("DerOperNum") && w.Field<int>("DerOperNum") == objRepletionDepletionItem.Operation)
                            .Where(w => !w.IsNull("DerSuffix") && w.Field<Int16>("DerSuffix") == objRepletionDepletionItem.Suffix)
                            .FirstOrDefault();
                        //I kept getting unhandled null exceptions when executing the below query. turns out that there were nulls in the stored procedure and I needed to check for them; see altered query above.
                        //var query = objLoadDataSet.Tables[0].AsEnumerable()
                        //    .Where(w => w.Field<string>("DerJob").Equals(objRepletionDepletionItem.Job) &&
                        //        w.Field<int>("DerOperNum") == objRepletionDepletionItem.Operation &&
                        //        w.Field<Int16>("DerSuffix") == objRepletionDepletionItem.Suffix)
                        //    .FirstOrDefault();

                        if (query != null)
                        {
                            objRepletionDepletionItem.WorkCenter = query.Field<string>("RESID");
                            //objRepletionDepletionItem.ItemID = query.Field<string>("PARTID");
                        }
                    }

                    objTimePhasedInventoryItem.RepletionsAndDepletions.Add(objRepletionDepletionItem);
                }
                this.Add(objTimePhasedInventoryItem);
            }

            objSL8_WTF_DataBaseSettings.SQLConnection.Close();
        }
    }
}
