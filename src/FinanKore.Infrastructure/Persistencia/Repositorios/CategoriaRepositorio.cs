using FinanKore.Dominio.Finanzas;
using Microsoft.EntityFrameworkCore;

namespace FinanKore.Infraestructura.Persistencia.Repositorios;

public sealed class CategoriaRepositorio(AppDbContext contexto) : ICategoriaRepositorio
{
    public async Task<Categoria?> ObtenerPorIdAsync(Guid id, CancellationToken token = default)
        => await contexto.Categorias.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, token);

    public async Task<IReadOnlyList<Categoria>> ObtenerTodosAsync(CancellationToken token = default)
        => await contexto.Categorias.AsNoTracking().ToListAsync(token);

    public async Task AgregarAsync(Categoria entidad, CancellationToken token = default)
        => await contexto.Categorias.AddAsync(entidad, token);

    public void Actualizar(Categoria entidad)
        => contexto.Categorias.Update(entidad);

    public void Eliminar(Categoria entidad)
        => contexto.Categorias.Remove(entidad);

    public async Task<IReadOnlyList<Categoria>> ObtenerActivasAsync(CancellationToken token = default)
        => await contexto.Categorias.AsNoTracking().Where(c => c.Activo).ToListAsync(token);
}
