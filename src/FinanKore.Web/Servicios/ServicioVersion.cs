using System.Reflection;

namespace FinanKore.Web.Servicios;

public static class ServicioVersion
{
    private const string VersionPorDefecto = "v0.1.0-alpha";

    private static string? _version;

    public static string Version => _version ??= LeerVersion();

    private static string LeerVersion()
    {
        var informationales = typeof(ServicioVersion)
            .Assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
            .InformationalVersion;

        if (string.IsNullOrWhiteSpace(informationales))
        {
            return VersionPorDefecto;
        }

        var corte = informationales.IndexOf('+');
        var version = corte > 0 ? informationales[..corte] : informationales;

        var prefijosValidos = new[] { "0.", "1.", "2.", "3.", "4.", "5.", "6.", "7.", "8.", "9." };
        if (prefijosValidos.Any(version.StartsWith))
        {
            return $"v{version}";
        }

        return VersionPorDefecto;
    }
}
