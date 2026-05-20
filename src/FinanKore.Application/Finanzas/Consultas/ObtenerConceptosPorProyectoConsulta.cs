using FinanKore.Aplicacion.Finanzas.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Consultas;

public sealed record ObtenerConceptosPorProyectoConsulta(Guid ProyectoId)
    : IRequest<IReadOnlyList<ConceptoDto>>;
