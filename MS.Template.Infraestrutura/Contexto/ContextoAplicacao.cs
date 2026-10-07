using Microsoft.EntityFrameworkCore;

namespace MS.Template.Infraestrutura.Contexto;

public class ContextoAplicacao : DbContext
{
    public ContextoAplicacao(
        DbContextOptions<ContextoAplicacao> options)
        : base(options)
    {
    }
}