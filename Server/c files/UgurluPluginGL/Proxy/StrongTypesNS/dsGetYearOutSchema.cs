
/*
**
*/

//
// dsGetYearOut - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsGetYearOutDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsGetYearOut" + "DataSet";
            ds.Namespace = "dsGetYearOut" + "NS";

            
	    DataTable ttCstMessages = ds.Tables.Add("ttCstMessages");
	    ttCstMessages.Columns.Add("ttType", typeof(string));
	    ttCstMessages.Columns.Add("ttMessageNumber", typeof(string));
	    ttCstMessages.Columns.Add("ttMessage", typeof(string));
	    DataTable ttGetYearOut = ds.Tables.Add("ttGetYearOut");
	    ttGetYearOut.Columns.Add("Year", typeof(int));


            ds.WriteXmlSchema("dsGetYearOut.xsd");

        }


    }
}
