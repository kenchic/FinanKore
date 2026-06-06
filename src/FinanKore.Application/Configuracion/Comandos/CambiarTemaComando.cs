using FinanKore.Aplicacion.Configuracion.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Configuracion.Comandos;

public sealed record CambiarTemaComando(
    Guid UsuarioId,
    string Tema
) : IRequest<PreferenciasDto>;
