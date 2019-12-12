
/*
**
*/

//
// dsGetPeriodIn - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsGetPeriodInDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsGetPeriodIn" + "DataSet";
            ds.Namespace = "dsGetPeriodIn" + "NS";

            
	    DataTable ttUserInfoTr = ds.Tables.Add("ttUserInfoTr");
	    ttUserInfoTr.Columns.Add("ttUser", typeof(string));
	    ttUserInfoTr.Columns.Add("ttUserLang", typeof(string));
	    DataTable ttGetPeriodIn = ds.Tables.Add("ttGetPeriodIn");
	    ttGetPeriodIn.Columns.Add("Year", typeof(int));
	    ttGetPeriodIn.Columns.Add("Company_ID", typeof(int));


            ds.WriteXmlSchema("dsGetPeriodIn.xsd");

        }


    }
}
