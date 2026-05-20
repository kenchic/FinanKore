namespace FinanKore.Dominio.Finanzas.Eventos;

public sealed record CategoriaCreada(Guid CategoriaId, string Nombre) : Dominio.Eventos.IDominioEvento
{
    public DateTimeOffset FechaOcurrencia { get; } = DateTimeOffset.UtcNow;
}
