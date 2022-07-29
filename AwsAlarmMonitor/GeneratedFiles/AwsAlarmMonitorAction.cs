using StreamDeckLib;
using StreamDeckPluginBase;

namespace AwsAlarmMonitor
{
    [ActionUuid(Uuid = "com.StreamDeckSharp.streamdeck.AwsAlarmMonitor")]
    public partial class AwsAlarmMonitorAction : StreamDeckAction<AwsAlarmMonitorModel>
    {
        public AwsAlarmMonitorAction()
            : base(30)
        {
            Initialize().Wait();
        }
    }
}