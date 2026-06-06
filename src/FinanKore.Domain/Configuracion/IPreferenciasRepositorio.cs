using FinanKore.Dominio.Comun;

namespace FinanKore.Dominio.Configuracion;

public interface IPreferenciasRepositorio : IRepositorio<Preferencias>
{
    Task<Preferencias?> ObtenerPorUsuarioAsync(Guid usuarioId, CancellationToken token = default);
}
