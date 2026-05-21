using FinanKore.Aplicacion.Proyecto.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Consultas;

public sealed record ObtenerConceptosPorReporteConsulta(Guid ReporteId)
    : IRequest<IReadOnlyList<ConceptoReporteDto>>;
