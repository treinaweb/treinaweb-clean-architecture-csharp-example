using CleanArch.Infra.Web;

namespace CleanArch.Infra.Controllers;

public interface IController
{
    Response Execute(Request request);
}