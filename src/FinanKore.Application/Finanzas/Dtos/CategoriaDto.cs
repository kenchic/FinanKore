namespace FinanKore.Aplicacion.Finanzas.Dtos;

public sealed record CategoriaDto(Guid Id, string Nombre, string? Descripcion, bool Activo, DateTimeOffset FechaCreacion);
