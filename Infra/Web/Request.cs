namespace CleanArch.Infra.Web;

public class Request
{
    public string? Body { get; set; }

    public Request(string? body = "")
    {
        Body = body;
    }
}