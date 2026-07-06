using FinanKore.Aplicacion.Proyecto.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Consultas;

public sealed record ObtenerReportesPorProyectoConsulta(Guid ProyectoId) : IRequest<IReadOnlyList<ReporteConConceptosDto>>;
