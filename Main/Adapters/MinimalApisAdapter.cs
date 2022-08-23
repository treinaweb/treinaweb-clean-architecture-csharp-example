using CleanArch.Infra.Controllers;
using CleanArch.Infra.Web;

namespace CleanArch.Main.Adapters;

public static class MinimalApisAdapter
{
    public static RequestDelegate Adapt(IController controller)
    {
        return async ctx =>
        {
            var json = await new StreamReader(ctx.Request.Body).ReadToEndAsync();
            var request = new Request(json);
            var response = controller.Execute(request);
            ctx.Response.StatusCode = (int)response.StatusCode;
            await ctx.Response.WriteAsync(response.Body);
        };
    }
}