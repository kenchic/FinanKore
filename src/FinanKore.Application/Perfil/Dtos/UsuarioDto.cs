using MediatR;

namespace FinanKore.Aplicacion.Perfil.Dtos;

public sealed record UsuarioDto(
    Guid Id,
    string Correo,
    string NombreCompleto,
    string? ImagenUrl,
    DateTime FechaRegistro
);
