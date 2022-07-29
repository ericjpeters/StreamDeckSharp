using StreamDeckLib.Messages;
using StreamDeckPluginBase;
using System;
using System.Threading.Tasks;

namespace AzdoPipelineMonitor
{
    public partial class AzdoPipelineMonitorAction : StreamDeckAction<AzdoPipelineMonitorModel>
    {
        private AzdoPipelineMonitorService? _service;

        public override async Task Initialize()
        {
            _service = new AzdoPipelineMonitorService();

            await Task.CompletedTask;
        }
    }
}