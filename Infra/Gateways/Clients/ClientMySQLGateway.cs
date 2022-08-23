using CleanArch.Application.Gateways.Clients;
using CleanArch.Enterprise.Entities.Clients;
using CleanArch.Infra.Db;
using Dapper;

namespace CleanArch.Infra.Gateways.Clients;

public class ClientMySQLGateway : IClientGateway
{
    public void Create(Client client)
    {
        using (var connection = MySQL.GetDbConnection())
        {
            var sql = @"
                INSERT INTO clients (nome, sobrenome, email, cpf)
                VALUES (@FistName, @LastName, @Email, @Cpf)
            ";
            connection.Open();
            connection.Execute(sql, client);
        }
    }

    public ICollection<Client> FindAll()
    {
        using (var connection = MySQL.GetDbConnection())
        {
            var sql = @"
                SELECT * FROM clients
            ";
            connection.Open();
            return connection.Query<ClientDb>(sql)
                .Select(clientDb => new Client(clientDb.Nome, clientDb.Sobrenome, clientDb.Email, clientDb.Cpf))
                .ToList();
        }
    }
}

public class ClientDb
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Sobrenome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
}