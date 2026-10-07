using Microsoft.AspNetCore.Mvc;
using MS.Template.Aplicacao.DTOs;

namespace MS.Template.Api.Controllers;

[ApiController]
[Route("api/status")]
public class StatusController : BaseController
{
    [HttpGet]
    public IActionResult Obter()
    {
        var resposta = new RespostaDTO<string>
        {
            Sucesso = true,
            Mensagem = "Consulta realizada com sucesso.",
            Dados = "Serviço ativo"
        };

        return Sucesso(resposta);
    }

    [HttpGet("erro")]
    public IActionResult Erro()
    {
        throw new Exception("Teste de exceção");
    }
}