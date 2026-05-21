using FinanKore.Dominio.Finanzas.ObjetosValor;

namespace FinanKore.Aplicacion.Proyecto.Dtos;

public sealed record ConceptoReporteDto(
    Guid Id,
    string Nombre,
    decimal Valor,
    TipoMovimiento Tipo,
    Guid ReporteId,
    Guid CategoriaId,
    DateTimeOffset FechaCreacion);
