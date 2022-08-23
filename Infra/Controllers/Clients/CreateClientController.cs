using CleanArch.Application.UseCases.Clients;
using CleanArch.Infra.Presenters.Clients;
using CleanArch.Infra.Web;

namespace CleanArch.Infra.Controllers.Clients;

public class CreateClientController : IController
{
    private readonly CreateClientUseCase _createClientUseCase;

    public CreateClientController(CreateClientUseCase createClientUseCase)
    {
        _createClientUseCase = createClientUseCase;
    }

    public Response Execute(Request request)
    {
        if (string.IsNullOrEmpty(request.Body))
        {
            return new Response(StatusCode.BadRequest, "Request body is empty");
        }
        var clientToCreate = CreateClientInputBoundary.FromJson(request.Body);
        var createdClient = _createClientUseCase.Execute(clientToCreate);
        return new Response(StatusCode.Created, CreateClientOutputBoundary.ToJson(createdClient));
    }
}