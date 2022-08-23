using CleanArch.Application.Gateways.Clients;
using CleanArch.Enterprise.Entities.Clients;

namespace CleanArch.Infra.Gateways.Clients;

public class ClientInMemoryGateway : IClientGateway
{
    private static List<Client> _clients = new List<Client>(){
        new Client("Test", "Test", "test@mail.com", "12345678912")
    };

    public void Create(Client client)
    {
        ClientInMemoryGateway._clients.Add(client);
    }

    public ICollection<Client> FindAll()
    {
        return ClientInMemoryGateway._clients.ToList();
    }
}
