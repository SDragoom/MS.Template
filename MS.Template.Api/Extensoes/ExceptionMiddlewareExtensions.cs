using MS.Template.Api.Middlewares;

namespace MS.Template.Api.Extensoes;

public static class ExceptionMiddlewareExtensions
{
    public static IApplicationBuilder UsarTratamentoGlobalExcecoes(
        this IApplicationBuilder app)
    {
        return app.UseMiddleware<ExceptionMiddleware>();
    }
}