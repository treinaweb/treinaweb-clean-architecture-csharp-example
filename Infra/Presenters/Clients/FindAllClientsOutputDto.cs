using System.Text.Json.Serialization;

namespace CleanArch.Infra.Presenters.Clients;

public class FindAllClientsOutputDto
{
    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("cpf")]
    public string Cpf { get; set; }

    public FindAllClientsOutputDto(string firstName, string lastName, string email, string cpf)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Cpf = cpf;
    }
}