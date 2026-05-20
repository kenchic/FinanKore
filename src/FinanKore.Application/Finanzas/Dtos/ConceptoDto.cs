using FinanKore.Dominio.Finanzas.ObjetosValor;

namespace FinanKore.Aplicacion.Finanzas.Dtos;

public sealed record ConceptoDto(
    Guid Id,
    string Nombre,
    decimal Valor,
    TipoMovimiento Tipo,
    Guid ProyectoId,
    DateTimeOffset FechaCreacion);
