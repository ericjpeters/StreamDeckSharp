using StreamDeckPluginBase;

namespace AzdoPipelineMonitor
{
    public class AzdoPipelineMonitorModel : StreamDeckModel
    {
        public string? AwsAccessKeyId { get; set; }
public string? AwsAccessKeySecret { get; set; }
public string? AwsRegion { get; set; }
public string? AwsAlarmName { get; set; }
    }
}