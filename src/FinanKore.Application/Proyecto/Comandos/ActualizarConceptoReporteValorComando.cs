using FinanKore.Aplicacion.Proyecto.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Comandos;

public sealed record ActualizarConceptoReporteValorComando(
    Guid ConceptoId,
    decimal Valor) : IRequest<ConceptoReporteDto>;
