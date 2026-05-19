namespace FinanKore.Aplicacion.Proyecto.Dtos;

public sealed record ReporteDto(Guid Id, Guid ProyectoId, string Nombre, string Descripcion, DateTimeOffset FechaCreacion);
