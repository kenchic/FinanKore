using FinanKore.Dominio.Eventos;

namespace FinanKore.Dominio.Perfil.Eventos;

public sealed record UsuarioRegistrado(
    Guid UsuarioId,
    string CorreoElectronico,
    string NombreCompleto,
    DateTime FechaRegistro
) : IDominioEvento
{
    public DateTime FechaOcurrencia => FechaRegistro;
}
