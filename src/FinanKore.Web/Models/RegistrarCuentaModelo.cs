namespace FinanKore.Web.Models;

public sealed class RegistrarCuentaModelo
{
    public string Correo { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string? ImagenUrl { get; set; }
}
