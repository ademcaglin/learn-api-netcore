using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NetCoreInfra.Common.Cqrs;

namespace NetCore.Api.Application.Commands
{

    public class SampleCommandHandler : IRequestHandler<SampleCommand, CommandResponse>
    {
        //private readonly IMenuProviderRepository _menuProviderRepository;

        //public CreateIdentityUserRoleCommandHandler(IMenuProviderRepository menuProviderRepository)
        //{
        //    _menuProviderRepository = menuProviderRepository;
        //}

        public async Task<CommandResponse> Handle(SampleCommand request, CancellationToken cancellationToken)
        {
            //var pr = new MenuProvider(request.Uri, request.Title);
            //await _menuProviderRepository.Save(pr);
            //var r = new CommandResponse();
            //r.IntegrationEvents.Add(new MenuProvidersChangedIntegrationEvent());
            //r.IsSucceed = true;
            //return r;
            return null;
        }
    }

}