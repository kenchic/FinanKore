namespace FinanKore.Dominio.Finanzas.Eventos;

public sealed record CategoriaCreada(Guid CategoriaId, string Nombre, Guid ProyectoId) : Dominio.Eventos.IDominioEvento
{
    public DateTimeOffset FechaOcurrencia { get; } = DateTimeOffset.UtcNow;
}
