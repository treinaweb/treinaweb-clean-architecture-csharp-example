using System.Text.Json;
using CleanArch.Enterprise.Entities.Clients;

namespace CleanArch.Infra.Presenters.Clients;

public class CreateClientInputBoundary
{
    public static Client FromJson(string json)
    {
        var clientInputDto = JsonSerializer.Deserialize<CreateClientInputDto>(json);
        if (clientInputDto is null)
        {
            throw new ArgumentException("Invalid json");
        }
        return new Client(
            clientInputDto.FirstName,
            clientInputDto.LastName,
            clientInputDto.Email,
            clientInputDto.Cpf
        );
    }
}