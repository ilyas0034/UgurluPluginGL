
/*
**
*/

//
// dsGetYearIn - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsGetYearInDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsGetYearIn" + "DataSet";
            ds.Namespace = "dsGetYearIn" + "NS";

            
	    DataTable ttUserInfoTr = ds.Tables.Add("ttUserInfoTr");
	    ttUserInfoTr.Columns.Add("ttUser", typeof(string));
	    ttUserInfoTr.Columns.Add("ttUserLang", typeof(string));
	    DataTable ttGetYearIn = ds.Tables.Add("ttGetYearIn");
	    ttGetYearIn.Columns.Add("Company_ID", typeof(int));


            ds.WriteXmlSchema("dsGetYearIn.xsd");

        }


    }
}
