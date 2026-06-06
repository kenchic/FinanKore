using FinanKore.Dominio.Configuracion;
using Microsoft.EntityFrameworkCore;

namespace FinanKore.Infraestructura.Persistencia.Repositorios;

public sealed class PreferenciasRepositorio(AppDbContext contexto) : IPreferenciasRepositorio
{
    public async Task<Preferencias?> ObtenerPorIdAsync(Guid id, CancellationToken token = default)
        => await contexto.Preferencias.FirstOrDefaultAsync(p => p.Id == id, token);

    public async Task<IReadOnlyList<Preferencias>> ObtenerTodosAsync(CancellationToken token = default)
        => await contexto.Preferencias.ToListAsync(token);

    public async Task AgregarAsync(Preferencias entidad, CancellationToken token = default)
        => await contexto.Preferencias.AddAsync(entidad, token);

    public void Actualizar(Preferencias entidad)
        => contexto.Preferencias.Update(entidad);

    public void Eliminar(Preferencias entidad)
        => contexto.Preferencias.Remove(entidad);

    public async Task<Preferencias?> ObtenerPorUsuarioAsync(Guid usuarioId, CancellationToken token = default)
        => await contexto.Preferencias
            .FirstOrDefaultAsync(p => p.UsuarioId == usuarioId, token);
}
