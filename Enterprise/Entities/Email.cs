using System.Text.RegularExpressions;

namespace CleanArch.Enterprise.Entities;

public class Email
{
    private string _value;

    public Email(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Email cannot be empty");
        if (!Regex.IsMatch(value, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            throw new ArgumentException("Email is not valid");
        _value = value;
    }

    public string Value
    {
        get { return _value; }
    }
}