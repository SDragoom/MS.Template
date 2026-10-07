namespace MS.Template.Aplicacao.DTOs;

public class RespostaPaginadaDTO<T>
{
    public IEnumerable<T> Dados { get; set; }
        = Enumerable.Empty<T>();

    public int Pagina { get; set; }

    public int TamanhoPagina { get; set; }

    public int TotalRegistros { get; set; }
}