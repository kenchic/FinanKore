using FinanKore.Aplicacion.Finanzas.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Consultas;

public sealed record ObtenerProyectosConsulta : IRequest<IReadOnlyList<ProyectoDto>>;
