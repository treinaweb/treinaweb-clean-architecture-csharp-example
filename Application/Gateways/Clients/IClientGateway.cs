using CleanArch.Enterprise.Entities.Clients;

namespace CleanArch.Application.Gateways.Clients;

public interface IClientGateway
{
    ICollection<Client> FindAll();
    void Create(Client client);
}