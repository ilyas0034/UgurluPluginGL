
/*
**
**    Created by PROGRESS ProxyGen (Progress Version 11.7) Wed Dec 04 11:36:04 EET 2019
**
*/

//
// ProxyService
//


namespace UgurluPluginGL.Proxy
{
    using System;
    using Progress.Open4GL;
    using Progress.Open4GL.Exceptions;
    using Progress.Open4GL.Proxy;
    using Progress.Open4GL.DynamicAPI;
    using Progress.Common.EhnLog;
    using System.Collections.Specialized;
    using System.Configuration;

    /// <summary>
    /// 
    /// 
    /// 
    /// </summary>
    public class ProxyService : AppObject
    {
        private static int proxyGenVersion = 1;
        private const  int PROXY_VER = 5;

    // Create a MetaData object for each temp-table parm used in any and all methods.
    // Create a Schema object for each method call that has temp-table parms which
    // points to one or more temp-tables used in that method call.


	static DataSetMetaData createbudget_a_DSMetaData1;

	static DataTableMetaData createbudget_a_MetaData11;

	static DataSetMetaData createbudget_a_DSMetaData2;

	static DataTableMetaData createbudget_a_MetaData21;

	static DataTableMetaData createbudget_a_MetaData22;

	static DataSetMetaData createbudget_a_DSMetaData3;

	static DataTableMetaData createbudget_a_MetaData31;

	static DataTableMetaData createbudget_a_MetaData32;

	static DataTableMetaData createbudget_a_MetaData33;

	static DataRelationMetaData createbudget_a_MetaLink31;

	static DataRelationMetaData createbudget_a_MetaLink32;

	static DataSetMetaData createbudget_a_DSMetaData4;

	static DataTableMetaData createbudget_a_MetaData41;

	static DataTableMetaData createbudget_a_MetaData42;



	static DataSetMetaData getbudget_a_DSMetaData1;

	static DataTableMetaData getbudget_a_MetaData11;

	static DataSetMetaData getbudget_a_DSMetaData2;

	static DataTableMetaData getbudget_a_MetaData21;

	static DataTableMetaData getbudget_a_MetaData22;

	static DataSetMetaData getbudget_a_DSMetaData3;

	static DataTableMetaData getbudget_a_MetaData31;

	static DataTableMetaData getbudget_a_MetaData32;

	static DataTableMetaData getbudget_a_MetaData33;

	static DataRelationMetaData getbudget_a_MetaLink31;

	static DataRelationMetaData getbudget_a_MetaLink32;

	static DataSetMetaData getbudget_a_DSMetaData4;

	static DataTableMetaData getbudget_a_MetaData41;

	static DataTableMetaData getbudget_a_MetaData42;



	static DataSetMetaData getentity_a_DSMetaData1;

	static DataTableMetaData getentity_a_MetaData11;

	static DataSetMetaData getentity_a_DSMetaData2;

	static DataTableMetaData getentity_a_MetaData21;

	static DataTableMetaData getentity_a_MetaData22;

	static DataSetMetaData getentity_a_DSMetaData3;

	static DataTableMetaData getentity_a_MetaData31;

	static DataTableMetaData getentity_a_MetaData32;

	static DataTableMetaData getentity_a_MetaData33;

	static DataRelationMetaData getentity_a_MetaLink31;

	static DataRelationMetaData getentity_a_MetaLink32;

	static DataSetMetaData getentity_a_DSMetaData4;

	static DataTableMetaData getentity_a_MetaData41;

	static DataTableMetaData getentity_a_MetaData42;



	static DataSetMetaData getglcode_a_DSMetaData1;

	static DataTableMetaData getglcode_a_MetaData11;

	static DataSetMetaData getglcode_a_DSMetaData2;

	static DataTableMetaData getglcode_a_MetaData21;

	static DataTableMetaData getglcode_a_MetaData22;

	static DataSetMetaData getglcode_a_DSMetaData3;

	static DataTableMetaData getglcode_a_MetaData31;

	static DataTableMetaData getglcode_a_MetaData32;

	static DataTableMetaData getglcode_a_MetaData33;

	static DataRelationMetaData getglcode_a_MetaLink31;

	static DataRelationMetaData getglcode_a_MetaLink32;

	static DataSetMetaData getglcode_a_DSMetaData4;

	static DataTableMetaData getglcode_a_MetaData41;

	static DataTableMetaData getglcode_a_MetaData42;



	static DataSetMetaData getperiod_a_DSMetaData1;

	static DataTableMetaData getperiod_a_MetaData11;

	static DataSetMetaData getperiod_a_DSMetaData2;

	static DataTableMetaData getperiod_a_MetaData21;

	static DataTableMetaData getperiod_a_MetaData22;

	static DataSetMetaData getperiod_a_DSMetaData3;

	static DataTableMetaData getperiod_a_MetaData31;

	static DataTableMetaData getperiod_a_MetaData32;

	static DataTableMetaData getperiod_a_MetaData33;

	static DataRelationMetaData getperiod_a_MetaLink31;

	static DataRelationMetaData getperiod_a_MetaLink32;

	static DataSetMetaData getperiod_a_DSMetaData4;

	static DataTableMetaData getperiod_a_MetaData41;

	static DataTableMetaData getperiod_a_MetaData42;



	static DataSetMetaData getyear_a_DSMetaData1;

	static DataTableMetaData getyear_a_MetaData11;

	static DataSetMetaData getyear_a_DSMetaData2;

	static DataTableMetaData getyear_a_MetaData21;

	static DataTableMetaData getyear_a_MetaData22;

	static DataSetMetaData getyear_a_DSMetaData3;

	static DataTableMetaData getyear_a_MetaData31;

	static DataTableMetaData getyear_a_MetaData32;

	static DataTableMetaData getyear_a_MetaData33;

	static DataRelationMetaData getyear_a_MetaLink31;

	static DataRelationMetaData getyear_a_MetaLink32;

	static DataSetMetaData getyear_a_DSMetaData4;

	static DataTableMetaData getyear_a_MetaData41;

	static DataTableMetaData getyear_a_MetaData42;




        static ProxyService()
        {
		createbudget_a_DSMetaData1 = new DataSetMetaData(0, "dsSessionContext", 1, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		createbudget_a_MetaData11 = new DataTableMetaData(0, "ttContext", 3, false, 1, "1,propertyQualifier,propertyName:entityContext", null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet+ttContextDataTable");
		createbudget_a_MetaData11.setFieldDesc(1, "propertyQualifier", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		createbudget_a_MetaData11.setFieldDesc(2, "propertyName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		createbudget_a_MetaData11.setFieldDesc(3, "propertyValue", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		createbudget_a_DSMetaData1.addDataTable(createbudget_a_MetaData11);
		createbudget_a_DSMetaData2 = new DataSetMetaData(0, "dsCreateBudgetIn", 2, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetInDataSet");
		createbudget_a_MetaData21 = new DataTableMetaData(0, "ttUserInfoTr", 2, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetInDataSet+ttUserInfoTrDataTable");
		createbudget_a_MetaData21.setFieldDesc(1, "ttUser", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		createbudget_a_MetaData21.setFieldDesc(2, "ttUserLang", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		createbudget_a_DSMetaData2.addDataTable(createbudget_a_MetaData21);
		createbudget_a_MetaData22 = new DataTableMetaData(0, "ttCreateBudgetIn", 6, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetInDataSet+ttCreateBudgetInDataTable");
		createbudget_a_MetaData22.setFieldDesc(1, "ID", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		createbudget_a_MetaData22.setFieldDesc(2, "Period", 0, Parameter.PRO_INTEGER, 0, 1, 0, "", "", 0, null, "");
		createbudget_a_MetaData22.setFieldDesc(3, "GLCode", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		createbudget_a_MetaData22.setFieldDesc(4, "Amount", 0, Parameter.PRO_DECIMAL, 0, 3, 0, "", "", 0, null, "");
		createbudget_a_MetaData22.setFieldDesc(5, "CompanyCode", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		createbudget_a_MetaData22.setFieldDesc(6, "Year", 0, Parameter.PRO_INTEGER, 0, 5, 0, "", "", 0, null, "");
		createbudget_a_DSMetaData2.addDataTable(createbudget_a_MetaData22);
		createbudget_a_DSMetaData3 = new DataSetMetaData(0, "dsMessage", 3, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		createbudget_a_MetaData31 = new DataTableMetaData(0, "ttMessageQueue", 7, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageQueueDataTable");
		createbudget_a_MetaData31.setFieldDesc(1, "queueOid", 0, Parameter.PRO_DECIMAL, 0, 0, 0, "", "", 0, null, "");
		createbudget_a_MetaData31.setFieldDesc(2, "queueName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		createbudget_a_MetaData31.setFieldDesc(3, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		createbudget_a_MetaData31.setFieldDesc(4, "queueLabel", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		createbudget_a_MetaData31.setFieldDesc(5, "queueDesc", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		createbudget_a_MetaData31.setFieldDesc(6, "userQueue", 0, Parameter.PRO_LOGICAL, 0, 5, 0, "", "", 0, null, "");
		createbudget_a_MetaData31.setFieldDesc(7, "deleteQueue", 0, Parameter.PRO_LOGICAL, 0, 6, 0, "", "", 0, null, "");
		createbudget_a_DSMetaData3.addDataTable(createbudget_a_MetaData31);
		createbudget_a_MetaData32 = new DataTableMetaData(0, "ttMessage", 13, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageDataTable");
		createbudget_a_MetaData32.setFieldDesc(1, "queueName", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(2, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(3, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(4, "msgParentGuid", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(5, "msgFrom", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(6, "msgTo", 0, Parameter.PRO_CHARACTER, 0, 5, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(7, "msgCc", 0, Parameter.PRO_CHARACTER, 0, 6, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(8, "msgBcc", 0, Parameter.PRO_CHARACTER, 0, 7, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(9, "msgSubject", 0, Parameter.PRO_CHARACTER, 0, 8, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(10, "msgDateCreated", 0, Parameter.PRO_DATETIMETZ, 0, 9, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(11, "msgContent", 0, Parameter.PRO_BLOB, 0, 10, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(12, "msgContentType", 0, Parameter.PRO_CHARACTER, 0, 11, 0, "", "", 0, null, "");
		createbudget_a_MetaData32.setFieldDesc(13, "msgFlags", 0, Parameter.PRO_CHARACTER, 0, 12, 0, "", "", 0, null, "");
		createbudget_a_DSMetaData3.addDataTable(createbudget_a_MetaData32);
		createbudget_a_MetaData33 = new DataTableMetaData(0, "ttAttachment", 5, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttAttachmentDataTable");
		createbudget_a_MetaData33.setFieldDesc(1, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		createbudget_a_MetaData33.setFieldDesc(2, "url", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		createbudget_a_MetaData33.setFieldDesc(3, "filename", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		createbudget_a_MetaData33.setFieldDesc(4, "size", 0, Parameter.PRO_INTEGER, 0, 3, 0, "", "", 0, null, "");
		createbudget_a_MetaData33.setFieldDesc(5, "mimetype", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		createbudget_a_DSMetaData3.addDataTable(createbudget_a_MetaData33);
		createbudget_a_MetaLink31 = new DataRelationMetaData("messageRelation", 1, 2, 1, "msgGuid,msgGuid", 2, null);
		createbudget_a_DSMetaData3.addDataRelation(createbudget_a_MetaLink31);
		createbudget_a_MetaLink32 = new DataRelationMetaData("queueRelation", 0, 1, 2, "queueName,queueName,queueOwner,queueOwner", 2, null);
		createbudget_a_DSMetaData3.addDataRelation(createbudget_a_MetaLink32);
		createbudget_a_DSMetaData4 = new DataSetMetaData(0, "dsCreateBudgetOut", 4, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet");
		createbudget_a_MetaData41 = new DataTableMetaData(0, "ttCstMessages", 3, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet+ttCstMessagesDataTable");
		createbudget_a_MetaData41.setFieldDesc(1, "ttType", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		createbudget_a_MetaData41.setFieldDesc(2, "ttMessageNumber", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		createbudget_a_MetaData41.setFieldDesc(3, "ttMessage", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		createbudget_a_DSMetaData4.addDataTable(createbudget_a_MetaData41);
		createbudget_a_MetaData42 = new DataTableMetaData(0, "ttCreateBudgetOut", 6, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet+ttCreateBudgetOutDataTable");
		createbudget_a_MetaData42.setFieldDesc(1, "ID", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		createbudget_a_MetaData42.setFieldDesc(2, "Period", 0, Parameter.PRO_INTEGER, 0, 1, 0, "", "", 0, null, "");
		createbudget_a_MetaData42.setFieldDesc(3, "GLCode", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		createbudget_a_MetaData42.setFieldDesc(4, "Amount", 0, Parameter.PRO_DECIMAL, 0, 3, 0, "", "", 0, null, "");
		createbudget_a_MetaData42.setFieldDesc(5, "CompanyCode", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		createbudget_a_MetaData42.setFieldDesc(6, "Year", 0, Parameter.PRO_INTEGER, 0, 5, 0, "", "", 0, null, "");
		createbudget_a_DSMetaData4.addDataTable(createbudget_a_MetaData42);

		getbudget_a_DSMetaData1 = new DataSetMetaData(0, "dsSessionContext", 1, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		getbudget_a_MetaData11 = new DataTableMetaData(0, "ttContext", 3, false, 1, "1,propertyQualifier,propertyName:entityContext", null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet+ttContextDataTable");
		getbudget_a_MetaData11.setFieldDesc(1, "propertyQualifier", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getbudget_a_MetaData11.setFieldDesc(2, "propertyName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getbudget_a_MetaData11.setFieldDesc(3, "propertyValue", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getbudget_a_DSMetaData1.addDataTable(getbudget_a_MetaData11);
		getbudget_a_DSMetaData2 = new DataSetMetaData(0, "dsCreateBudgetIn", 2, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetInDataSet");
		getbudget_a_MetaData21 = new DataTableMetaData(0, "ttUserInfoTr", 2, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetInDataSet+ttUserInfoTrDataTable");
		getbudget_a_MetaData21.setFieldDesc(1, "ttUser", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getbudget_a_MetaData21.setFieldDesc(2, "ttUserLang", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getbudget_a_DSMetaData2.addDataTable(getbudget_a_MetaData21);
		getbudget_a_MetaData22 = new DataTableMetaData(0, "ttCreateBudgetIn", 6, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetInDataSet+ttCreateBudgetInDataTable");
		getbudget_a_MetaData22.setFieldDesc(1, "ID", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getbudget_a_MetaData22.setFieldDesc(2, "Period", 0, Parameter.PRO_INTEGER, 0, 1, 0, "", "", 0, null, "");
		getbudget_a_MetaData22.setFieldDesc(3, "GLCode", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getbudget_a_MetaData22.setFieldDesc(4, "Amount", 0, Parameter.PRO_DECIMAL, 0, 3, 0, "", "", 0, null, "");
		getbudget_a_MetaData22.setFieldDesc(5, "CompanyCode", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getbudget_a_MetaData22.setFieldDesc(6, "Year", 0, Parameter.PRO_INTEGER, 0, 5, 0, "", "", 0, null, "");
		getbudget_a_DSMetaData2.addDataTable(getbudget_a_MetaData22);
		getbudget_a_DSMetaData3 = new DataSetMetaData(0, "dsMessage", 3, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		getbudget_a_MetaData31 = new DataTableMetaData(0, "ttMessageQueue", 7, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageQueueDataTable");
		getbudget_a_MetaData31.setFieldDesc(1, "queueOid", 0, Parameter.PRO_DECIMAL, 0, 0, 0, "", "", 0, null, "");
		getbudget_a_MetaData31.setFieldDesc(2, "queueName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getbudget_a_MetaData31.setFieldDesc(3, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getbudget_a_MetaData31.setFieldDesc(4, "queueLabel", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		getbudget_a_MetaData31.setFieldDesc(5, "queueDesc", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getbudget_a_MetaData31.setFieldDesc(6, "userQueue", 0, Parameter.PRO_LOGICAL, 0, 5, 0, "", "", 0, null, "");
		getbudget_a_MetaData31.setFieldDesc(7, "deleteQueue", 0, Parameter.PRO_LOGICAL, 0, 6, 0, "", "", 0, null, "");
		getbudget_a_DSMetaData3.addDataTable(getbudget_a_MetaData31);
		getbudget_a_MetaData32 = new DataTableMetaData(0, "ttMessage", 13, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageDataTable");
		getbudget_a_MetaData32.setFieldDesc(1, "queueName", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(2, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(3, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(4, "msgParentGuid", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(5, "msgFrom", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(6, "msgTo", 0, Parameter.PRO_CHARACTER, 0, 5, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(7, "msgCc", 0, Parameter.PRO_CHARACTER, 0, 6, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(8, "msgBcc", 0, Parameter.PRO_CHARACTER, 0, 7, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(9, "msgSubject", 0, Parameter.PRO_CHARACTER, 0, 8, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(10, "msgDateCreated", 0, Parameter.PRO_DATETIMETZ, 0, 9, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(11, "msgContent", 0, Parameter.PRO_BLOB, 0, 10, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(12, "msgContentType", 0, Parameter.PRO_CHARACTER, 0, 11, 0, "", "", 0, null, "");
		getbudget_a_MetaData32.setFieldDesc(13, "msgFlags", 0, Parameter.PRO_CHARACTER, 0, 12, 0, "", "", 0, null, "");
		getbudget_a_DSMetaData3.addDataTable(getbudget_a_MetaData32);
		getbudget_a_MetaData33 = new DataTableMetaData(0, "ttAttachment", 5, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttAttachmentDataTable");
		getbudget_a_MetaData33.setFieldDesc(1, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getbudget_a_MetaData33.setFieldDesc(2, "url", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getbudget_a_MetaData33.setFieldDesc(3, "filename", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getbudget_a_MetaData33.setFieldDesc(4, "size", 0, Parameter.PRO_INTEGER, 0, 3, 0, "", "", 0, null, "");
		getbudget_a_MetaData33.setFieldDesc(5, "mimetype", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getbudget_a_DSMetaData3.addDataTable(getbudget_a_MetaData33);
		getbudget_a_MetaLink31 = new DataRelationMetaData("messageRelation", 1, 2, 1, "msgGuid,msgGuid", 2, null);
		getbudget_a_DSMetaData3.addDataRelation(getbudget_a_MetaLink31);
		getbudget_a_MetaLink32 = new DataRelationMetaData("queueRelation", 0, 1, 2, "queueName,queueName,queueOwner,queueOwner", 2, null);
		getbudget_a_DSMetaData3.addDataRelation(getbudget_a_MetaLink32);
		getbudget_a_DSMetaData4 = new DataSetMetaData(0, "dsCreateBudgetOut", 4, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet");
		getbudget_a_MetaData41 = new DataTableMetaData(0, "ttCstMessages", 3, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet+ttCstMessagesDataTable");
		getbudget_a_MetaData41.setFieldDesc(1, "ttType", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getbudget_a_MetaData41.setFieldDesc(2, "ttMessageNumber", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getbudget_a_MetaData41.setFieldDesc(3, "ttMessage", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getbudget_a_DSMetaData4.addDataTable(getbudget_a_MetaData41);
		getbudget_a_MetaData42 = new DataTableMetaData(0, "ttCreateBudgetOut", 6, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet+ttCreateBudgetOutDataTable");
		getbudget_a_MetaData42.setFieldDesc(1, "ID", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getbudget_a_MetaData42.setFieldDesc(2, "Period", 0, Parameter.PRO_INTEGER, 0, 1, 0, "", "", 0, null, "");
		getbudget_a_MetaData42.setFieldDesc(3, "GLCode", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getbudget_a_MetaData42.setFieldDesc(4, "Amount", 0, Parameter.PRO_DECIMAL, 0, 3, 0, "", "", 0, null, "");
		getbudget_a_MetaData42.setFieldDesc(5, "CompanyCode", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getbudget_a_MetaData42.setFieldDesc(6, "Year", 0, Parameter.PRO_INTEGER, 0, 5, 0, "", "", 0, null, "");
		getbudget_a_DSMetaData4.addDataTable(getbudget_a_MetaData42);

		getentity_a_DSMetaData1 = new DataSetMetaData(0, "dsSessionContext", 1, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		getentity_a_MetaData11 = new DataTableMetaData(0, "ttContext", 3, false, 1, "1,propertyQualifier,propertyName:entityContext", null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet+ttContextDataTable");
		getentity_a_MetaData11.setFieldDesc(1, "propertyQualifier", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getentity_a_MetaData11.setFieldDesc(2, "propertyName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getentity_a_MetaData11.setFieldDesc(3, "propertyValue", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getentity_a_DSMetaData1.addDataTable(getentity_a_MetaData11);
		getentity_a_DSMetaData2 = new DataSetMetaData(0, "dsGetEntityIn", 2, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityInDataSet");
		getentity_a_MetaData21 = new DataTableMetaData(0, "ttUserInfoTr", 2, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityInDataSet+ttUserInfoTrDataTable");
		getentity_a_MetaData21.setFieldDesc(1, "ttUser", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getentity_a_MetaData21.setFieldDesc(2, "ttUserLang", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getentity_a_DSMetaData2.addDataTable(getentity_a_MetaData21);
		getentity_a_MetaData22 = new DataTableMetaData(0, "ttGetEntityIn", 1, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityInDataSet+ttGetEntityInDataTable");
		getentity_a_MetaData22.setFieldDesc(1, "CompanyCode", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getentity_a_DSMetaData2.addDataTable(getentity_a_MetaData22);
		getentity_a_DSMetaData3 = new DataSetMetaData(0, "dsMessage", 3, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		getentity_a_MetaData31 = new DataTableMetaData(0, "ttMessageQueue", 7, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageQueueDataTable");
		getentity_a_MetaData31.setFieldDesc(1, "queueOid", 0, Parameter.PRO_DECIMAL, 0, 0, 0, "", "", 0, null, "");
		getentity_a_MetaData31.setFieldDesc(2, "queueName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getentity_a_MetaData31.setFieldDesc(3, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getentity_a_MetaData31.setFieldDesc(4, "queueLabel", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		getentity_a_MetaData31.setFieldDesc(5, "queueDesc", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getentity_a_MetaData31.setFieldDesc(6, "userQueue", 0, Parameter.PRO_LOGICAL, 0, 5, 0, "", "", 0, null, "");
		getentity_a_MetaData31.setFieldDesc(7, "deleteQueue", 0, Parameter.PRO_LOGICAL, 0, 6, 0, "", "", 0, null, "");
		getentity_a_DSMetaData3.addDataTable(getentity_a_MetaData31);
		getentity_a_MetaData32 = new DataTableMetaData(0, "ttMessage", 13, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageDataTable");
		getentity_a_MetaData32.setFieldDesc(1, "queueName", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(2, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(3, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(4, "msgParentGuid", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(5, "msgFrom", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(6, "msgTo", 0, Parameter.PRO_CHARACTER, 0, 5, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(7, "msgCc", 0, Parameter.PRO_CHARACTER, 0, 6, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(8, "msgBcc", 0, Parameter.PRO_CHARACTER, 0, 7, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(9, "msgSubject", 0, Parameter.PRO_CHARACTER, 0, 8, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(10, "msgDateCreated", 0, Parameter.PRO_DATETIMETZ, 0, 9, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(11, "msgContent", 0, Parameter.PRO_BLOB, 0, 10, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(12, "msgContentType", 0, Parameter.PRO_CHARACTER, 0, 11, 0, "", "", 0, null, "");
		getentity_a_MetaData32.setFieldDesc(13, "msgFlags", 0, Parameter.PRO_CHARACTER, 0, 12, 0, "", "", 0, null, "");
		getentity_a_DSMetaData3.addDataTable(getentity_a_MetaData32);
		getentity_a_MetaData33 = new DataTableMetaData(0, "ttAttachment", 5, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttAttachmentDataTable");
		getentity_a_MetaData33.setFieldDesc(1, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getentity_a_MetaData33.setFieldDesc(2, "url", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getentity_a_MetaData33.setFieldDesc(3, "filename", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getentity_a_MetaData33.setFieldDesc(4, "size", 0, Parameter.PRO_INTEGER, 0, 3, 0, "", "", 0, null, "");
		getentity_a_MetaData33.setFieldDesc(5, "mimetype", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getentity_a_DSMetaData3.addDataTable(getentity_a_MetaData33);
		getentity_a_MetaLink31 = new DataRelationMetaData("messageRelation", 1, 2, 1, "msgGuid,msgGuid", 2, null);
		getentity_a_DSMetaData3.addDataRelation(getentity_a_MetaLink31);
		getentity_a_MetaLink32 = new DataRelationMetaData("queueRelation", 0, 1, 2, "queueName,queueName,queueOwner,queueOwner", 2, null);
		getentity_a_DSMetaData3.addDataRelation(getentity_a_MetaLink32);
		getentity_a_DSMetaData4 = new DataSetMetaData(0, "dsGetEntityOut", 4, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityOutDataSet");
		getentity_a_MetaData41 = new DataTableMetaData(0, "ttCstMessages", 3, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityOutDataSet+ttCstMessagesDataTable");
		getentity_a_MetaData41.setFieldDesc(1, "ttType", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getentity_a_MetaData41.setFieldDesc(2, "ttMessageNumber", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getentity_a_MetaData41.setFieldDesc(3, "ttMessage", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getentity_a_DSMetaData4.addDataTable(getentity_a_MetaData41);
		getentity_a_MetaData42 = new DataTableMetaData(0, "ttGetEntityOut", 2, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityOutDataSet+ttGetEntityOutDataTable");
		getentity_a_MetaData42.setFieldDesc(1, "CompanyCode", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getentity_a_MetaData42.setFieldDesc(2, "Company_ID", 0, Parameter.PRO_INTEGER, 0, 1, 0, "", "", 0, null, "");
		getentity_a_DSMetaData4.addDataTable(getentity_a_MetaData42);

		getglcode_a_DSMetaData1 = new DataSetMetaData(0, "dsSessionContext", 1, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		getglcode_a_MetaData11 = new DataTableMetaData(0, "ttContext", 3, false, 1, "1,propertyQualifier,propertyName:entityContext", null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet+ttContextDataTable");
		getglcode_a_MetaData11.setFieldDesc(1, "propertyQualifier", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getglcode_a_MetaData11.setFieldDesc(2, "propertyName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getglcode_a_MetaData11.setFieldDesc(3, "propertyValue", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getglcode_a_DSMetaData1.addDataTable(getglcode_a_MetaData11);
		getglcode_a_DSMetaData2 = new DataSetMetaData(0, "dsGetGlCodeIn", 2, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeInDataSet");
		getglcode_a_MetaData21 = new DataTableMetaData(0, "ttUserInfoTr", 2, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeInDataSet+ttUserInfoTrDataTable");
		getglcode_a_MetaData21.setFieldDesc(1, "ttUser", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getglcode_a_MetaData21.setFieldDesc(2, "ttUserLang", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getglcode_a_DSMetaData2.addDataTable(getglcode_a_MetaData21);
		getglcode_a_MetaData22 = new DataTableMetaData(0, "ttGetGlCodeIn", 1, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeInDataSet+ttGetGlCodeInDataTable");
		getglcode_a_MetaData22.setFieldDesc(1, "GLCode", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getglcode_a_DSMetaData2.addDataTable(getglcode_a_MetaData22);
		getglcode_a_DSMetaData3 = new DataSetMetaData(0, "dsMessage", 3, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		getglcode_a_MetaData31 = new DataTableMetaData(0, "ttMessageQueue", 7, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageQueueDataTable");
		getglcode_a_MetaData31.setFieldDesc(1, "queueOid", 0, Parameter.PRO_DECIMAL, 0, 0, 0, "", "", 0, null, "");
		getglcode_a_MetaData31.setFieldDesc(2, "queueName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getglcode_a_MetaData31.setFieldDesc(3, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getglcode_a_MetaData31.setFieldDesc(4, "queueLabel", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		getglcode_a_MetaData31.setFieldDesc(5, "queueDesc", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getglcode_a_MetaData31.setFieldDesc(6, "userQueue", 0, Parameter.PRO_LOGICAL, 0, 5, 0, "", "", 0, null, "");
		getglcode_a_MetaData31.setFieldDesc(7, "deleteQueue", 0, Parameter.PRO_LOGICAL, 0, 6, 0, "", "", 0, null, "");
		getglcode_a_DSMetaData3.addDataTable(getglcode_a_MetaData31);
		getglcode_a_MetaData32 = new DataTableMetaData(0, "ttMessage", 13, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageDataTable");
		getglcode_a_MetaData32.setFieldDesc(1, "queueName", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(2, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(3, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(4, "msgParentGuid", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(5, "msgFrom", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(6, "msgTo", 0, Parameter.PRO_CHARACTER, 0, 5, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(7, "msgCc", 0, Parameter.PRO_CHARACTER, 0, 6, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(8, "msgBcc", 0, Parameter.PRO_CHARACTER, 0, 7, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(9, "msgSubject", 0, Parameter.PRO_CHARACTER, 0, 8, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(10, "msgDateCreated", 0, Parameter.PRO_DATETIMETZ, 0, 9, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(11, "msgContent", 0, Parameter.PRO_BLOB, 0, 10, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(12, "msgContentType", 0, Parameter.PRO_CHARACTER, 0, 11, 0, "", "", 0, null, "");
		getglcode_a_MetaData32.setFieldDesc(13, "msgFlags", 0, Parameter.PRO_CHARACTER, 0, 12, 0, "", "", 0, null, "");
		getglcode_a_DSMetaData3.addDataTable(getglcode_a_MetaData32);
		getglcode_a_MetaData33 = new DataTableMetaData(0, "ttAttachment", 5, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttAttachmentDataTable");
		getglcode_a_MetaData33.setFieldDesc(1, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getglcode_a_MetaData33.setFieldDesc(2, "url", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getglcode_a_MetaData33.setFieldDesc(3, "filename", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getglcode_a_MetaData33.setFieldDesc(4, "size", 0, Parameter.PRO_INTEGER, 0, 3, 0, "", "", 0, null, "");
		getglcode_a_MetaData33.setFieldDesc(5, "mimetype", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getglcode_a_DSMetaData3.addDataTable(getglcode_a_MetaData33);
		getglcode_a_MetaLink31 = new DataRelationMetaData("messageRelation", 1, 2, 1, "msgGuid,msgGuid", 2, null);
		getglcode_a_DSMetaData3.addDataRelation(getglcode_a_MetaLink31);
		getglcode_a_MetaLink32 = new DataRelationMetaData("queueRelation", 0, 1, 2, "queueName,queueName,queueOwner,queueOwner", 2, null);
		getglcode_a_DSMetaData3.addDataRelation(getglcode_a_MetaLink32);
		getglcode_a_DSMetaData4 = new DataSetMetaData(0, "dsGetGlCodeOut", 4, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeOutDataSet");
		getglcode_a_MetaData41 = new DataTableMetaData(0, "ttCstMessages", 3, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeOutDataSet+ttCstMessagesDataTable");
		getglcode_a_MetaData41.setFieldDesc(1, "ttType", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getglcode_a_MetaData41.setFieldDesc(2, "ttMessageNumber", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getglcode_a_MetaData41.setFieldDesc(3, "ttMessage", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getglcode_a_DSMetaData4.addDataTable(getglcode_a_MetaData41);
		getglcode_a_MetaData42 = new DataTableMetaData(0, "ttGetGlCodeOut", 2, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeOutDataSet+ttGetGlCodeOutDataTable");
		getglcode_a_MetaData42.setFieldDesc(1, "GL_ID", 0, Parameter.PRO_INTEGER, 0, 0, 0, "", "", 0, null, "");
		getglcode_a_MetaData42.setFieldDesc(2, "GLCode", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getglcode_a_DSMetaData4.addDataTable(getglcode_a_MetaData42);

		getperiod_a_DSMetaData1 = new DataSetMetaData(0, "dsSessionContext", 1, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		getperiod_a_MetaData11 = new DataTableMetaData(0, "ttContext", 3, false, 1, "1,propertyQualifier,propertyName:entityContext", null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet+ttContextDataTable");
		getperiod_a_MetaData11.setFieldDesc(1, "propertyQualifier", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getperiod_a_MetaData11.setFieldDesc(2, "propertyName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getperiod_a_MetaData11.setFieldDesc(3, "propertyValue", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getperiod_a_DSMetaData1.addDataTable(getperiod_a_MetaData11);
		getperiod_a_DSMetaData2 = new DataSetMetaData(0, "dsGetPeriodIn", 2, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodInDataSet");
		getperiod_a_MetaData21 = new DataTableMetaData(0, "ttUserInfoTr", 2, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodInDataSet+ttUserInfoTrDataTable");
		getperiod_a_MetaData21.setFieldDesc(1, "ttUser", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getperiod_a_MetaData21.setFieldDesc(2, "ttUserLang", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getperiod_a_DSMetaData2.addDataTable(getperiod_a_MetaData21);
		getperiod_a_MetaData22 = new DataTableMetaData(0, "ttGetPeriodIn", 2, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodInDataSet+ttGetPeriodInDataTable");
		getperiod_a_MetaData22.setFieldDesc(1, "Year", 0, Parameter.PRO_INTEGER, 0, 0, 0, "", "", 0, null, "");
		getperiod_a_MetaData22.setFieldDesc(2, "Company_ID", 0, Parameter.PRO_INTEGER, 0, 1, 0, "", "", 0, null, "");
		getperiod_a_DSMetaData2.addDataTable(getperiod_a_MetaData22);
		getperiod_a_DSMetaData3 = new DataSetMetaData(0, "dsMessage", 3, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		getperiod_a_MetaData31 = new DataTableMetaData(0, "ttMessageQueue", 7, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageQueueDataTable");
		getperiod_a_MetaData31.setFieldDesc(1, "queueOid", 0, Parameter.PRO_DECIMAL, 0, 0, 0, "", "", 0, null, "");
		getperiod_a_MetaData31.setFieldDesc(2, "queueName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getperiod_a_MetaData31.setFieldDesc(3, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getperiod_a_MetaData31.setFieldDesc(4, "queueLabel", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		getperiod_a_MetaData31.setFieldDesc(5, "queueDesc", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getperiod_a_MetaData31.setFieldDesc(6, "userQueue", 0, Parameter.PRO_LOGICAL, 0, 5, 0, "", "", 0, null, "");
		getperiod_a_MetaData31.setFieldDesc(7, "deleteQueue", 0, Parameter.PRO_LOGICAL, 0, 6, 0, "", "", 0, null, "");
		getperiod_a_DSMetaData3.addDataTable(getperiod_a_MetaData31);
		getperiod_a_MetaData32 = new DataTableMetaData(0, "ttMessage", 13, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageDataTable");
		getperiod_a_MetaData32.setFieldDesc(1, "queueName", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(2, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(3, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(4, "msgParentGuid", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(5, "msgFrom", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(6, "msgTo", 0, Parameter.PRO_CHARACTER, 0, 5, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(7, "msgCc", 0, Parameter.PRO_CHARACTER, 0, 6, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(8, "msgBcc", 0, Parameter.PRO_CHARACTER, 0, 7, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(9, "msgSubject", 0, Parameter.PRO_CHARACTER, 0, 8, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(10, "msgDateCreated", 0, Parameter.PRO_DATETIMETZ, 0, 9, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(11, "msgContent", 0, Parameter.PRO_BLOB, 0, 10, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(12, "msgContentType", 0, Parameter.PRO_CHARACTER, 0, 11, 0, "", "", 0, null, "");
		getperiod_a_MetaData32.setFieldDesc(13, "msgFlags", 0, Parameter.PRO_CHARACTER, 0, 12, 0, "", "", 0, null, "");
		getperiod_a_DSMetaData3.addDataTable(getperiod_a_MetaData32);
		getperiod_a_MetaData33 = new DataTableMetaData(0, "ttAttachment", 5, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttAttachmentDataTable");
		getperiod_a_MetaData33.setFieldDesc(1, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getperiod_a_MetaData33.setFieldDesc(2, "url", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getperiod_a_MetaData33.setFieldDesc(3, "filename", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getperiod_a_MetaData33.setFieldDesc(4, "size", 0, Parameter.PRO_INTEGER, 0, 3, 0, "", "", 0, null, "");
		getperiod_a_MetaData33.setFieldDesc(5, "mimetype", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getperiod_a_DSMetaData3.addDataTable(getperiod_a_MetaData33);
		getperiod_a_MetaLink31 = new DataRelationMetaData("messageRelation", 1, 2, 1, "msgGuid,msgGuid", 2, null);
		getperiod_a_DSMetaData3.addDataRelation(getperiod_a_MetaLink31);
		getperiod_a_MetaLink32 = new DataRelationMetaData("queueRelation", 0, 1, 2, "queueName,queueName,queueOwner,queueOwner", 2, null);
		getperiod_a_DSMetaData3.addDataRelation(getperiod_a_MetaLink32);
		getperiod_a_DSMetaData4 = new DataSetMetaData(0, "dsGetPeriodOut", 4, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodOutDataSet");
		getperiod_a_MetaData41 = new DataTableMetaData(0, "ttCstMessages", 3, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodOutDataSet+ttCstMessagesDataTable");
		getperiod_a_MetaData41.setFieldDesc(1, "ttType", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getperiod_a_MetaData41.setFieldDesc(2, "ttMessageNumber", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getperiod_a_MetaData41.setFieldDesc(3, "ttMessage", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getperiod_a_DSMetaData4.addDataTable(getperiod_a_MetaData41);
		getperiod_a_MetaData42 = new DataTableMetaData(0, "ttGetPeriodOut", 3, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodOutDataSet+ttGetPeriodOutDataTable");
		getperiod_a_MetaData42.setFieldDesc(1, "Period", 0, Parameter.PRO_INTEGER, 0, 0, 0, "", "", 0, null, "");
		getperiod_a_MetaData42.setFieldDesc(2, "Period_ID", 0, Parameter.PRO_INTEGER, 0, 1, 0, "", "", 0, null, "");
		getperiod_a_MetaData42.setFieldDesc(3, "PeriodYear", 0, Parameter.PRO_INTEGER, 0, 2, 0, "", "", 0, null, "");
		getperiod_a_DSMetaData4.addDataTable(getperiod_a_MetaData42);

		getyear_a_DSMetaData1 = new DataSetMetaData(0, "dsSessionContext", 1, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		getyear_a_MetaData11 = new DataTableMetaData(0, "ttContext", 3, false, 1, "1,propertyQualifier,propertyName:entityContext", null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet+ttContextDataTable");
		getyear_a_MetaData11.setFieldDesc(1, "propertyQualifier", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getyear_a_MetaData11.setFieldDesc(2, "propertyName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getyear_a_MetaData11.setFieldDesc(3, "propertyValue", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getyear_a_DSMetaData1.addDataTable(getyear_a_MetaData11);
		getyear_a_DSMetaData2 = new DataSetMetaData(0, "dsGetYearIn", 2, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearInDataSet");
		getyear_a_MetaData21 = new DataTableMetaData(0, "ttUserInfoTr", 2, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearInDataSet+ttUserInfoTrDataTable");
		getyear_a_MetaData21.setFieldDesc(1, "ttUser", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getyear_a_MetaData21.setFieldDesc(2, "ttUserLang", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getyear_a_DSMetaData2.addDataTable(getyear_a_MetaData21);
		getyear_a_MetaData22 = new DataTableMetaData(0, "ttGetYearIn", 1, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearInDataSet+ttGetYearInDataTable");
		getyear_a_MetaData22.setFieldDesc(1, "Company_ID", 0, Parameter.PRO_INTEGER, 0, 0, 0, "", "", 0, null, "");
		getyear_a_DSMetaData2.addDataTable(getyear_a_MetaData22);
		getyear_a_DSMetaData3 = new DataSetMetaData(0, "dsMessage", 3, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		getyear_a_MetaData31 = new DataTableMetaData(0, "ttMessageQueue", 7, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageQueueDataTable");
		getyear_a_MetaData31.setFieldDesc(1, "queueOid", 0, Parameter.PRO_DECIMAL, 0, 0, 0, "", "", 0, null, "");
		getyear_a_MetaData31.setFieldDesc(2, "queueName", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getyear_a_MetaData31.setFieldDesc(3, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getyear_a_MetaData31.setFieldDesc(4, "queueLabel", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		getyear_a_MetaData31.setFieldDesc(5, "queueDesc", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getyear_a_MetaData31.setFieldDesc(6, "userQueue", 0, Parameter.PRO_LOGICAL, 0, 5, 0, "", "", 0, null, "");
		getyear_a_MetaData31.setFieldDesc(7, "deleteQueue", 0, Parameter.PRO_LOGICAL, 0, 6, 0, "", "", 0, null, "");
		getyear_a_DSMetaData3.addDataTable(getyear_a_MetaData31);
		getyear_a_MetaData32 = new DataTableMetaData(0, "ttMessage", 13, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttMessageDataTable");
		getyear_a_MetaData32.setFieldDesc(1, "queueName", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(2, "queueOwner", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(3, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(4, "msgParentGuid", 0, Parameter.PRO_CHARACTER, 0, 3, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(5, "msgFrom", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(6, "msgTo", 0, Parameter.PRO_CHARACTER, 0, 5, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(7, "msgCc", 0, Parameter.PRO_CHARACTER, 0, 6, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(8, "msgBcc", 0, Parameter.PRO_CHARACTER, 0, 7, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(9, "msgSubject", 0, Parameter.PRO_CHARACTER, 0, 8, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(10, "msgDateCreated", 0, Parameter.PRO_DATETIMETZ, 0, 9, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(11, "msgContent", 0, Parameter.PRO_BLOB, 0, 10, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(12, "msgContentType", 0, Parameter.PRO_CHARACTER, 0, 11, 0, "", "", 0, null, "");
		getyear_a_MetaData32.setFieldDesc(13, "msgFlags", 0, Parameter.PRO_CHARACTER, 0, 12, 0, "", "", 0, null, "");
		getyear_a_DSMetaData3.addDataTable(getyear_a_MetaData32);
		getyear_a_MetaData33 = new DataTableMetaData(0, "ttAttachment", 5, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet+ttAttachmentDataTable");
		getyear_a_MetaData33.setFieldDesc(1, "msgGuid", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getyear_a_MetaData33.setFieldDesc(2, "url", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getyear_a_MetaData33.setFieldDesc(3, "filename", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getyear_a_MetaData33.setFieldDesc(4, "size", 0, Parameter.PRO_INTEGER, 0, 3, 0, "", "", 0, null, "");
		getyear_a_MetaData33.setFieldDesc(5, "mimetype", 0, Parameter.PRO_CHARACTER, 0, 4, 0, "", "", 0, null, "");
		getyear_a_DSMetaData3.addDataTable(getyear_a_MetaData33);
		getyear_a_MetaLink31 = new DataRelationMetaData("messageRelation", 1, 2, 1, "msgGuid,msgGuid", 2, null);
		getyear_a_DSMetaData3.addDataRelation(getyear_a_MetaLink31);
		getyear_a_MetaLink32 = new DataRelationMetaData("queueRelation", 0, 1, 2, "queueName,queueName,queueOwner,queueOwner", 2, null);
		getyear_a_DSMetaData3.addDataRelation(getyear_a_MetaLink32);
		getyear_a_DSMetaData4 = new DataSetMetaData(0, "dsGetYearOut", 4, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearOutDataSet");
		getyear_a_MetaData41 = new DataTableMetaData(0, "ttCstMessages", 3, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearOutDataSet+ttCstMessagesDataTable");
		getyear_a_MetaData41.setFieldDesc(1, "ttType", 0, Parameter.PRO_CHARACTER, 0, 0, 0, "", "", 0, null, "");
		getyear_a_MetaData41.setFieldDesc(2, "ttMessageNumber", 0, Parameter.PRO_CHARACTER, 0, 1, 0, "", "", 0, null, "");
		getyear_a_MetaData41.setFieldDesc(3, "ttMessage", 0, Parameter.PRO_CHARACTER, 0, 2, 0, "", "", 0, null, "");
		getyear_a_DSMetaData4.addDataTable(getyear_a_MetaData41);
		getyear_a_MetaData42 = new DataTableMetaData(0, "ttGetYearOut", 1, false, 0, null, null, null, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearOutDataSet+ttGetYearOutDataTable");
		getyear_a_MetaData42.setFieldDesc(1, "Year", 0, Parameter.PRO_INTEGER, 0, 0, 0, "", "", 0, null, "");
		getyear_a_DSMetaData4.addDataTable(getyear_a_MetaData42);


        }


    //---- Constructors
    public ProxyService(Connection connectObj) : this(connectObj, false)
    {       
    }
    
    // If useWebConfigFile = true, we are creating AppObject to use with Silverlight proxy
    public ProxyService(Connection connectObj, bool useWebConfigFile)
    {
        try
        {
            if (RunTimeProperties.DynamicApiVersion != PROXY_VER)
                throw new Open4GLException(WrongProxyVer, null);

            if ((connectObj.Url == null) || (connectObj.Url.Equals("")))
                connectObj.Url = "ProxyService";

            if (useWebConfigFile == true)
                connectObj.GetWebConfigFileInfo("ProxyService");

            initAppObject("ProxyService",
                          connectObj,
                          RunTimeProperties.tracer,
                          null, // requestID
                          proxyGenVersion);

        }
        catch (System.Exception e)
        {
            throw e;
        }
    }
   
    public ProxyService(string urlString,
                        string userId,
                        string password,
                        string appServerInfo)
    {
        Connection connectObj;

        try
        {
            if (RunTimeProperties.DynamicApiVersion != PROXY_VER)
                throw new Open4GLException(WrongProxyVer, null);

            connectObj = new Connection(urlString,
                                        userId,
                                        password,
                                        appServerInfo);

            initAppObject("ProxyService",
                          connectObj,
                          RunTimeProperties.tracer,
                          null, // requestID
                          proxyGenVersion);

            /* release the connection since the connection object */
            /* is being destroyed.  the user can't do this        */
            connectObj.ReleaseConnection();

        }
        catch (System.Exception e)
        {
            throw e;
        }
    }


    public ProxyService(string userId,
                        string password,
                        string appServerInfo)
    {
        Connection connectObj;

        try
        {
            if (RunTimeProperties.DynamicApiVersion != PROXY_VER)
                throw new Open4GLException(WrongProxyVer, null);

            connectObj = new Connection("ProxyService",
                                        userId,
                                        password,
                                        appServerInfo);

            initAppObject("ProxyService",
                          connectObj,
                          RunTimeProperties.tracer,
                          null, // requestID
                          proxyGenVersion);

            /* release the connection since the connection object */
            /* is being destroyed.  the user can't do this        */
            connectObj.ReleaseConnection();
        }
        catch (System.Exception e)
        {
            throw e;
        }
    }

    public ProxyService()
    {
        Connection connectObj;

        try
        {
            if (RunTimeProperties.DynamicApiVersion != PROXY_VER)
                throw new Open4GLException(WrongProxyVer, null);

            connectObj = new Connection("ProxyService",
                                        null,
                                        null,
                                        null);

            initAppObject("ProxyService",
                          connectObj,
                          RunTimeProperties.tracer,
                          null, // requestID
                          proxyGenVersion);

            /* release the connection since the connection object */
            /* is being destroyed.  the user can't do this        */
            connectObj.ReleaseConnection();
        }
        catch (System.Exception e)
        {
            throw e;
        }
    }

        /// <summary>
	/// 
	/// </summary> 
	public string createbudget_a(UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet dsSessionContext, UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetInDataSet dsCreateBudgetIn, out UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet dsMessage, out UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet dsCreateBudgetOut)
	{
		RqContext rqCtx = null;
		if (isSessionAvailable() == false)
			throw new Open4GLException(NotAvailable, null);

		Object outValue;
		ParameterSet parms = new ParameterSet(4);

		// Set up input parameters
		parms.setDataSetParameter(1, dsSessionContext, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		parms.setDataSetParameter(2, dsCreateBudgetIn, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetInDataSet");


		// Set up input/output parameters


		// Set up Out parameters
		parms.setDataSetParameter(3, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		parms.setDataSetParameter(4, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet");


		// Setup local MetaSchema if any params are tables
		MetaSchema createbudget_a_MetaSchema = new MetaSchema();
		createbudget_a_MetaSchema.addDataSetSchema(createbudget_a_DSMetaData1, 1, ParameterSet.INPUT);
		createbudget_a_MetaSchema.addDataSetSchema(createbudget_a_DSMetaData2, 2, ParameterSet.INPUT);
		createbudget_a_MetaSchema.addDataSetSchema(createbudget_a_DSMetaData3, 3, ParameterSet.OUTPUT);
		createbudget_a_MetaSchema.addDataSetSchema(createbudget_a_DSMetaData4, 4, ParameterSet.OUTPUT);


		// Set up return type
		

		// Run procedure
		rqCtx = runProcedure("createbudget_a.p", parms, createbudget_a_MetaSchema);


		// Get output parameters
		outValue = parms.getOutputParameter(3);
		dsMessage = (UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet)outValue;
		outValue = parms.getOutputParameter(4);
		dsCreateBudgetOut = (UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet)outValue;


		if (rqCtx != null) rqCtx.Release();

		if (parms.DataSetFillErrors > 0)
			throw new Open4GLException(38, new System.Object[]{parms.DataSetFillErrorString});


		// Return output value
		return (string)(parms.ProcedureReturnValue);

	}

/// <summary>
	/// 
	/// </summary> 
	public string getbudget_a(UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet dsSessionContext, UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetInDataSet dsCreateBudgetIn, out UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet dsMessage, out UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet dsCreateBudgetOut)
	{
		RqContext rqCtx = null;
		if (isSessionAvailable() == false)
			throw new Open4GLException(NotAvailable, null);

		Object outValue;
		ParameterSet parms = new ParameterSet(4);

		// Set up input parameters
		parms.setDataSetParameter(1, dsSessionContext, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		parms.setDataSetParameter(2, dsCreateBudgetIn, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetInDataSet");


		// Set up input/output parameters


		// Set up Out parameters
		parms.setDataSetParameter(3, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		parms.setDataSetParameter(4, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet");


		// Setup local MetaSchema if any params are tables
		MetaSchema getbudget_a_MetaSchema = new MetaSchema();
		getbudget_a_MetaSchema.addDataSetSchema(getbudget_a_DSMetaData1, 1, ParameterSet.INPUT);
		getbudget_a_MetaSchema.addDataSetSchema(getbudget_a_DSMetaData2, 2, ParameterSet.INPUT);
		getbudget_a_MetaSchema.addDataSetSchema(getbudget_a_DSMetaData3, 3, ParameterSet.OUTPUT);
		getbudget_a_MetaSchema.addDataSetSchema(getbudget_a_DSMetaData4, 4, ParameterSet.OUTPUT);


		// Set up return type
		

		// Run procedure
		rqCtx = runProcedure("getbudget_a.p", parms, getbudget_a_MetaSchema);


		// Get output parameters
		outValue = parms.getOutputParameter(3);
		dsMessage = (UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet)outValue;
		outValue = parms.getOutputParameter(4);
		dsCreateBudgetOut = (UgurluPluginGL.Proxy.StrongTypesNS.dsCreateBudgetOutDataSet)outValue;


		if (rqCtx != null) rqCtx.Release();

		if (parms.DataSetFillErrors > 0)
			throw new Open4GLException(38, new System.Object[]{parms.DataSetFillErrorString});


		// Return output value
		return (string)(parms.ProcedureReturnValue);

	}

/// <summary>
	/// 
	/// </summary> 
	public string getentity_a(UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet dsSessionContext, UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityInDataSet dsGetEntityIn, out UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet dsMessage, out UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityOutDataSet dsGetEntityOut)
	{
		RqContext rqCtx = null;
		if (isSessionAvailable() == false)
			throw new Open4GLException(NotAvailable, null);

		Object outValue;
		ParameterSet parms = new ParameterSet(4);

		// Set up input parameters
		parms.setDataSetParameter(1, dsSessionContext, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		parms.setDataSetParameter(2, dsGetEntityIn, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityInDataSet");


		// Set up input/output parameters


		// Set up Out parameters
		parms.setDataSetParameter(3, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		parms.setDataSetParameter(4, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityOutDataSet");


		// Setup local MetaSchema if any params are tables
		MetaSchema getentity_a_MetaSchema = new MetaSchema();
		getentity_a_MetaSchema.addDataSetSchema(getentity_a_DSMetaData1, 1, ParameterSet.INPUT);
		getentity_a_MetaSchema.addDataSetSchema(getentity_a_DSMetaData2, 2, ParameterSet.INPUT);
		getentity_a_MetaSchema.addDataSetSchema(getentity_a_DSMetaData3, 3, ParameterSet.OUTPUT);
		getentity_a_MetaSchema.addDataSetSchema(getentity_a_DSMetaData4, 4, ParameterSet.OUTPUT);


		// Set up return type
		

		// Run procedure
		rqCtx = runProcedure("getentity_a.p", parms, getentity_a_MetaSchema);


		// Get output parameters
		outValue = parms.getOutputParameter(3);
		dsMessage = (UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet)outValue;
		outValue = parms.getOutputParameter(4);
		dsGetEntityOut = (UgurluPluginGL.Proxy.StrongTypesNS.dsGetEntityOutDataSet)outValue;


		if (rqCtx != null) rqCtx.Release();

		if (parms.DataSetFillErrors > 0)
			throw new Open4GLException(38, new System.Object[]{parms.DataSetFillErrorString});


		// Return output value
		return (string)(parms.ProcedureReturnValue);

	}

/// <summary>
	/// 
	/// </summary> 
	public string getglcode_a(UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet dsSessionContext, UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeInDataSet dsGetGlCodeIn, out UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet dsMessage, out UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeOutDataSet dsGetGlCodeOut)
	{
		RqContext rqCtx = null;
		if (isSessionAvailable() == false)
			throw new Open4GLException(NotAvailable, null);

		Object outValue;
		ParameterSet parms = new ParameterSet(4);

		// Set up input parameters
		parms.setDataSetParameter(1, dsSessionContext, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		parms.setDataSetParameter(2, dsGetGlCodeIn, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeInDataSet");


		// Set up input/output parameters


		// Set up Out parameters
		parms.setDataSetParameter(3, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		parms.setDataSetParameter(4, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeOutDataSet");


		// Setup local MetaSchema if any params are tables
		MetaSchema getglcode_a_MetaSchema = new MetaSchema();
		getglcode_a_MetaSchema.addDataSetSchema(getglcode_a_DSMetaData1, 1, ParameterSet.INPUT);
		getglcode_a_MetaSchema.addDataSetSchema(getglcode_a_DSMetaData2, 2, ParameterSet.INPUT);
		getglcode_a_MetaSchema.addDataSetSchema(getglcode_a_DSMetaData3, 3, ParameterSet.OUTPUT);
		getglcode_a_MetaSchema.addDataSetSchema(getglcode_a_DSMetaData4, 4, ParameterSet.OUTPUT);


		// Set up return type
		

		// Run procedure
		rqCtx = runProcedure("getglcode_a.p", parms, getglcode_a_MetaSchema);


		// Get output parameters
		outValue = parms.getOutputParameter(3);
		dsMessage = (UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet)outValue;
		outValue = parms.getOutputParameter(4);
		dsGetGlCodeOut = (UgurluPluginGL.Proxy.StrongTypesNS.dsGetGlCodeOutDataSet)outValue;


		if (rqCtx != null) rqCtx.Release();

		if (parms.DataSetFillErrors > 0)
			throw new Open4GLException(38, new System.Object[]{parms.DataSetFillErrorString});


		// Return output value
		return (string)(parms.ProcedureReturnValue);

	}

/// <summary>
	/// 
	/// </summary> 
	public string getperiod_a(UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet dsSessionContext, UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodInDataSet dsGetPeriodIn, out UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet dsMessage, out UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodOutDataSet dsGetPeriodOut)
	{
		RqContext rqCtx = null;
		if (isSessionAvailable() == false)
			throw new Open4GLException(NotAvailable, null);

		Object outValue;
		ParameterSet parms = new ParameterSet(4);

		// Set up input parameters
		parms.setDataSetParameter(1, dsSessionContext, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		parms.setDataSetParameter(2, dsGetPeriodIn, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodInDataSet");


		// Set up input/output parameters


		// Set up Out parameters
		parms.setDataSetParameter(3, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		parms.setDataSetParameter(4, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodOutDataSet");


		// Setup local MetaSchema if any params are tables
		MetaSchema getperiod_a_MetaSchema = new MetaSchema();
		getperiod_a_MetaSchema.addDataSetSchema(getperiod_a_DSMetaData1, 1, ParameterSet.INPUT);
		getperiod_a_MetaSchema.addDataSetSchema(getperiod_a_DSMetaData2, 2, ParameterSet.INPUT);
		getperiod_a_MetaSchema.addDataSetSchema(getperiod_a_DSMetaData3, 3, ParameterSet.OUTPUT);
		getperiod_a_MetaSchema.addDataSetSchema(getperiod_a_DSMetaData4, 4, ParameterSet.OUTPUT);


		// Set up return type
		

		// Run procedure
		rqCtx = runProcedure("getperiod_a.p", parms, getperiod_a_MetaSchema);


		// Get output parameters
		outValue = parms.getOutputParameter(3);
		dsMessage = (UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet)outValue;
		outValue = parms.getOutputParameter(4);
		dsGetPeriodOut = (UgurluPluginGL.Proxy.StrongTypesNS.dsGetPeriodOutDataSet)outValue;


		if (rqCtx != null) rqCtx.Release();

		if (parms.DataSetFillErrors > 0)
			throw new Open4GLException(38, new System.Object[]{parms.DataSetFillErrorString});


		// Return output value
		return (string)(parms.ProcedureReturnValue);

	}

/// <summary>
	/// 
	/// </summary> 
	public string getyear_a(UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet dsSessionContext, UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearInDataSet dsGetYearIn, out UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet dsMessage, out UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearOutDataSet dsGetYearOut)
	{
		RqContext rqCtx = null;
		if (isSessionAvailable() == false)
			throw new Open4GLException(NotAvailable, null);

		Object outValue;
		ParameterSet parms = new ParameterSet(4);

		// Set up input parameters
		parms.setDataSetParameter(1, dsSessionContext, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsSessionContextDataSet");
		parms.setDataSetParameter(2, dsGetYearIn, ParameterSet.INPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearInDataSet");


		// Set up input/output parameters


		// Set up Out parameters
		parms.setDataSetParameter(3, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet");
		parms.setDataSetParameter(4, null, ParameterSet.OUTPUT, "UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearOutDataSet");


		// Setup local MetaSchema if any params are tables
		MetaSchema getyear_a_MetaSchema = new MetaSchema();
		getyear_a_MetaSchema.addDataSetSchema(getyear_a_DSMetaData1, 1, ParameterSet.INPUT);
		getyear_a_MetaSchema.addDataSetSchema(getyear_a_DSMetaData2, 2, ParameterSet.INPUT);
		getyear_a_MetaSchema.addDataSetSchema(getyear_a_DSMetaData3, 3, ParameterSet.OUTPUT);
		getyear_a_MetaSchema.addDataSetSchema(getyear_a_DSMetaData4, 4, ParameterSet.OUTPUT);


		// Set up return type
		

		// Run procedure
		rqCtx = runProcedure("getyear_a.p", parms, getyear_a_MetaSchema);


		// Get output parameters
		outValue = parms.getOutputParameter(3);
		dsMessage = (UgurluPluginGL.Proxy.StrongTypesNS.dsMessageDataSet)outValue;
		outValue = parms.getOutputParameter(4);
		dsGetYearOut = (UgurluPluginGL.Proxy.StrongTypesNS.dsGetYearOutDataSet)outValue;


		if (rqCtx != null) rqCtx.Release();

		if (parms.DataSetFillErrors > 0)
			throw new Open4GLException(38, new System.Object[]{parms.DataSetFillErrorString});


		// Return output value
		return (string)(parms.ProcedureReturnValue);

	}



    }
}

