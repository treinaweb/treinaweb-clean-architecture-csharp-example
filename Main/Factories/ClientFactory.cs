using CleanArch.Application.Gateways.Clients;
using CleanArch.Application.UseCases.Clients;
using CleanArch.Infra.Controllers.Clients;
using CleanArch.Infra.Gateways.Clients;

namespace CleanArch.Main.Factories;

public static class ClientFactory
{
    private static IClientGateway? _clientGatewayInstance;

    public static IClientGateway GetClientGateway()
    {
        if (_clientGatewayInstance is null)
        {
            _clientGatewayInstance = new ClientMySQLGateway();
        }
        return _clientGatewayInstance;
    }

    public static FindAllClientsUseCase GetFindAllClientsUseCase()
    {
        return new FindAllClientsUseCase(GetClientGateway());
    }

    public static CreateClientUseCase GetCreateClientUseCase()
    {
        return new CreateClientUseCase(GetClientGateway());
    }

    public static FindAllClientsController GetFindAllClientsController()
    {
        return new FindAllClientsController(GetFindAllClientsUseCase());
    }

    public static CreateClientController GetCreateClientController()
    {
        return new CreateClientController(GetCreateClientUseCase());
    }
}