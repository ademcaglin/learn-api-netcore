using System.Collections.Generic;
using NetCoreInfra.Common.Cqrs.EventBus.Events;

namespace NetCoreInfra.Common.Cqrs
{
    public class CommandResponse
    {
        public bool IsSucceed { get; set; }

        public IList<IntegrationEvent> IntegrationEvents { get; set; } = new List<IntegrationEvent>();
    }
}