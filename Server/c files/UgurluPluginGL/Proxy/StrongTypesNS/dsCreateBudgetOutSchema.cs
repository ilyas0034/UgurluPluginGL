
/*
**
*/

//
// dsCreateBudgetOut - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsCreateBudgetOutDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsCreateBudgetOut" + "DataSet";
            ds.Namespace = "dsCreateBudgetOut" + "NS";

            
	    DataTable ttCstMessages = ds.Tables.Add("ttCstMessages");
	    ttCstMessages.Columns.Add("ttType", typeof(string));
	    ttCstMessages.Columns.Add("ttMessageNumber", typeof(string));
	    ttCstMessages.Columns.Add("ttMessage", typeof(string));
	    DataTable ttCreateBudgetOut = ds.Tables.Add("ttCreateBudgetOut");
	    ttCreateBudgetOut.Columns.Add("ID", typeof(string));
	    ttCreateBudgetOut.Columns.Add("Period", typeof(int));
	    ttCreateBudgetOut.Columns.Add("GLCode", typeof(string));
	    ttCreateBudgetOut.Columns.Add("Amount", typeof(decimal));
	    ttCreateBudgetOut.Columns.Add("CompanyCode", typeof(string));
	    ttCreateBudgetOut.Columns.Add("Year", typeof(int));


            ds.WriteXmlSchema("dsCreateBudgetOut.xsd");

        }


    }
}
