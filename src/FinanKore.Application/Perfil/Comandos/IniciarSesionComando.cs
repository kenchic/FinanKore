using FinanKore.Aplicacion.Perfil.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Perfil.Comandos;

public sealed record IniciarSesionComando(
    string Correo,
    string Password
) : IRequest<UsuarioDto>;
