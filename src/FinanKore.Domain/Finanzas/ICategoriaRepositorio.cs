using FinanKore.Dominio.Comun;

namespace FinanKore.Dominio.Finanzas;

public interface ICategoriaRepositorio : IRepositorio<Categoria>
{
    Task<IReadOnlyList<Categoria>> ObtenerPorProyectoAsync(Guid proyectoId, CancellationToken token = default);
}
