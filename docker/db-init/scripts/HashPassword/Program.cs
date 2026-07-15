using System.Security.Cryptography;
using System.Text;

if (args.Length == 0)
{
    Console.Error.WriteLine("Uso: HashPassword <password>");
    return 1;
}

var passwordPlano = args[0];

if (string.IsNullOrWhiteSpace(passwordPlano))
{
    Console.Error.WriteLine("La contraseña no puede estar vacía.");
    return 1;
}

var bytesSalt = new byte[16];
using (var rng = RandomNumberGenerator.Create())
{
    rng.GetBytes(bytesSalt);
}
var salt = Convert.ToBase64String(bytesSalt);

var bytesHash = SHA256.HashData(Encoding.UTF8.GetBytes(passwordPlano + salt));
var hash = Convert.ToBase64String(bytesHash);

Console.WriteLine($"{hash}:{salt}");
return 0;
