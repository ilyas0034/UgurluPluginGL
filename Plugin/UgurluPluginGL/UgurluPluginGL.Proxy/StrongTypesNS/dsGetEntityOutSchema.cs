
/*
**
*/

//
// dsGetEntityOut - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsGetEntityOutDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsGetEntityOut" + "DataSet";
            ds.Namespace = "dsGetEntityOut" + "NS";

            
	    DataTable ttCstMessages = ds.Tables.Add("ttCstMessages");
	    ttCstMessages.Columns.Add("ttType", typeof(string));
	    ttCstMessages.Columns.Add("ttMessageNumber", typeof(string));
	    ttCstMessages.Columns.Add("ttMessage", typeof(string));
	    DataTable ttGetEntityOut = ds.Tables.Add("ttGetEntityOut");
	    ttGetEntityOut.Columns.Add("CompanyCode", typeof(string));
	    ttGetEntityOut.Columns.Add("Company_ID", typeof(int));


            ds.WriteXmlSchema("dsGetEntityOut.xsd");

        }


    }
}
