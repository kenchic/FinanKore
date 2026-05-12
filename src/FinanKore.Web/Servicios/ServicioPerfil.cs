using System.Net.Http.Json;
using FinanKore.Web.Models;

namespace FinanKore.Web.Servicios;

public sealed class ServicioPerfil
{
    private readonly HttpClient _http;

    public ServicioPerfil(HttpClient http)
    {
        _http = http;
    }

    public async Task<UsuarioRegistradoDto?> RegistrarAsync(
        RegistrarCuentaModelo modelo,
        CancellationToken token = default)
    {
        var respuesta = await _http.PostAsJsonAsync(
            "api/perfil/registrar", modelo, token);

        respuesta.EnsureSuccessStatusCode();

        return await respuesta.Content
            .ReadFromJsonAsync<UsuarioRegistradoDto>(cancellationToken: token);
    }

    public async Task<UsuarioRegistradoDto?> IniciarSesionAsync(
        IniciarSesionModelo modelo,
        CancellationToken token = default)
    {
        var respuesta = await _http.PostAsJsonAsync(
            "api/perfil/iniciar-sesion", modelo, token);

        respuesta.EnsureSuccessStatusCode();

        return await respuesta.Content
            .ReadFromJsonAsync<UsuarioRegistradoDto>(cancellationToken: token);
    }
}

public sealed record UsuarioRegistradoDto(
    Guid Id,
    string Correo,
    string NombreCompleto,
    string? ImagenUrl,
    DateTimeOffset FechaRegistro
);
