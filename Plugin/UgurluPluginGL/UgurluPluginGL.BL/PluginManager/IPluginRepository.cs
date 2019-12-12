using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgurluPluginGL.BL.Common;
using UgurluPluginGL.Proxy.StrongTypesNS;

namespace UgurluPluginGL.BL.PluginManager
{
    public interface IPluginRepository
    {
        ResultModel<dsGetEntityOutDataSet.ttGetEntityOutDataTable> GetEntities();
        ResultModel<dsGetYearOutDataSet.ttGetYearOutDataTable> GetYear(int companyId);

        ResultModel<dsGetPeriodOutDataSet.ttGetPeriodOutDataTable> GetPeriod(int year,int companyId);

        ResultModel<dsGetGlCodeOutDataSet.ttGetGlCodeOutDataTable> GetGlAccount();

        ResultModel<dsCreateBudgetOutDataSet.ttCreateBudgetOutDataTable> CreateBudget(dsCreateBudgetInDataSet.ttCreateBudgetInDataTable inputDataTable);

        ResultModel<dsCreateBudgetOutDataSet.ttCreateBudgetOutDataTable> GetBudget(List<GLAccountLookupModel> gLAccountsModels,string companyCode,int period, List<PeriodLookupModel> periodLookupModels,int year);
    }
}
