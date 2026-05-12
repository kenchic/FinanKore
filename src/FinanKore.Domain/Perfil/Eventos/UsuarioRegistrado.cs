using FinanKore.Dominio.Eventos;

namespace FinanKore.Dominio.Perfil.Eventos;

public sealed record UsuarioRegistrado(
    Guid UsuarioId,
    string CorreoElectronico,
    string NombreCompleto,
    DateTimeOffset FechaRegistro
) : IDominioEvento
{
    public DateTimeOffset FechaOcurrencia => FechaRegistro;
}
