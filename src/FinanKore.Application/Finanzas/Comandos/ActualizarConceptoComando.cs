using FinanKore.Aplicacion.Finanzas.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed record ActualizarConceptoComando(
    Guid ConceptoId,
    string Nombre,
    decimal Valor,
    Guid CategoriaId,
    Guid? CategoriaSecundariaId) : IRequest<ConceptoDto>;
