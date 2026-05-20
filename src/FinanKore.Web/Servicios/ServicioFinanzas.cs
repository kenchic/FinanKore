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

    public async Task<List<ProyectoCreadoDto>> ObtenerProyectosAsync(
        CancellationToken token = default)
    {
        var resultado = await _http.GetFromJsonAsync<List<ProyectoCreadoDto>>(
            "api/finanzas/proyectos", token);

        return resultado ?? [];
    }

    public async Task<ProyectoCreadoDto?> ObtenerProyectoPorIdAsync(Guid id,
        CancellationToken token = default)
    {
        var resultado = await _http.GetFromJsonAsync<ProyectoCreadoDto>(
            $"api/finanzas/proyectos/{id}", token);

        return resultado;
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
    public async Task<List<CategoriaCreadaDto>> ObtenerCategoriasAsync(Guid proyectoId,
        CancellationToken token = default)
    {
        var resultado = await _http.GetFromJsonAsync<List<CategoriaCreadaDto>>(
            $"api/finanzas/proyectos/{proyectoId}/categorias", token);

        return resultado ?? [];
    }

    public async Task<CategoriaCreadaDto?> CrearCategoriaAsync(
        CrearCategoriaModelo modelo,
        CancellationToken token = default)
    {
        var respuesta = await _http.PostAsJsonAsync(
            $"api/finanzas/proyectos/{modelo.ProyectoId}/categorias", modelo, token);

        respuesta.EnsureSuccessStatusCode();

        return await respuesta.Content
            .ReadFromJsonAsync<CategoriaCreadaDto>(cancellationToken: token);
    }

    public async Task<List<ReporteCreadoDto>> ObtenerReportesAsync(Guid proyectoId,
        CancellationToken token = default)
    {
        var resultado = await _http.GetFromJsonAsync<List<ReporteCreadoDto>>(
            $"api/proyectos/{proyectoId}/reportes", token);

        return resultado ?? [];
    }

    public async Task<ReporteCreadoDto?> CrearReporteAsync(
        CrearReporteModelo modelo,
        CancellationToken token = default)
    {
        var respuesta = await _http.PostAsJsonAsync(
            $"api/proyectos/{modelo.ProyectoId}/reportes", modelo, token);

        respuesta.EnsureSuccessStatusCode();

        return await respuesta.Content
            .ReadFromJsonAsync<ReporteCreadoDto>(cancellationToken: token);
    }

    public async Task<List<ReporteListadoDto>> ObtenerTodosLosReportesAsync(
        CancellationToken token = default)
    {
        var resultado = await _http.GetFromJsonAsync<List<ReporteListadoDto>>(
            "api/reportes", token);

        return resultado ?? [];
    }

    public async Task<List<ConceptoCreadoDto>> ObtenerConceptosAsync(Guid proyectoId,
        CancellationToken token = default)
    {
        var resultado = await _http.GetFromJsonAsync<List<ConceptoCreadoDto>>(
            $"api/finanzas/proyectos/{proyectoId}/conceptos", token);

        return resultado ?? [];
    }

    public async Task<ConceptoCreadoDto?> CrearConceptoAsync(
        CrearConceptoModelo modelo,
        CancellationToken token = default)
    {
        var respuesta = await _http.PostAsJsonAsync(
            $"api/finanzas/proyectos/{modelo.ProyectoId}/conceptos", modelo, token);

        respuesta.EnsureSuccessStatusCode();

        return await respuesta.Content
            .ReadFromJsonAsync<ConceptoCreadoDto>(cancellationToken: token);
    }
}

public sealed record ProyectoCreadoDto(Guid Id, string Nombre);

public sealed record ConceptoCreadoDto(Guid Id, string Nombre, decimal Valor, int Tipo, Guid ProyectoId, DateTimeOffset FechaCreacion);

public sealed record CategoriaCreadaDto(Guid Id, string Nombre, string? Descripcion, Guid ProyectoId, bool Activo, DateTimeOffset FechaCreacion);

public sealed record ReporteCreadoDto(Guid Id, Guid ProyectoId, string Nombre, string Descripcion, DateTimeOffset FechaCreacion);

public sealed record ReporteListadoDto(Guid Id, Guid ProyectoId, string ProyectoNombre, string ReporteNombre, string Descripcion, DateTimeOffset FechaCreacion);
