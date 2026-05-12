namespace FinanKore.Dominio.Comun;

public abstract class ObjetoValor
{
    protected abstract IEnumerable<object> ObtenerComponentesIgualdad();

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
            return false;

        var otro = (ObjetoValor)obj;
        return ObtenerComponentesIgualdad()
            .SequenceEqual(otro.ObtenerComponentesIgualdad());
    }

    public override int GetHashCode()
        => ObtenerComponentesIgualdad()
            .Aggregate(1, (actual, obj) => HashCode.Combine(actual, obj));

    public static bool operator ==(ObjetoValor? a, ObjetoValor? b)
    {
        if (a is null && b is null)
            return true;
        if (a is null || b is null)
            return false;
        return a.Equals(b);
    }

    public static bool operator !=(ObjetoValor? a, ObjetoValor? b)
        => !(a == b);
}
