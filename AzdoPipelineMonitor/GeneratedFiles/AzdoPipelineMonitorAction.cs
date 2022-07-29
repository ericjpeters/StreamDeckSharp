using StreamDeckLib;
using StreamDeckPluginBase;

namespace AzdoPipelineMonitor
{
    [ActionUuid(Uuid = "com.StreamDeckSharp.streamdeck.AzdoPipelineMonitor")]
    public partial class AzdoPipelineMonitorAction : StreamDeckAction<AzdoPipelineMonitorModel>
    {
        public AzdoPipelineMonitorAction()
            : base(30)
        {
            Initialize().Wait();
        }
    }
}