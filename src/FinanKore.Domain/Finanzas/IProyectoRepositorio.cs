using FinanKore.Dominio.Comun;

namespace FinanKore.Dominio.Finanzas;

public interface IProyectoRepositorio : IRepositorio<Proyecto>
{
    Task<Proyecto?> ObtenerPorIdConConceptosAsync(Guid id, CancellationToken token = default);
}
