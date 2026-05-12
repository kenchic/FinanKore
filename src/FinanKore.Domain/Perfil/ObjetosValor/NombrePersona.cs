using FinanKore.Dominio.Excepciones;

namespace FinanKore.Dominio.Perfil.ObjetosValor;

public sealed class NombrePersona : Comun.ObjetoValor
{
    public string Nombres { get; }
    public string Apellidos { get; }
    public string Completo => $"{Nombres} {Apellidos}".Trim();

    private NombrePersona(string nombres, string apellidos)
    {
        Nombres = nombres;
        Apellidos = apellidos;
    }

    public static NombrePersona Crear(string nombreCompleto)
    {
        if (string.IsNullOrWhiteSpace(nombreCompleto))
            throw new ExcepcionDominio("El nombre no puede estar vacío.");

        var partes = nombreCompleto.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (partes.Length < 1)
            throw new ExcepcionDominio("El nombre debe tener al menos un carácter.");

        var nombres = partes[0];
        var apellidos = partes.Length > 1
            ? string.Join(" ", partes.Skip(1))
            : string.Empty;

        return new NombrePersona(nombres, apellidos);
    }

    protected override IEnumerable<object> ObtenerComponentesIgualdad()
    {
        yield return Nombres.ToLowerInvariant();
        yield return Apellidos.ToLowerInvariant();
    }

    public override string ToString() => Completo;
}
