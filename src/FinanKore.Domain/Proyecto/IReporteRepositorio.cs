using FinanKore.Dominio.Comun;

namespace FinanKore.Dominio.Proyecto;

public interface IReporteRepositorio : IRepositorio<Reporte>
{
    Task<IReadOnlyList<Reporte>> ObtenerPorProyectoAsync(Guid proyectoId, CancellationToken token = default);
}
