using QAD.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgurluPluginGL.BL.Common;
using UgurluPluginGL.Proxy;
using UgurluPluginGL.Proxy.StrongTypesNS;


namespace UgurluPluginGL.BL.PluginManager
{
    public class PluginRepository : IPluginRepository
    {
        public ResultModel<dsCreateBudgetOutDataSet.ttCreateBudgetOutDataTable> CreateBudget(dsCreateBudgetInDataSet.ttCreateBudgetInDataTable inputDataTable)
        {
            ResultModel<dsCreateBudgetOutDataSet.ttCreateBudgetOutDataTable> result = new ResultModel<dsCreateBudgetOutDataSet.ttCreateBudgetOutDataTable>();

            try
            {
                ProxyService proxy = null;
                dsSessionContextDataSet dsContext = null;
                dsMessageDataSet dsErrorMessages = null;

                dsCreateBudgetOutDataSet outDataSet = null;
                dsCreateBudgetInDataSet inDataSet = null;

                inDataSet = new dsCreateBudgetInDataSet();
                inDataSet.ttUserInfoTr.AddttUserInfoTrRow("","");

                foreach (dsCreateBudgetInDataSet.ttCreateBudgetInRow budgetRowItem in inputDataTable.Rows)
                {
                    inDataSet.ttCreateBudgetIn.AddttCreateBudgetInRow(budgetRowItem.ID,budgetRowItem.Period,budgetRowItem.GLCode,budgetRowItem.Amount,budgetRowItem.CompanyCode,budgetRowItem.Year);
                }

                proxy = (ProxyService)ProxyManager.GetProxy(typeof(ProxyService));
                dsContext = (dsSessionContextDataSet)ProxyContextFactory.CreateContext(new dsSessionContextDataSet());

                proxy.createbudget_a(dsContext, inDataSet, out dsErrorMessages, out outDataSet);

                if (outDataSet != null && outDataSet.Tables != null && outDataSet.Tables.Count >= 2)
                {
                    dsCreateBudgetOutDataSet.ttCstMessagesDataTable messageDataTable = (dsCreateBudgetOutDataSet.ttCstMessagesDataTable)outDataSet.Tables[0];

                    if (messageDataTable.Rows.Count > 0)
                    {
                        if (messageDataTable.Rows.Count == 1 && ((dsCreateBudgetOutDataSet.ttCstMessagesRow)messageDataTable.Rows[0]).ttMessageNumber == "100")
                        {
                            result.Value = (dsCreateBudgetOutDataSet.ttCreateBudgetOutDataTable)outDataSet.Tables[1]; ;
                            result.IsSuccess = true;
                        }
                        else
                        {
                            foreach (dsCreateBudgetOutDataSet.ttCstMessagesRow eBookTranMessageDataRow in messageDataTable.Rows)
                            {
                                result.Message += eBookTranMessageDataRow.ttMessage;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }
            return result;
        }

        public ResultModel<dsCreateBudgetOutDataSet.ttCreateBudgetOutDataTable> GetBudget(List<GLAccountLookupModel> glaccounts,string companyCode, int period, List<PeriodLookupModel> periodLookupModels,int year)
        {

            ResultModel<dsCreateBudgetOutDataSet.ttCreateBudgetOutDataTable> result = new ResultModel<dsCreateBudgetOutDataSet.ttCreateBudgetOutDataTable>();

            try
            {
                ProxyService proxy = null;
                dsSessionContextDataSet dsContext = null;
                dsMessageDataSet dsErrorMessages = null;

                dsCreateBudgetOutDataSet outDataSet = null;
                dsCreateBudgetInDataSet inDataSet = null;

                inDataSet = new dsCreateBudgetInDataSet();
                inDataSet.ttUserInfoTr.AddttUserInfoTrRow("", "");
                inDataSet.ttCreateBudgetIn.AddttCreateBudgetInRow("", 0, "", 0, companyCode,year);

                proxy = (ProxyService)ProxyManager.GetProxy(typeof(ProxyService));
                dsContext = (dsSessionContextDataSet)ProxyContextFactory.CreateContext(new dsSessionContextDataSet());

                proxy.getbudget_a(dsContext, inDataSet, out dsErrorMessages, out outDataSet);

                if (outDataSet != null && outDataSet.Tables != null && outDataSet.Tables.Count >= 2)
                {
                    dsCreateBudgetOutDataSet.ttCstMessagesDataTable messageDataTable = (dsCreateBudgetOutDataSet.ttCstMessagesDataTable)outDataSet.Tables[0];

                    if (messageDataTable.Rows.Count > 0)
                    {
                        if (messageDataTable.Rows.Count == 1 && ((dsCreateBudgetOutDataSet.ttCstMessagesRow)messageDataTable.Rows[0]).ttMessageNumber == "100")
                        {
                            result.Value = (dsCreateBudgetOutDataSet.ttCreateBudgetOutDataTable)outDataSet.Tables[1]; ;
                            result.IsSuccess = true;
                        }
                        else
                        {
                            foreach (dsCreateBudgetOutDataSet.ttCstMessagesRow eBookTranMessageDataRow in messageDataTable.Rows)
                            {
                                result.Message += eBookTranMessageDataRow.ttMessage;
                            }
                        }
                    }
                }

            }
            catch (Exception e)
            {
            }

            return result;
        }

        public ResultModel<dsGetEntityOutDataSet.ttGetEntityOutDataTable> GetEntities()
        {
            
            ResultModel<dsGetEntityOutDataSet.ttGetEntityOutDataTable> result = new ResultModel<dsGetEntityOutDataSet.ttGetEntityOutDataTable>();

            try
            {
                ProxyService proxy = null;
                dsSessionContextDataSet dsContext = null;
                dsMessageDataSet dsErrorMessages = null;

                dsGetEntityOutDataSet outDataSet = null;
                dsGetEntityInDataSet inDataSet = null;

                inDataSet = new dsGetEntityInDataSet();

                inDataSet.ttUserInfoTr.AddttUserInfoTrRow("","");

                inDataSet.ttGetEntityIn.AddttGetEntityInRow("");

                proxy = (ProxyService)ProxyManager.GetProxy(typeof(ProxyService));
                dsContext = (dsSessionContextDataSet)ProxyContextFactory.CreateContext(new dsSessionContextDataSet());

                proxy.getentity_a(dsContext, inDataSet, out dsErrorMessages, out outDataSet);


                if (outDataSet != null && outDataSet.Tables != null && outDataSet.Tables.Count >= 2)
                {
                    dsGetEntityOutDataSet.ttCstMessagesDataTable messageDataTable = (dsGetEntityOutDataSet.ttCstMessagesDataTable)outDataSet.Tables[0];

                    if (messageDataTable.Rows.Count > 0)
                    {
                        if (messageDataTable.Rows.Count == 1 && ((dsGetEntityOutDataSet.ttCstMessagesRow)messageDataTable.Rows[0]).ttMessageNumber == "100")
                        {
                            result.Value = (dsGetEntityOutDataSet.ttGetEntityOutDataTable)outDataSet.Tables[1];
                            result.IsSuccess = true;
                        }
                        else
                        {
                            foreach (dsGetEntityOutDataSet.ttCstMessagesRow eBookTranMessageDataRow in messageDataTable.Rows)
                            {
                                result.Message += eBookTranMessageDataRow.ttMessage;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }
            return result;
        }

        public ResultModel<dsGetGlCodeOutDataSet.ttGetGlCodeOutDataTable> GetGlAccount()
        {
            ResultModel<dsGetGlCodeOutDataSet.ttGetGlCodeOutDataTable> result = new ResultModel<dsGetGlCodeOutDataSet.ttGetGlCodeOutDataTable>();
            try
            {
                ProxyService proxy = null;
                dsSessionContextDataSet dsContext = null;
                dsMessageDataSet dsErrorMessages = null;

                dsGetGlCodeOutDataSet outDataSet = null;
                dsGetGlCodeInDataSet inDataSet = null;

                inDataSet = new dsGetGlCodeInDataSet();

                inDataSet.ttUserInfoTr.AddttUserInfoTrRow("", "");
                inDataSet.ttGetGlCodeIn.AddttGetGlCodeInRow("");

                proxy = (ProxyService)ProxyManager.GetProxy(typeof(ProxyService));
                dsContext = (dsSessionContextDataSet)ProxyContextFactory.CreateContext(new dsSessionContextDataSet());

                proxy.getglcode_a(dsContext, inDataSet, out dsErrorMessages, out outDataSet);

                if (outDataSet != null && outDataSet.Tables != null && outDataSet.Tables.Count >= 2)
                {
                    dsGetGlCodeOutDataSet.ttCstMessagesDataTable messageDataTable = (dsGetGlCodeOutDataSet.ttCstMessagesDataTable)outDataSet.Tables[0];

                    if (messageDataTable.Rows.Count > 0)
                    {
                        if (messageDataTable.Rows.Count == 1 && ((dsGetGlCodeOutDataSet.ttCstMessagesRow)messageDataTable.Rows[0]).ttMessageNumber == "100")
                        {
                            result.Value = (dsGetGlCodeOutDataSet.ttGetGlCodeOutDataTable)outDataSet.Tables[1];
                            result.IsSuccess = true;
                        }
                        else
                        {
                            foreach (dsGetGlCodeOutDataSet.ttCstMessagesRow eBookTranMessageDataRow in messageDataTable.Rows)
                            {
                                result.Message += eBookTranMessageDataRow.ttMessage;
                            }
                        }
                    }
                }

            }
            catch (Exception e)
            {
            }
            return result;
        }

        public ResultModel<dsGetPeriodOutDataSet.ttGetPeriodOutDataTable> GetPeriod(int year, int companyId)
        {
            ResultModel<dsGetPeriodOutDataSet.ttGetPeriodOutDataTable> result = new ResultModel<dsGetPeriodOutDataSet.ttGetPeriodOutDataTable>();

            try
            {
                ProxyService proxy = null;
                dsSessionContextDataSet dsContext = null;
                dsMessageDataSet dsErrorMessages = null;

                dsGetPeriodOutDataSet outDataSet = null;
                dsGetPeriodInDataSet inDataSet = null;

                inDataSet = new dsGetPeriodInDataSet();

                inDataSet.ttUserInfoTr.AddttUserInfoTrRow("", "");
                inDataSet.ttGetPeriodIn.AddttGetPeriodInRow(year, companyId);

                proxy = (ProxyService)ProxyManager.GetProxy(typeof(ProxyService));
                dsContext = (dsSessionContextDataSet)ProxyContextFactory.CreateContext(new dsSessionContextDataSet());

                proxy.getperiod_a(dsContext, inDataSet, out dsErrorMessages, out outDataSet);

                if (outDataSet != null && outDataSet.Tables != null && outDataSet.Tables.Count >= 2)
                {
                    dsGetPeriodOutDataSet.ttCstMessagesDataTable messageDataTable = (dsGetPeriodOutDataSet.ttCstMessagesDataTable)outDataSet.Tables[0];

                    if (messageDataTable.Rows.Count > 0)
                    {
                        if (messageDataTable.Rows.Count == 1 && ((dsGetPeriodOutDataSet.ttCstMessagesRow)messageDataTable.Rows[0]).ttMessageNumber == "100")
                        {
                            result.Value = (dsGetPeriodOutDataSet.ttGetPeriodOutDataTable)outDataSet.Tables[1];
                            result.IsSuccess = true;
                        }
                        else
                        {
                            foreach (dsGetPeriodOutDataSet.ttCstMessagesRow eBookTranMessageDataRow in messageDataTable.Rows)
                            {
                                result.Message += eBookTranMessageDataRow.ttMessage;
                            }
                        }
                    }
                }

            }
            catch (Exception e)
            {
            }
            return result;
        }

        public ResultModel<dsGetYearOutDataSet.ttGetYearOutDataTable> GetYear(int companyId)
        {
            ResultModel<dsGetYearOutDataSet.ttGetYearOutDataTable> result = new ResultModel<dsGetYearOutDataSet.ttGetYearOutDataTable>();

            try
            {
                ProxyService proxy = null;
                dsSessionContextDataSet dsContext = null;
                dsMessageDataSet dsErrorMessages = null;

                dsGetYearOutDataSet outDataSet = null;
                dsGetYearInDataSet inDataSet = null;

                inDataSet = new dsGetYearInDataSet();
                inDataSet.ttUserInfoTr.AddttUserInfoTrRow("", "");
                inDataSet.ttGetYearIn.AddttGetYearInRow(companyId);

                proxy = (ProxyService)ProxyManager.GetProxy(typeof(ProxyService));
                dsContext = (dsSessionContextDataSet)ProxyContextFactory.CreateContext(new dsSessionContextDataSet());

                proxy.getyear_a(dsContext, inDataSet, out dsErrorMessages, out outDataSet);

                if (outDataSet != null && outDataSet.Tables != null && outDataSet.Tables.Count >= 2)
                {
                    dsGetYearOutDataSet.ttCstMessagesDataTable messageDataTable = (dsGetYearOutDataSet.ttCstMessagesDataTable)outDataSet.Tables[0];

                    if (messageDataTable.Rows.Count > 0)
                    {
                        if (messageDataTable.Rows.Count == 1 && ((dsGetYearOutDataSet.ttCstMessagesRow)messageDataTable.Rows[0]).ttMessageNumber == "100")
                        {
                            result.Value = (dsGetYearOutDataSet.ttGetYearOutDataTable)outDataSet.Tables[1];
                            result.IsSuccess = true;
                        }
                        else
                        {
                            foreach (dsGetEntityOutDataSet.ttCstMessagesRow eBookTranMessageDataRow in messageDataTable.Rows)
                            {
                                result.Message += eBookTranMessageDataRow.ttMessage;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }
            return result;
        }
    }
}
