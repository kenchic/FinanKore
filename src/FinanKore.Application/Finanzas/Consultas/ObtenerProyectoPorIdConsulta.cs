using FinanKore.Aplicacion.Finanzas.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Consultas;

public sealed record ObtenerProyectoPorIdConsulta(Guid Id) : IRequest<ProyectoDto?>;
