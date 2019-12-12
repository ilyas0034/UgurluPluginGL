using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgurluPluginGL.BL.Common;
using UgurluPluginGL.Proxy.StrongTypesNS;

namespace UgurluPluginGL.BL.PluginManager
{
    public class PluginManager : IPluginManager
    {
        private IPluginRepository _pluginRepository;
        public PluginManager()
        {
            _pluginRepository = new PluginRepository();
        }

        public ResultModel<List<BudgetModel>> CreateBudget(List<Tuple<string, int, string, string,int>> amounts)
        {
            ResultModel<List<BudgetModel>> result = new ResultModel<List<BudgetModel>>();
            List<BudgetModel> budgets = new List<BudgetModel>();
            try
            {
                var inputDataTable = new dsCreateBudgetInDataSet.ttCreateBudgetInDataTable();

                foreach (var amountItem in amounts)
                {
                    decimal value;
                    if (Decimal.TryParse(amountItem.Item4, out value))
                    {
                        inputDataTable.AddttCreateBudgetInRow(Guid.NewGuid().ToString(), amountItem.Item2, amountItem.Item1, value, amountItem.Item3,amountItem.Item5);
                    }
                    else if (string.IsNullOrEmpty(amountItem.Item4))
                    {
                        inputDataTable.AddttCreateBudgetInRow(Guid.NewGuid().ToString(), amountItem.Item2, amountItem.Item1, 0, amountItem.Item3,amountItem.Item5);
                    }
                    else
                    {
                        throw new ProccessException("Tutar decimal olmalıdır");
                    }
                }

                var repositoryResult = _pluginRepository.CreateBudget(inputDataTable);

                if (repositoryResult.IsSuccess)
                {
                    if (repositoryResult.Value != null && repositoryResult.Value.Count > 0)
                    {
                        foreach (dsCreateBudgetOutDataSet.ttCreateBudgetOutRow rowItem in repositoryResult.Value)
                        {
                            budgets.Add(new BudgetModel { Amount = rowItem.Amount, CompanyCode = rowItem.CompanyCode, GLCode = rowItem.GLCode, ID = rowItem.ID, Period = rowItem.Period });
                        }
                    }
                }
                result.Value = budgets;
                result.IsSuccess = true;
            }
            catch (ProccessException ex)
            {
                result.Message = ex.Message;
            }
            catch (Exception e)
            {
                result.Message = e.Message;
            }
            return result;
        }

        public ResultModel<List<BudgetModel>> GetBudget(string companyCode, int period,int companyId,int year)
        {
            ResultModel<List<BudgetModel>> result = new ResultModel<List<BudgetModel>>();
            List<BudgetModel> budgets = new List<BudgetModel>();

            try
            {
                var glAccounts = GetGlAccounts();
                var periods = GetPeriods(period,companyId);
                if (glAccounts.IsSuccess)
                {
                    if (glAccounts.Value != null && glAccounts.Value.Count > 0)
                    {
                        var repositoryResult = _pluginRepository.GetBudget(glAccounts.Value,companyCode, period,periods.Value,year);

                        if (repositoryResult.IsSuccess)
                        {
                            if (repositoryResult.Value != null && repositoryResult.Value.Count > 0)
                            {
                                foreach (dsCreateBudgetOutDataSet.ttCreateBudgetOutRow rowItem in repositoryResult.Value)
                                {
                                    budgets.Add(new BudgetModel { Amount = rowItem.Amount, CompanyCode = rowItem.CompanyCode, GLCode = rowItem.GLCode, ID = rowItem.ID, Period = rowItem.Period });
                                }
                            }
                        }

                    }
                }

                result.IsSuccess = true;
                result.Value = budgets;
            }
            catch (Exception e)
            {
            }
            return result;
        }

        public ResultModel<List<EntityLookupModel>> GetEntities()
        {
            ResultModel<List<EntityLookupModel>> result = new ResultModel<List<EntityLookupModel>>();
            try
            {
                List<EntityLookupModel> entityLookupModels = new List<EntityLookupModel>();
                var repositoryResult = _pluginRepository.GetEntities();
                if (repositoryResult.IsSuccess)
                {
                    if (repositoryResult.Value != null && repositoryResult.Value.Count > 0)
                    {
                        foreach (dsGetEntityOutDataSet.ttGetEntityOutRow rowItem in repositoryResult.Value)
                        {
                            entityLookupModels.Add(new EntityLookupModel { CompanyCode = rowItem.CompanyCode, CompanyId = rowItem.Company_ID });
                        }
                    }
                }
                result.IsSuccess = true;
                result.Value = entityLookupModels;
            }
            catch (Exception e)
            {
            }

            return result;
        }

        public ResultModel<List<GLAccountLookupModel>> GetGlAccounts()
        {
            ResultModel<List<GLAccountLookupModel>> result = new ResultModel<List<GLAccountLookupModel>>();

            try
            {
                List<GLAccountLookupModel> gLAccountLookupModels = new List<GLAccountLookupModel>();
                var repositoryResult = _pluginRepository.GetGlAccount();

                if (repositoryResult.IsSuccess)
                {
                    if (repositoryResult.Value != null && repositoryResult.Value.Count > 0)
                    {
                        foreach (dsGetGlCodeOutDataSet.ttGetGlCodeOutRow rowItem in repositoryResult.Value)
                        {
                            gLAccountLookupModels.Add(new GLAccountLookupModel { GlCode = rowItem.GLCode, GlId = rowItem.GL_ID });
                        }
                    }
                }
                result.IsSuccess = true;
                result.Value = gLAccountLookupModels;

            }
            catch (Exception e)
            {
            }
            return result;
        }

        public ResultModel<List<PeriodLookupModel>> GetPeriods(int year, int companyId)
        {
            ResultModel<List<PeriodLookupModel>> result = new ResultModel<List<PeriodLookupModel>>();

            try
            {
                List<PeriodLookupModel> periodLookupModels = new List<PeriodLookupModel>();
                var repositoryResult = _pluginRepository.GetPeriod(year, companyId);

                if (repositoryResult.IsSuccess)
                {
                    if (repositoryResult.Value != null && repositoryResult.Value.Count > 0)
                    {
                        foreach (dsGetPeriodOutDataSet.ttGetPeriodOutRow rowItem in repositoryResult.Value)
                        {
                            periodLookupModels.Add(new PeriodLookupModel { Year = rowItem.PeriodYear, Period_Id = rowItem.Period_ID, Period = rowItem.Period });
                        }
                    }
                }
                result.IsSuccess = true;
                result.Value = periodLookupModels;
            }
            catch (Exception e)
            {
            }
            return result;
        }

        public ResultModel<List<YearLookupModel>> GetYears(int companyId)
        {
            ResultModel<List<YearLookupModel>> result = new ResultModel<List<YearLookupModel>>();

            try
            {
                List<YearLookupModel> yearLookupModels = new List<YearLookupModel>();
                var repositoryResult = _pluginRepository.GetYear(companyId);

                if (repositoryResult.IsSuccess)
                {
                    if (repositoryResult.Value != null && repositoryResult.Value.Count > 0)
                    {
                        foreach (dsGetYearOutDataSet.ttGetYearOutRow rowItem in repositoryResult.Value)
                        {
                            yearLookupModels.Add(new YearLookupModel { Year = rowItem.Year });
                        }
                    }
                }
                result.IsSuccess = true;
                result.Value = yearLookupModels;
            }
            catch (Exception e)
            {
            }
            return result;

        }
    }
}
