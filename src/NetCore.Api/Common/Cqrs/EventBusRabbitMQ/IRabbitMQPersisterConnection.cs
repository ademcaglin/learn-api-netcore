using RabbitMQ.Client;
using System;

namespace NetCoreInfra.Common.Cqrs.EventBusRabbitMQ
{
    public interface IRabbitMQPersistentConnection
        : IDisposable
    {
        bool IsConnected { get; }

        bool TryConnect();

        IModel CreateModel();
    }
}
