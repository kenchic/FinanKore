using FinanKore.Aplicacion.Perfil.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Perfil.Comandos;

public sealed record RegistrarUsuarioComando(
    string Correo,
    string Nombre,
    string Password,
    string? ImagenUrl
) : IRequest<UsuarioDto>;
