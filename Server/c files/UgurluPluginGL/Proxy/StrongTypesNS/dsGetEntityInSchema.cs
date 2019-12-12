
/*
**
*/

//
// dsGetEntityIn - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsGetEntityInDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsGetEntityIn" + "DataSet";
            ds.Namespace = "dsGetEntityIn" + "NS";

            
	    DataTable ttUserInfoTr = ds.Tables.Add("ttUserInfoTr");
	    ttUserInfoTr.Columns.Add("ttUser", typeof(string));
	    ttUserInfoTr.Columns.Add("ttUserLang", typeof(string));
	    DataTable ttGetEntityIn = ds.Tables.Add("ttGetEntityIn");
	    ttGetEntityIn.Columns.Add("CompanyCode", typeof(string));


            ds.WriteXmlSchema("dsGetEntityIn.xsd");

        }


    }
}
