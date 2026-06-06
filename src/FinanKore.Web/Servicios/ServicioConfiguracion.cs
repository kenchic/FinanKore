using System.Net.Http.Json;

namespace FinanKore.Web.Servicios;

public sealed class ServicioConfiguracion
{
    private readonly HttpClient _http;

    public ServicioConfiguracion(HttpClient http)
    {
        _http = http;
    }

    public async Task<PreferenciasDto?> ObtenerPreferenciasAsync(Guid usuarioId, CancellationToken token = default)
    {
        var respuesta = await _http.GetAsync($"api/configuracion/preferencias/{usuarioId}", token);
        if (!respuesta.IsSuccessStatusCode)
            return null;

        return await respuesta.Content.ReadFromJsonAsync<PreferenciasDto>(cancellationToken: token);
    }

    public async Task<PreferenciasDto?> CambiarTemaAsync(Guid usuarioId, string tema, CancellationToken token = default)
    {
        var respuesta = await _http.PutAsJsonAsync("api/configuracion/tema", new { usuarioId, tema }, token);

        respuesta.EnsureSuccessStatusCode();

        return await respuesta.Content.ReadFromJsonAsync<PreferenciasDto>(cancellationToken: token);
    }
}

public sealed record PreferenciasDto(
    Guid Id,
    Guid UsuarioId,
    string Tema
);
