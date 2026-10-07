using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MS.Template.Infraestrutura.Contexto;

namespace MS.Template.Infraestrutura.Configuracoes;

public static class InjecaoDependenciaInfraestrutura
{
    public static IServiceCollection AdicionarInfraestrutura(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ContextoAplicacao>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("Principal"));
        });

        return services;
    }
}