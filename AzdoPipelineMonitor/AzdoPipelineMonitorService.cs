using Microsoft.Extensions.Logging;

namespace AzdoPipelineMonitor
{
    public class AzdoPipelineMonitorService
    {
        private bool _initialized = false;

        public AzdoPipelineMonitorService()
        {
            _initialized = false;
        }

        public void Initialize(ILogger logger, AzdoPipelineMonitorModel settingsModel)
        {
            if(_initialized)
                return;

            _initialized = true;
        }
    }
}