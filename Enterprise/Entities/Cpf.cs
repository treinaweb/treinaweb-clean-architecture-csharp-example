namespace CleanArch.Enterprise.Entities;

public class Cpf
{
    private string _value;

    public Cpf(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("CPF cannot be empty");
        if (value.Length != 11)
            throw new ArgumentException("CPF must have 11 digits");
        if (value.Any(c => !char.IsDigit(c)))
            throw new ArgumentException("CPF must have only digits");
        _value = value;
    }

    public string Value
    {
        get { return _value; }
    }
}