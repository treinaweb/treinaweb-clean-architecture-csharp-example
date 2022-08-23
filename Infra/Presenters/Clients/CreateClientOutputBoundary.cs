using System.Text.Json;
using CleanArch.Enterprise.Entities.Clients;

namespace CleanArch.Infra.Presenters.Clients;

public class CreateClientOutputBoundary
{
    public static string ToJson(Client client)
    {
        var clientOutputDto = new CreateClientOutputDto(
            client.FirstName,
            client.LastName,
            client.Email,
            client.Cpf
        );
        return JsonSerializer.Serialize(clientOutputDto);
    }
}