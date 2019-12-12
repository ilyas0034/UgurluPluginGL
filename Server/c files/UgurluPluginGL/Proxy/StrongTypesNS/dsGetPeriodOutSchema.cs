
/*
**
*/

//
// dsGetPeriodOut - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsGetPeriodOutDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsGetPeriodOut" + "DataSet";
            ds.Namespace = "dsGetPeriodOut" + "NS";

            
	    DataTable ttCstMessages = ds.Tables.Add("ttCstMessages");
	    ttCstMessages.Columns.Add("ttType", typeof(string));
	    ttCstMessages.Columns.Add("ttMessageNumber", typeof(string));
	    ttCstMessages.Columns.Add("ttMessage", typeof(string));
	    DataTable ttGetPeriodOut = ds.Tables.Add("ttGetPeriodOut");
	    ttGetPeriodOut.Columns.Add("Period", typeof(int));
	    ttGetPeriodOut.Columns.Add("Period_ID", typeof(int));
	    ttGetPeriodOut.Columns.Add("PeriodYear", typeof(int));


            ds.WriteXmlSchema("dsGetPeriodOut.xsd");

        }


    }
}
