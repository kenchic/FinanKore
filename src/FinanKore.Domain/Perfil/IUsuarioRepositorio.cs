using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Perfil.ObjetosValor;

namespace FinanKore.Dominio.Perfil;

public interface IUsuarioRepositorio : IRepositorio<Usuario>
{
    Task<Usuario?> ObtenerPorCorreoAsync(CorreoElectronico correo, CancellationToken token = default);
    Task<bool> ExisteCorreoAsync(CorreoElectronico correo, CancellationToken token = default);
}
