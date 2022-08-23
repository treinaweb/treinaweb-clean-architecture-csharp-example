using CleanArch.Application.UseCases.Clients;
using CleanArch.Infra.Presenters.Clients;
using CleanArch.Infra.Web;

namespace CleanArch.Infra.Controllers.Clients;

public class FindAllClientsController : IController
{
    private readonly FindAllClientsUseCase _findAllClientsUseCase;

    public FindAllClientsController(FindAllClientsUseCase findAllClientsUseCase)
    {
        _findAllClientsUseCase = findAllClientsUseCase;
    }

    public Response Execute(Request request)
    {
        var clients = _findAllClientsUseCase.Execute();
        return new Response(StatusCode.Ok, FindAllClientsOutputBoundary.ToJson(clients));
    }
}