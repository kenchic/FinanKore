using System.Net.Http.Json;
using FinanKore.Web.Models;

namespace FinanKore.Web.Servicios;

public sealed class ServicioFinanzas
{
    private readonly HttpClient _http;

    public ServicioFinanzas(HttpClient http)
    {
        _http = http;
    }

    public async Task<ProyectoCreadoDto?> CrearProyectoAsync(
        CrearProyectoModelo modelo,
        CancellationToken token = default)
    {
        var respuesta = await _http.PostAsJsonAsync(
            "api/finanzas/proyectos", modelo, token);

        respuesta.EnsureSuccessStatusCode();

        return await respuesta.Content
            .ReadFromJsonAsync<ProyectoCreadoDto>(cancellationToken: token);
    }
}

public sealed record ProyectoCreadoDto(Guid Id, string Nombre);
