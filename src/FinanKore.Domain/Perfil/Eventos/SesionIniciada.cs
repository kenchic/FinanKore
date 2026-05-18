using FinanKore.Dominio.Eventos;

namespace FinanKore.Dominio.Perfil.Eventos;

public sealed record SesionIniciada(
    Guid UsuarioId,
    string CorreoElectronico,
    DateTimeOffset FechaInicio
) : IDominioEvento
{
    public DateTimeOffset FechaOcurrencia => FechaInicio;
}
