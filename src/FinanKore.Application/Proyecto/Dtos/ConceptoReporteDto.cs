namespace FinanKore.Aplicacion.Proyecto.Dtos;

public sealed record ConceptoReporteDto(
    Guid Id,
    string Nombre,
    decimal Valor,
    int Tipo,
    Guid ReporteId,
    Guid CategoriaId,
    DateTimeOffset FechaCreacion);
