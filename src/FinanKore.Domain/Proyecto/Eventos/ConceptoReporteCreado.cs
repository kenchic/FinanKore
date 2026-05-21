using FinanKore.Dominio.Finanzas.ObjetosValor;

namespace FinanKore.Dominio.Proyecto.Eventos;

public sealed record ConceptoReporteCreado(
    Guid ConceptoReporteId,
    string Nombre,
    decimal Valor,
    TipoMovimiento Tipo,
    Guid ReporteId,
    Guid CategoriaId) : Dominio.Eventos.IDominioEvento
{
    public DateTimeOffset FechaOcurrencia { get; } = DateTimeOffset.UtcNow;
}
