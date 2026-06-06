using FinanKore.Aplicacion.Configuracion.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Configuracion.Consultas;

public sealed record ObtenerPreferenciasConsulta(Guid UsuarioId) : IRequest<PreferenciasDto?>;
