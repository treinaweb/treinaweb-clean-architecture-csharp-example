namespace CleanArch.Infra.Web;

public class Response
{
    public StatusCode StatusCode { get; set; }
    public string Body { get; set; }

    public Response(StatusCode statusCode, string body)
    {
        StatusCode = statusCode;
        Body = body;
    }
}