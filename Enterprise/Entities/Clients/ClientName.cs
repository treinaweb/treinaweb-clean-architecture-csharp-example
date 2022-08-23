namespace CleanArch.Enterprise.Entities.Clients;

public class ClientName
{
    private string _value;

    public ClientName(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Client name cannot be empty");
        if (value.Length < 3)
            throw new ArgumentException("Client name must have at least 3 characters");
        if (value.Any(c => char.IsDigit(c)))
            throw new ArgumentException("Client name cannot have digits");
        _value = value;
    }

    public string Value
    {
        get { return _value; }
    }
}