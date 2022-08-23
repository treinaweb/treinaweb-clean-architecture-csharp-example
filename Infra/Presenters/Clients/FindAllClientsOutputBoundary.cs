using System.Text.Json;
using CleanArch.Enterprise.Entities.Clients;

namespace CleanArch.Infra.Presenters.Clients;

public static class FindAllClientsOutputBoundary
{
    public static string ToJson(ICollection<Client> clients)
    {
        var clientsOutputDto = clients.Select(client => new FindAllClientsOutputDto(
            client.FirstName,
            client.LastName,
            client.Email,
            client.Cpf
        ));
        return JsonSerializer.Serialize(clientsOutputDto);
    }
}