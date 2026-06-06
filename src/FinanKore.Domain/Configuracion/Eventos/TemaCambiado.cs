using FinanKore.Dominio.Configuracion.ObjetosValor;

namespace FinanKore.Dominio.Configuracion.Eventos;

public sealed record TemaCambiado(
    Guid PreferenciasId,
    Guid UsuarioId,
    ModoTema NuevoTema
) : Dominio.Eventos.IDominioEvento
{
    public DateTimeOffset FechaOcurrencia { get; } = DateTimeOffset.UtcNow;
}
