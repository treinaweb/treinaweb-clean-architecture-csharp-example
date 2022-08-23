using CleanArch.Main.Adapters;
using CleanArch.Main.Factories;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet(
    "/api/clients",
    MinimalApisAdapter.Adapt(ClientFactory.GetFindAllClientsController())
);
app.MapPost(
    "/api/clients",
    MinimalApisAdapter.Adapt(ClientFactory.GetCreateClientController())
);

app.Run();
