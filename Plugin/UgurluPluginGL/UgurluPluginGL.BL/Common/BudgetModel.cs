using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgurluPluginGL.BL.Common
{
    public class BudgetModel
    {
        public string ID { get; set; }

        public int Period { get; set; }

        public string GLCode { get; set; }

        public decimal Amount { get; set; }

        public string CompanyCode { get; set; }
    }
}
