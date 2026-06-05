using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Comandos;

public sealed record EliminarConceptoReporteComando(
    Guid ReporteId,
    Guid ConceptoId) : IRequest;
