namespace FinanKore.Aplicacion.Proyecto.Dtos;

public sealed record ReporteConConceptosDto(
    Guid Id,
    Guid ProyectoId,
    string Nombre,
    string Descripcion,
    DateTimeOffset FechaCreacion,
    IReadOnlyList<ConceptoReporteDto> Conceptos);
