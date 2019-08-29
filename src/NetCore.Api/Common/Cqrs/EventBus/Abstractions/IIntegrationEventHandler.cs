using NetCoreInfra.Common.Cqrs.EventBus.Events;
using System.Threading.Tasks;

namespace NetCoreInfra.Common.Cqrs.EventBus.Abstractions
{
    public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler 
        where TIntegrationEvent: IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);
    }

    public interface IIntegrationEventHandler
    {
    }
}
