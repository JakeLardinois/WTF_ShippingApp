using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;


namespace WTFClassLibrary
{
    public class TimePhasedItem
    {
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        //public string ItemIDandDescription { get { return this.ItemID + ": " + this.ItemDescription; } }
        public string UnitOfMeasure { get; set; }
        public decimal QtyOnHand { get; set; }
        public decimal QtyOnOrder { get; set; }
        public decimal QtyAllocated { get; set; }
        public decimal NetQtyRequired { get; set; }
        public string VendorNumber { get; set; }
        public string VendorName { get; set; }
        public SortableBindingList<RepletionDepletionItem> RepletionsAndDepletions { get; set; }

        public override string ToString()
        {
            return ItemID;
        }
    }

    public class RepletionDepletionItem
    {
        public DateTime DueDate { get; set; }
        public decimal ProjectedOnHand { get; set; }
        public decimal OutstandingRequirement { get; set; }
        public decimal OutstandingReciept { get; set; }
        public string Status { get; set; }
        public string ReferenceData { get; set; }
        public string VendorName { get; set; }
        public string WorkCenter { get; set; }
        public string ItemID { get; set; }
        public string Job { get; set; }
        public int Operation { get; set; }
        public int Suffix { get; set; }
        public decimal Qty { get; set; }
    }

    public class PurchasedItemList : SortableBindingList<TimePhasedItem>
    {
        public PurchasedItemList()
            : base()
        {
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
            SqlCommand objCmd;
            SqlDataAdapter objAdapter;
            DataSet objDataSet, objLoadDataSet;
            TimePhasedItem objPurchasedItem;
            RepletionDepletionItem objRepletionDepletionItem;
            int intTemp;

            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objCmd = new SqlCommand("Rpt_PurchaseRequirementsSp", objSL8_WTF_DataBaseSettings.SQLConnection);

            objCmd.CommandTimeout = 60;//via the vpn I kept getting a timeout; this fixed it.

            objCmd.CommandType = CommandType.StoredProcedure;
            //objCmd.Parameters.Add(new SqlParameter("@ItemStarting", "WIQ.3045-4 1018"));
            //objCmd.Parameters.Add(new SqlParameter("@ItemEnding", "WIQ.3045-4 1018"));
            objCmd.Parameters.Add(new SqlParameter("@ShowDepl", 1));
            objCmd.Parameters.Add(new SqlParameter("@ShowRepl", 1));
            objCmd.Parameters.Add(new SqlParameter("@TimePhaseDetail", 1));
            objCmd.Parameters.Add(new SqlParameter("@JobStatus", "FR"));//can make this "FR" to show Firm AND Released Jobs
            objCmd.Parameters.Add(new SqlParameter("@POStatus", "O"));
            objCmd.Parameters.Add(new SqlParameter("@Source", "P"));

            objAdapter = new SqlDataAdapter(objCmd);
            objDataSet = new DataSet();
            objAdapter.Fill(objDataSet);

            objCmd = new SqlCommand("CLM_ResourceGroupScheduleSp", objSL8_WTF_DataBaseSettings.SQLConnection);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.Add(new SqlParameter("@StartDate", "1/1/1753"));
            objCmd.Parameters.Add(new SqlParameter("@EndDate", "12/31/9999"));
            objCmd.Parameters.Add(new SqlParameter("@AltNum", 0));

            objAdapter = new SqlDataAdapter(objCmd);
            objLoadDataSet = new DataSet();
            objAdapter.Fill(objLoadDataSet);

            objSL8_WTF_DataBaseSettings.SQLConnection.Close();

            var objGroupedItems = objDataSet.Tables[0].AsEnumerable()
                .GroupBy(f => new
                {
                    ItemID = f.Field<string>("item")
                })
                .Select(g =>
                    new
                    {
                        ItemID = g.Key.ItemID,
                        ItemDescription = g.First().Field<string>("item_description"),
                        UnitOfMeasure = g.First().Field<string>("u_m"),
                        QtyOnHand = g.First().Field<decimal>("on_hand"),
                        QtyOnOrder = g.First().Field<decimal>("on_order"),
                        QtyAllocated = g.First().Field<decimal>("alloc_mfg"),
                        NetQtyRequired = g.First().Field<decimal>("net_req"),
                        VendorNumber = g.First().Field<string>("vend1"),
                        VendorName = g.First().Field<string>("vendname1"),
                        RepletionsAndDepletions = g
                    });

            foreach (var objAnonymousPurchasedItem in objGroupedItems)
            {
                objPurchasedItem = new TimePhasedItem
                {
                    ItemID = objAnonymousPurchasedItem.ItemID,
                    ItemDescription = objAnonymousPurchasedItem.ItemDescription,
                    UnitOfMeasure = objAnonymousPurchasedItem.UnitOfMeasure,
                    QtyOnHand = objAnonymousPurchasedItem.QtyOnHand,
                    QtyOnOrder = objAnonymousPurchasedItem.QtyOnOrder,
                    QtyAllocated = objAnonymousPurchasedItem.QtyAllocated,
                    NetQtyRequired = objAnonymousPurchasedItem.NetQtyRequired,
                    VendorNumber = objAnonymousPurchasedItem.VendorNumber,
                    VendorName = objAnonymousPurchasedItem.VendorName
                };

                objPurchasedItem.RepletionsAndDepletions = new SortableBindingList<RepletionDepletionItem>();
                foreach (var objAnonymousRepletionDepletion in objAnonymousPurchasedItem.RepletionsAndDepletions)
                {
                    objRepletionDepletionItem = new RepletionDepletionItem
                    {
                        DueDate = objAnonymousRepletionDepletion.Field<DateTime>("sub10_due_date"),
                        ProjectedOnHand = objAnonymousRepletionDepletion.Field<decimal>("sub10_on_hand"),
                        OutstandingRequirement = objAnonymousRepletionDepletion.Field<decimal>("sub10_reqmt"),
                        OutstandingReciept = objAnonymousRepletionDepletion.Field<decimal>("sub10_receipt"),
                        Status = objAnonymousRepletionDepletion.Field<string>("sub10_s"),
                        ReferenceData = objAnonymousRepletionDepletion.Field<string>("sub10_reference"),
                        VendorName = objAnonymousRepletionDepletion.Field<string>("sub10_name")
                    };

                    if (!string.IsNullOrEmpty(objRepletionDepletionItem.Status) && objRepletionDepletionItem.Status.Equals("R"))//it is a released job, so get the workcenter
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
                            objRepletionDepletionItem.ItemID = query.Field<string>("PARTID");
                        }

                        //Console.WriteLine();
                    }
                    objPurchasedItem.RepletionsAndDepletions.Add(objRepletionDepletionItem);
                }

                this.Add(objPurchasedItem);
            }
        }
    }
}
