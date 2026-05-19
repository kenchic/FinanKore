namespace FinanKore.Aplicacion.Proyecto.Dtos;

public sealed record ReporteListadoDto(Guid Id, Guid ProyectoId, string ProyectoNombre, string ReporteNombre, string Descripcion, DateTimeOffset FechaCreacion);
