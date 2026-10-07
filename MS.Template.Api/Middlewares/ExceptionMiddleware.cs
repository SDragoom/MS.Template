using System.Net;
using System.Text.Json;
using MS.Template.Aplicacao.DTOs;

namespace MS.Template.Api.Middlewares;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(
        RequestDelegate next,
        ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Erro não tratado durante o processamento da requisição.");

            await TratarExcecaoAsync(context, ex);
        }
    }

    private static async Task TratarExcecaoAsync(
        HttpContext context,
        Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        var resposta = new RespostaErroDTO
        {
            Sucesso = false,
            Codigo = "ERRO_INTERNO",
            Mensagem = "Ocorreu um erro interno na aplicação.",
            CorrelationId = context.TraceIdentifier
        };

        await context.Response.WriteAsync(
            JsonSerializer.Serialize(resposta));
    }
}