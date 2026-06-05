using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed record EliminarConceptoComando(
    Guid ProyectoId,
    Guid ConceptoId) : IRequest;
