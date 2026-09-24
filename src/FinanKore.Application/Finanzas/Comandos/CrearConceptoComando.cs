using FinanKore.Aplicacion.Finanzas.Dtos;
using FinanKore.Dominio.Finanzas.ObjetosValor;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed record CrearConceptoComando(
    Guid ProyectoId,
    Guid CategoriaId,
    Guid? CategoriaSecundariaId,
    string Nombre,
    decimal Valor,
    TipoMovimiento Tipo) : IRequest<ConceptoDto>;
