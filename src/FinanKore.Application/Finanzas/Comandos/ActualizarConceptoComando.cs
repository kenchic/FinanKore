using FinanKore.Aplicacion.Finanzas.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed record ActualizarConceptoComando(
    Guid ConceptoId,
    string Nombre,
    decimal Valor) : IRequest<ConceptoDto>;
