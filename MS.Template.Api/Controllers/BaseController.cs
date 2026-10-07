using Microsoft.AspNetCore.Mvc;
using MS.Template.Aplicacao.DTOs;

namespace MS.Template.Api.Controllers;

[ApiController]
public abstract class BaseController : ControllerBase
{
    protected IActionResult Sucesso<T>(
        T dados,
        string mensagem = "Operação realizada com sucesso.")
    {
        return Ok(new RespostaDTO<T>
        {
            Sucesso = true,
            Mensagem = mensagem,
            Dados = dados
        });
    }
}