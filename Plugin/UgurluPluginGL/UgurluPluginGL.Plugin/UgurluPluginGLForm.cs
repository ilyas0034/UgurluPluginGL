using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UgurluPluginGL.BL.Common;
using UgurluPluginGL.BL.PluginManager;
using UgurluPluginGL.Proxy.StrongTypesNS;

namespace UgurluPluginGL.Plugin
{
    public partial class UgurluPluginGLForm : Form
    {
        private IPluginManager _pluginManager;
        public UgurluPluginGLForm()
        {
            _pluginManager = new PluginManager();
            InitializeComponent();
            InitializeCompany();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int rowLength = dataGridView1.Rows.Count;
            var selectedCompany = company.SelectedItem as EntityLookupModel;
            var selectedYear = year.SelectedItem as YearLookupModel;
            ResultModel<List<PeriodLookupModel>> periodResult = _pluginManager.GetPeriods(selectedYear.Year, selectedCompany.CompanyId);

            List<Tuple<string, int, string, string,int>> amounts = new List<Tuple<string, int, string, string,int>>();

            for (int i = 0; i < rowLength; i++)
            {
                string glAccount = dataGridView1.Rows[i].Cells["GL Account"].FormattedValue.ToString();
                foreach (var periodItem in periodResult.Value)
                {
                    var cell = dataGridView1.Rows[i].Cells[periodItem.Period.ToString()].FormattedValue.ToString();
                    amounts.Add(new Tuple<string, int, string, string,int>(glAccount, periodItem.Period, selectedCompany.CompanyCode, cell,selectedYear.Year));
                }
            }

            var budgetResult = _pluginManager.CreateBudget(amounts);
            if (budgetResult.IsSuccess)
            {
                MessageBox.Show("Kayıt Başarılı");
                GetBudget(budgetResult.Value);
            }
            else if (!string.IsNullOrEmpty(budgetResult.Message))
            {
                MessageBox.Show(budgetResult.Message);
                InitializeComponent();
                InitializeCompany();
            }
            else
            {
                MessageBox.Show("Kayıt oluşurken hata oluştu");
                InitializeComponent();
                InitializeCompany();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = company.SelectedIndex;
            var selectItem = company.SelectedItem as EntityLookupModel;
            // MessageBox.Show("slected Index" + selectedIndex.ToString() + "Company Code" + selectItem.CompanyCode + "slect ıd" + selectItem.CompanyId.ToString());
            year.DisplayMember = "Year";
            year.ValueMember = "Year";
            ResultModel<List<YearLookupModel>> yearResult = _pluginManager.GetYears(selectItem.CompanyId);
            if (yearResult.IsSuccess)
            {
                if (yearResult.Value != null && yearResult.Value.Count > 0)
                {
                    year.DataSource = yearResult.Value;
                }
            }

        }

        private void InitializeCompany()
        {
            company.DisplayMember = "CompanyCode";
            company.ValueMember = "CompanyCodeId";
            ResultModel<List<EntityLookupModel>> result = _pluginManager.GetEntities();
            if (result.IsSuccess)
            {
                if (result.Value != null && result.Value.Count > 0)
                {
                    company.DataSource = result.Value;
                }
            }
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCompany = company.SelectedItem as EntityLookupModel;
            var selectedYear = year.SelectedItem as YearLookupModel;
            ResultModel<List<PeriodLookupModel>> result = _pluginManager.GetPeriods(selectedYear.Year, selectedCompany.CompanyId);
            int i = 1;
            dataGridView1.Rows.Clear();

            if (result.IsSuccess)
            {
                if (result.Value != null && result.Value.Count > 0)
                {
                    dataGridView1.ColumnCount = result.Value.Count + 1;
                    dataGridView1.Columns[0].Name = "GL Account";
                    dataGridView1.Columns[0].ReadOnly = true;
                    foreach (var yearItem in result.Value)
                    {
                        dataGridView1.Columns[i].Name = yearItem.Period.ToString();
                        i++;
                    }
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            var glAccountResult = _pluginManager.GetGlAccounts();

            if (glAccountResult.IsSuccess)
            {
                if (glAccountResult.Value != null && glAccountResult.Value.Count > 0)
                {
                    foreach (var glAccountItem in glAccountResult.Value)
                    {
                        dataGridView1.Rows.Add(glAccountItem.GlCode);
                    }
                }
            }

            var budgetResult = _pluginManager.GetBudget(selectedCompany.CompanyCode, selectedYear.Year,selectedCompany.CompanyId,selectedYear.Year);

            if (budgetResult.IsSuccess)
            {
                if (budgetResult.Value != null && budgetResult.Value.Count > 0)
                {
                    GetBudget(budgetResult.Value);
                }

                else
                {
                    dataGridView1.Refresh();
                }
            }

        }

        private void GetBudget(List<BudgetModel> budgets)
        {
            var selectedCompany = company.SelectedItem as EntityLookupModel;
            var selectedYear = year.SelectedItem as YearLookupModel;
            ResultModel<List<PeriodLookupModel>> periodResult = _pluginManager.GetPeriods(selectedYear.Year, selectedCompany.CompanyId);
            dataGridView1.Rows.Clear();
            var glAccountResult = _pluginManager.GetGlAccounts();

            if (glAccountResult.IsSuccess)
            {
                if (glAccountResult.Value != null && glAccountResult.Value.Count > 0)
                {
                    foreach (var glAccountItem in glAccountResult.Value)
                    {
                        dataGridView1.Rows.Add(glAccountItem.GlCode);
                    }
                }
            }

            var gruouplistBudgets = budgets.GroupBy(x => x.GLCode);
            int i = 0;

            foreach (var budget in gruouplistBudgets)
            {
                dataGridView1.Rows[i].Cells["GL Account"].Value = budget.Key;
                foreach (var budgetItem in budget)
                {

                    dataGridView1.Rows[i].Cells[budgetItem.Period.ToString()].Value = budgetItem.Amount.ToString();
                }
                i++;
            }
        }
    }
}
