
/*
**
*/

//
// dsSessionContext - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsSessionContextDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsSessionContext" + "DataSet";
            ds.Namespace = "dsSessionContext" + "NS";

            
	    DataTable ttContext = ds.Tables.Add("ttContext");
	    ttContext.Columns.Add("propertyQualifier", typeof(string));
	    ttContext.Columns.Add("propertyName", typeof(string));
	    ttContext.Columns.Add("propertyValue", typeof(string));

	    keyCols = new DataColumn[2];
	    keyCols[0] = ttContext.Columns["propertyQualifier"];
	    keyCols[1] = ttContext.Columns["propertyName"];
	    ttContext.Constraints.Add(new System.Data.UniqueConstraint("entityContext", keyCols, true));


            ds.WriteXmlSchema("dsSessionContext.xsd");

        }


    }
}
