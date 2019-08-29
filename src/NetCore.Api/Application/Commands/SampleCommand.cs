using MediatR;
using NetCoreInfra.Common.Cqrs;

namespace NetCore.Api.Application.Commands
{
    public class SampleCommand : IRequest<CommandResponse>
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

    }
}