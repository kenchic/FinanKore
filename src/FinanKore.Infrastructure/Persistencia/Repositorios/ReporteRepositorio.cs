using FinanKore.Dominio.Proyecto;
using Microsoft.EntityFrameworkCore;

namespace FinanKore.Infraestructura.Persistencia.Repositorios;

public sealed class ReporteRepositorio(AppDbContext contexto) : IReporteRepositorio
{
    public async Task<Reporte?> ObtenerPorIdAsync(Guid id, CancellationToken token = default)
        => await contexto.Reportes.AsNoTracking().FirstOrDefaultAsync(r => r.Id == id, token);

    public async Task<Reporte?> ObtenerPorIdConConceptosAsync(Guid id, CancellationToken token = default)
        => await contexto.Reportes
            .Include(r => r.Conceptos)
            .FirstOrDefaultAsync(r => r.Id == id, token);

    public async Task<IReadOnlyList<Reporte>> ObtenerTodosAsync(CancellationToken token = default)
        => await contexto.Reportes.AsNoTracking().ToListAsync(token);

    public async Task<IReadOnlyList<Reporte>> ObtenerPorProyectoAsync(Guid proyectoId, CancellationToken token = default)
        => await contexto.Reportes.AsNoTracking().Where(r => r.ProyectoId == proyectoId).ToListAsync(token);

    public async Task<IReadOnlyList<Reporte>> ObtenerPorProyectoConConceptosAsync(Guid proyectoId, CancellationToken token = default)
        => await contexto.Reportes.AsNoTracking()
            .Include(r => r.Conceptos)
            .Where(r => r.ProyectoId == proyectoId)
            .ToListAsync(token);

    public async Task<ConceptoReporte?> ObtenerConceptoPorIdAsync(Guid conceptoId, CancellationToken token = default)
        => await contexto.ConceptoReportes.FirstOrDefaultAsync(c => c.Id == conceptoId, token);

    public async Task AgregarAsync(Reporte entidad, CancellationToken token = default)
        => await contexto.Reportes.AddAsync(entidad, token);

    public void Actualizar(Reporte entidad)
        => contexto.Reportes.Update(entidad);

    public void Eliminar(Reporte entidad)
        => contexto.Reportes.Remove(entidad);
}
