using Microsoft.AspNetCore.Mvc;

namespace MS.Template.Api.Controllers;

[ApiController]
[Route("api/versao")]
public class VersaoController : BaseController
{
    [HttpGet]
    public IActionResult Obter()
    {
        return Sucesso(new
        {
            Servico = "MS.Template",
            Versao = "1.0.0"
        });
    }
}