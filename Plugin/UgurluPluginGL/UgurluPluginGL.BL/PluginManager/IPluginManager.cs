using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgurluPluginGL.BL.Common;
using UgurluPluginGL.Proxy.StrongTypesNS;

namespace UgurluPluginGL.BL.PluginManager
{
    public interface IPluginManager
    {
        ResultModel<List<EntityLookupModel>> GetEntities();

        ResultModel<List<YearLookupModel>> GetYears(int companyId);

        ResultModel<List<PeriodLookupModel>> GetPeriods(int year,int companyId);

        ResultModel<List<GLAccountLookupModel>> GetGlAccounts();

        ResultModel<List<BudgetModel>> CreateBudget(List<Tuple<string, int, string, string,int>> amounts);

        ResultModel<List<BudgetModel>> GetBudget(string companyCode,int period,int companyId,int year);

    }
}
