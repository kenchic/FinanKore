using FinanKore.Dominio.Comun;

namespace FinanKore.Dominio.Proyecto;

public interface IReporteRepositorio : IRepositorio<Reporte>
{
    Task<Reporte?> ObtenerPorIdConConceptosAsync(Guid id, CancellationToken token = default);
    Task<IReadOnlyList<Reporte>> ObtenerPorProyectoAsync(Guid proyectoId, CancellationToken token = default);
    Task<ConceptoReporte?> ObtenerConceptoPorIdAsync(Guid conceptoId, CancellationToken token = default);
}
