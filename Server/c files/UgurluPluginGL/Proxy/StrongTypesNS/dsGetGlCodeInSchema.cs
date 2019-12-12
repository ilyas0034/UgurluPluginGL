
/*
**
*/

//
// dsGetGlCodeIn - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsGetGlCodeInDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsGetGlCodeIn" + "DataSet";
            ds.Namespace = "dsGetGlCodeIn" + "NS";

            
	    DataTable ttUserInfoTr = ds.Tables.Add("ttUserInfoTr");
	    ttUserInfoTr.Columns.Add("ttUser", typeof(string));
	    ttUserInfoTr.Columns.Add("ttUserLang", typeof(string));
	    DataTable ttGetGlCodeIn = ds.Tables.Add("ttGetGlCodeIn");
	    ttGetGlCodeIn.Columns.Add("GLCode", typeof(string));


            ds.WriteXmlSchema("dsGetGlCodeIn.xsd");

        }


    }
}
