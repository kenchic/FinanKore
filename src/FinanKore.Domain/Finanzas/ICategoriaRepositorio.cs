using FinanKore.Dominio.Comun;

namespace FinanKore.Dominio.Finanzas;

public interface ICategoriaRepositorio : IRepositorio<Categoria>
{
    Task<IReadOnlyList<Categoria>> ObtenerActivasAsync(CancellationToken token = default);
}
