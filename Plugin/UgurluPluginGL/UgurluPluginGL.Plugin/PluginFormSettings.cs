using QAD.Commands;
using QAD.Globalization;
using QAD.Plugin.Services;
using QAD.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UgurluPluginGL.Plugin
{
    class PluginFormSettings : AbstractProgramCommand
    {
        private Form _plugForm;

        public PluginFormSettings()
        {
        }

        public override void Execute()
        {
            IGlobalizationService instance = GlobalizationService.Instance;
            this._plugForm = new UgurluPluginGLForm();
            FormManager.GetManager().AddForm("Plugin Example Form v1.0", this._plugForm, true, new CommandCollection());
            this._plugForm.Show();
        }
    }
}
