
/*
**
*/

//
// dsCreateBudgetIn - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsCreateBudgetInDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsCreateBudgetIn" + "DataSet";
            ds.Namespace = "dsCreateBudgetIn" + "NS";

            
	    DataTable ttUserInfoTr = ds.Tables.Add("ttUserInfoTr");
	    ttUserInfoTr.Columns.Add("ttUser", typeof(string));
	    ttUserInfoTr.Columns.Add("ttUserLang", typeof(string));
	    DataTable ttCreateBudgetIn = ds.Tables.Add("ttCreateBudgetIn");
	    ttCreateBudgetIn.Columns.Add("ID", typeof(string));
	    ttCreateBudgetIn.Columns.Add("Period", typeof(int));
	    ttCreateBudgetIn.Columns.Add("GLCode", typeof(string));
	    ttCreateBudgetIn.Columns.Add("Amount", typeof(decimal));
	    ttCreateBudgetIn.Columns.Add("CompanyCode", typeof(string));
	    ttCreateBudgetIn.Columns.Add("Year", typeof(int));


            ds.WriteXmlSchema("dsCreateBudgetIn.xsd");

        }


    }
}
