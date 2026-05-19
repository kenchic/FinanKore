namespace FinanKore.Dominio.Proyecto.Eventos;

public sealed record ReporteCreado(Guid ReporteId, Guid ProyectoId, string Nombre) : Dominio.Eventos.IDominioEvento
{
    public DateTimeOffset FechaOcurrencia { get; } = DateTimeOffset.UtcNow;
}
