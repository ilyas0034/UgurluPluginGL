using QAD.Commands;
using QAD.Plugin.Services;
using QAD.Shell.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgurluPluginGL.Plugin
{
    public class Plugin : PluginExtensionBase
    {
        public const string PluginKey = "qad.plugin.PluginExample.PluginUI";
        /// <summary>
        /// Expose this plugin as a service.
        /// </summary>
        /// <param name="pluginContext">The context associated with this plugin.</param>
        public override void Initialize(IPluginLocalContext pluginContext)
        {
            base.Initialize(pluginContext);

            IServiceContainer serviceContainer = (IServiceContainer)pluginContext.GetService(typeof(IServiceContainer));
            serviceContainer.AddService(typeof(IPlugin), this);
        }

        /// <summary>
        /// Called once per client session by the MFG/PRO plugin when it is ready
        /// to be extended.
        /// </summary>
        /// <param name="plugin">The MFG/PRO plugin that we are extending.</param>
        public override void Extend(IPlugin plugin)
        {
            ICommandManager service = (ICommandManager)plugin.Context.GetService(typeof(ICommandManager));

            CommandRule commandRule = new CommandRule(CommandMatchType.Key, "glacc.p", new CommandInfo(typeof(PluginFormSettings)), true);
            service.AddDefaultCommandRule(commandRule);

        }

        /// <summary>
        /// A convenience accessor to get a reference to this plugin.
        /// </summary>
        public static IPlugin Instance
        {
            get
            {
                IPluginLocalContext pluginContext = Plugin.PluginContainer.GetPluginLocalContext(PluginKey);
                return (IPlugin)pluginContext.GetService(typeof(IPlugin));
            }
        }

        /// <summary>
        /// A convenience accessor to get a reference to the MFG/PRO plugin.
        /// </summary>
        public static IPlugin MfgProInstance
        {
            get
            {
                IPluginLocalContext pluginContext = Plugin.PluginContainer.GetPluginLocalContext(PluginConstants.PluginKey);
                return (IPlugin)pluginContext.GetService(typeof(IPlugin));
            }
        }

        /// <summary>
        /// A convenience accessor to get a reference to the <see cref="IPluginContainer">plugin container</see>.
        /// </summary>
        public static IPluginContainer PluginContainer
        {
            get
            {
                return (IPluginContainer)StaticServices.GetPluginContainerService(typeof(IPluginContainer));
            }
        }
    }
}
