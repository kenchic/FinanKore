using FinanKore.Dominio.Perfil;
using FinanKore.Dominio.Perfil.ObjetosValor;
using Microsoft.EntityFrameworkCore;

namespace FinanKore.Infraestructura.Persistencia.Repositorios;

public sealed class UsuarioRepositorio(AppDbContext contexto) : IUsuarioRepositorio
{
    public async Task<Usuario?> ObtenerPorIdAsync(Guid id, CancellationToken token = default)
        => await contexto.Usuarios.FirstOrDefaultAsync(u => u.Id == id, token);

    public async Task<IReadOnlyList<Usuario>> ObtenerTodosAsync(CancellationToken token = default)
        => await contexto.Usuarios.ToListAsync(token);

    public async Task AgregarAsync(Usuario entidad, CancellationToken token = default)
        => await contexto.Usuarios.AddAsync(entidad, token);

    public void Actualizar(Usuario entidad)
        => contexto.Usuarios.Update(entidad);

    public void Eliminar(Usuario entidad)
        => contexto.Usuarios.Remove(entidad);

    public async Task<Usuario?> ObtenerPorCorreoAsync(
        CorreoElectronico correo,
        CancellationToken token = default)
        => await contexto.Usuarios
            .FirstOrDefaultAsync(u => u.Correo == correo, token);

    public async Task<bool> ExisteCorreoAsync(
        CorreoElectronico correo,
        CancellationToken token = default)
        => await contexto.Usuarios
            .AnyAsync(u => u.Correo == correo, token);
}
