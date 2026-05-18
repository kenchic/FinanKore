namespace FinanKore.Dominio.Perfil.ObjetosValor;

public sealed class ImagenPerfil : Comun.ObjetoValor
{
    public string? Url { get; }
    public bool EsPredeterminada => string.IsNullOrWhiteSpace(Url);

    public static ImagenPerfil Predeterminada => new(null);

    private ImagenPerfil(string? url)
    {
        Url = url;
    }

    public static ImagenPerfil Crear(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
            return Predeterminada;

        return new ImagenPerfil(url);
    }

    protected override IEnumerable<object> ObtenerComponentesIgualdad()
    {
        yield return Url ?? string.Empty;
    }

    public override string ToString() => Url ?? "(predeterminada)";
}
