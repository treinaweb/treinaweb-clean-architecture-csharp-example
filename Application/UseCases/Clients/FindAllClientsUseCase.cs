using CleanArch.Application.Gateways.Clients;
using CleanArch.Enterprise.Entities.Clients;

namespace CleanArch.Application.UseCases.Clients;

public class FindAllClientsUseCase
{
    private readonly IClientGateway _clientGateway;

    public FindAllClientsUseCase(IClientGateway clientGateway)
    {
        _clientGateway = clientGateway;
    }

    public ICollection<Client> Execute()
    {
        return _clientGateway.FindAll();
    }
}