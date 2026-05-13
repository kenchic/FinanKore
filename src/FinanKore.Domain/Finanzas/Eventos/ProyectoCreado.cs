namespace FinanKore.Dominio.Finanzas.Eventos;

public sealed record ProyectoCreado(Guid ProyectoId, string Nombre) : Dominio.Eventos.IDominioEvento
{
    public DateTimeOffset FechaOcurrencia { get; } = DateTimeOffset.UtcNow;
}
