namespace CleanArch.Enterprise.Entities.Clients;

public class Client
{
    private ClientName _firstName;
    private ClientName _lastName;
    private Email _email;
    private Cpf _cpf;

    public Client(string firstName, string lastName, string email, string cpf)
    {
        _firstName = new ClientName(firstName);
        _lastName = new ClientName(lastName);
        _email = new Email(email);
        _cpf = new Cpf(cpf);
    }

    public string FirstName
    {
        get { return _firstName.Value; }
    }

    public string LastName
    {
        get { return _lastName.Value; }
    }

    public string Email
    {
        get { return _email.Value; }
    }

    public string Cpf
    {
        get { return _cpf.Value; }
    }
}