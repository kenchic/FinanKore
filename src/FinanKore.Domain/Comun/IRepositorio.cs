namespace FinanKore.Dominio.Comun;

public interface IRepositorio<T> where T : Entidad, IRaizAgregado
{
    Task<T?> ObtenerPorIdAsync(Guid id, CancellationToken token = default);
    Task<IReadOnlyList<T>> ObtenerTodosAsync(CancellationToken token = default);
    Task AgregarAsync(T entidad, CancellationToken token = default);
    void Actualizar(T entidad);
    void Eliminar(T entidad);
}
