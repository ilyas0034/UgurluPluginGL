
/*
**
*/

//
// dsMessage - Used to generate Strongly Typed DataSet xsd file
//


namespace UgurluPluginGL.Proxy.StrongTypesNS
{
    using System;
    using System.Data;


    public class dsMessageDS
    {

        static void Main (string[] args)
        {
            DataSet ds = new DataSet();
            DataRelation drel;
            DataColumn[] parentCols = null, childCols = null;
            DataColumn[] keyCols = null;

            ds.DataSetName = "dsMessage" + "DataSet";
            ds.Namespace = "dsMessage" + "NS";

            
	    DataTable ttMessageQueue = ds.Tables.Add("ttMessageQueue");
	    ttMessageQueue.Columns.Add("queueOid", typeof(decimal));
	    ttMessageQueue.Columns.Add("queueName", typeof(string));
	    ttMessageQueue.Columns.Add("queueOwner", typeof(string));
	    ttMessageQueue.Columns.Add("queueLabel", typeof(string));
	    ttMessageQueue.Columns.Add("queueDesc", typeof(string));
	    ttMessageQueue.Columns.Add("userQueue", typeof(bool));
	    ttMessageQueue.Columns.Add("deleteQueue", typeof(bool));
	    DataTable ttMessage = ds.Tables.Add("ttMessage");
	    ttMessage.Columns.Add("queueName", typeof(string));
	    ttMessage.Columns.Add("queueOwner", typeof(string));
	    ttMessage.Columns.Add("msgGuid", typeof(string));
	    ttMessage.Columns.Add("msgParentGuid", typeof(string));
	    ttMessage.Columns.Add("msgFrom", typeof(string));
	    ttMessage.Columns.Add("msgTo", typeof(string));
	    ttMessage.Columns.Add("msgCc", typeof(string));
	    ttMessage.Columns.Add("msgBcc", typeof(string));
	    ttMessage.Columns.Add("msgSubject", typeof(string));
	    ttMessage.Columns.Add("msgDateCreated", typeof(System.DateTime));
	    ttMessage.Columns.Add("msgContent", typeof(byte[]));
	    ttMessage.Columns.Add("msgContentType", typeof(string));
	    ttMessage.Columns.Add("msgFlags", typeof(string));
	    DataTable ttAttachment = ds.Tables.Add("ttAttachment");
	    ttAttachment.Columns.Add("msgGuid", typeof(string));
	    ttAttachment.Columns.Add("url", typeof(string));
	    ttAttachment.Columns.Add("filename", typeof(string));
	    ttAttachment.Columns.Add("size", typeof(int));
	    ttAttachment.Columns.Add("mimetype", typeof(string));
		parentCols = new DataColumn[1];
		childCols  = new DataColumn[1];
		parentCols[0] = ds.Tables["ttMessage"].Columns["msgGuid"];
		childCols[0] = ds.Tables["ttAttachment"].Columns["msgGuid"];
		drel = new DataRelation("messageRelation", parentCols, childCols, false);
		ds.Relations.Add(drel);

		parentCols = new DataColumn[2];
		childCols  = new DataColumn[2];
		parentCols[0] = ds.Tables["ttMessageQueue"].Columns["queueName"];
		childCols[0] = ds.Tables["ttMessage"].Columns["queueName"];
		parentCols[1] = ds.Tables["ttMessageQueue"].Columns["queueOwner"];
		childCols[1] = ds.Tables["ttMessage"].Columns["queueOwner"];
		drel = new DataRelation("queueRelation", parentCols, childCols, false);
		ds.Relations.Add(drel);



            ds.WriteXmlSchema("dsMessage.xsd");

        }


    }
}
