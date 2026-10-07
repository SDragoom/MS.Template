public interface IRepositorio<T>
{
    Task<T?> ObterPorIdAsync(Guid id);

    Task<List<T>> ObterTodosAsync();

    Task InserirAsync(T entidade);

    Task AtualizarAsync(T entidade);

    Task ExcluirAsync(T entidade);

}