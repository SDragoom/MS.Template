using MS.Template.Api.Extensoes;
using MS.Template.Infraestrutura.Configuracoes;
using Serilog;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using System.Text.Json;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(
        "logs/log-.txt",
        rollingInterval: RollingInterval.Day)
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog();

builder.Services.AdicionarDependencias();

builder.Services.AddControllers();

builder.Services.AdicionarInfraestrutura(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddHealthChecks();

var app = builder.Build();

app.UsarTratamentoGlobalExcecoes();

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.MapHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = async (context, report) =>
    {
        var resposta = new
        {
            status = report.Status.ToString(),
            servico = "MS.Template",
            versao = "1.0.0",
            dataHora = DateTime.UtcNow
        };

        context.Response.ContentType = "application/json";

        await context.Response.WriteAsync(
            JsonSerializer.Serialize(resposta));
    }
});
app.Run();