
/*
**
*/

//
// dsGetGlCodeOut - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsGetGlCodeOutDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsGetGlCodeOut" + "DataSet";
            ds.Namespace = "dsGetGlCodeOut" + "NS";

            
	    DataTable ttCstMessages = ds.Tables.Add("ttCstMessages");
	    ttCstMessages.Columns.Add("ttType", typeof(string));
	    ttCstMessages.Columns.Add("ttMessageNumber", typeof(string));
	    ttCstMessages.Columns.Add("ttMessage", typeof(string));
	    DataTable ttGetGlCodeOut = ds.Tables.Add("ttGetGlCodeOut");
	    ttGetGlCodeOut.Columns.Add("GL_ID", typeof(int));
	    ttGetGlCodeOut.Columns.Add("GLCode", typeof(string));


            ds.WriteXmlSchema("dsGetGlCodeOut.xsd");

        }


    }
}
