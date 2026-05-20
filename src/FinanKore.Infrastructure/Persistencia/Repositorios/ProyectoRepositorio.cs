using FinanKore.Dominio.Finanzas;
using FinanKore.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace FinanKore.Infraestructura.Persistencia.Repositorios;

public sealed class ProyectoRepositorio(AppDbContext contexto) : IProyectoRepositorio
{
    public async Task<Proyecto?> ObtenerPorIdAsync(Guid id, CancellationToken token = default)
        => await contexto.Proyectos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id, token);

    public async Task<Proyecto?> ObtenerPorIdConConceptosAsync(Guid id, CancellationToken token = default)
        => await contexto.Proyectos
            .Include(p => p.Conceptos)
            .FirstOrDefaultAsync(p => p.Id == id, token);

    public async Task<IReadOnlyList<Proyecto>> ObtenerTodosAsync(CancellationToken token = default)
        => await contexto.Proyectos.AsNoTracking().ToListAsync(token);

    public async Task AgregarAsync(Proyecto entidad, CancellationToken token = default)
        => await contexto.Proyectos.AddAsync(entidad, token);

    public void Actualizar(Proyecto entidad)
        => contexto.Proyectos.Update(entidad);

    public void Eliminar(Proyecto entidad)
        => contexto.Proyectos.Remove(entidad);
}
