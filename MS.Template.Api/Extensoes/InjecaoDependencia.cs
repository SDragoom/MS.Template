namespace MS.Template.Api.Extensoes;

public static class InjecaoDependencia
{
    public static IServiceCollection
    AdicionarDependencias(
    this IServiceCollection services)
    {
        return services;
    }
}