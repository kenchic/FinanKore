using FinanKore.Aplicacion.Proyecto.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Comandos;

public sealed record ActualizarConceptoReporteComando(
    Guid ConceptoId,
    string Nombre,
    decimal Valor) : IRequest<ConceptoReporteDto>;
