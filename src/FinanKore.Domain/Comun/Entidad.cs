using FinanKore.Dominio.Eventos;

namespace FinanKore.Dominio.Comun;

public abstract class Entidad
{
    private readonly List<IDominioEvento> _eventos = [];

    public Guid Id { get; protected set; }

    public IReadOnlyCollection<IDominioEvento> Eventos => _eventos.AsReadOnly();

    protected void AgregarEvento(IDominioEvento evento)
    {
        _eventos.Add(evento);
    }

    public void LimpiarEventos()
    {
        _eventos.Clear();
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Entidad otra)
            return false;

        if (ReferenceEquals(this, otra))
            return true;

        if (GetType() != otra.GetType())
            return false;

        return Id != Guid.Empty && Id == otra.Id;
    }

    public override int GetHashCode() => Id.GetHashCode();

    public static bool operator ==(Entidad? a, Entidad? b)
        => a is not null && b is not null && a.Equals(b);

    public static bool operator !=(Entidad? a, Entidad? b)
        => !(a == b);
}
