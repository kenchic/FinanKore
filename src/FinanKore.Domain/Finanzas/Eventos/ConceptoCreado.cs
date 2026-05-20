using FinanKore.Dominio.Finanzas.ObjetosValor;

namespace FinanKore.Dominio.Finanzas.Eventos;

public sealed record ConceptoCreado(
    Guid ConceptoId,
    string Nombre,
    decimal Valor,
    TipoMovimiento Tipo,
    Guid ProyectoId,
    Guid CategoriaId) : Dominio.Eventos.IDominioEvento
{
    public DateTimeOffset FechaOcurrencia { get; } = DateTimeOffset.UtcNow;
}
