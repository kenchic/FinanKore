using System.Security.Cryptography;
using System.Text;
using FinanKore.Dominio.Excepciones;

namespace FinanKore.Dominio.Perfil.ObjetosValor;

public sealed class Credencial : Comun.ObjetoValor
{
    public string Hash { get; }
    public string Salt { get; }

    private Credencial(string hash, string salt)
    {
        Hash = hash;
        Salt = salt;
    }

    public static Credencial Crear(string passwordPlano)
    {
        if (string.IsNullOrWhiteSpace(passwordPlano))
            throw new ExcepcionDominio("La contraseña no puede estar vacía.");

        if (passwordPlano.Length < 6)
            throw new ExcepcionDominio("La contraseña debe tener al menos 6 caracteres.");

        var salt = GenerarSalt();
        var hash = Hashear(passwordPlano, salt);

        return new Credencial(hash, salt);
    }

    public static Credencial DesdePersistencia(string hash, string salt)
    {
        if (string.IsNullOrWhiteSpace(hash))
            throw new ExcepcionDominio("El hash es obligatorio.");

        if (string.IsNullOrWhiteSpace(salt))
            throw new ExcepcionDominio("El salt es obligatorio.");

        return new Credencial(hash, salt);
    }

    public bool Verificar(string passwordPlano)
    {
        if (string.IsNullOrWhiteSpace(passwordPlano))
            return false;

        var hashIntento = Hashear(passwordPlano, Salt);
        return Hash == hashIntento;
    }

    private static string GenerarSalt()
    {
        var bytes = new byte[16];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(bytes);
        return Convert.ToBase64String(bytes);
    }

    private static string Hashear(string password, string salt)
    {
        var bytes = Encoding.UTF8.GetBytes(password + salt);
        var hashBytes = SHA256.HashData(bytes);
        return Convert.ToBase64String(hashBytes);
    }

    protected override IEnumerable<object> ObtenerComponentesIgualdad()
    {
        yield return Hash;
        yield return Salt;
    }
}
