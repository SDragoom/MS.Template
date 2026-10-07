namespace MS.Template.Dominio.Entidades;

public abstract class EntidadeBase
{
    public int Id { get; protected set; }
    public DateTime DataCriacao { get; protected set; } = DateTime.UtcNow;
}