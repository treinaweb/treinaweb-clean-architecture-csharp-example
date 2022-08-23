using CleanArch.Application.Gateways.Clients;
using CleanArch.Enterprise.Entities.Clients;

namespace CleanArch.Application.UseCases.Clients;

public class CreateClientUseCase
{
    private readonly IClientGateway _clientGateway;

    public CreateClientUseCase(IClientGateway clientGateway)
    {
        _clientGateway = clientGateway;
    }

    public Client Execute(Client client)
    {
        _clientGateway.Create(client);
        return client;
    }
}