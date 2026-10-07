namespace MS.Template.Aplicacao.DTOs;

public class RespostaErroDTO
{
    public bool Sucesso { get; set; }

    public string Codigo { get; set; } = string.Empty;

    public string Mensagem { get; set; } = string.Empty;

    public string? CorrelationId { get; set; }
}