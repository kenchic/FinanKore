namespace FinanKore.Aplicacion.Finanzas.Dtos;

public sealed record CategoriaDto(Guid Id, string Nombre, string? Descripcion, Guid ProyectoId, bool Activo, DateTimeOffset FechaCreacion);
