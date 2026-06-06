using FinanKore.Aplicacion.Configuracion.Comandos;
using FinanKore.Aplicacion.Configuracion.Consultas;
using FinanKore.Dominio.Excepciones;
using MediatR;

namespace FinanKore.WebApi.Endpoints;

public static class ConfiguracionEndpoints
{
    public static IEndpointRouteBuilder MapConfiguracionEndpoints(this IEndpointRouteBuilder app)
    {
        var grupo = app.MapGroup("api/configuracion")
            .WithTags("Configuracion");

        grupo.MapGet("preferencias/{usuarioId:guid}", async (
            Guid usuarioId,
            IMediator mediador,
            CancellationToken token) =>
        {
            var resultado = await mediador.Send(new ObtenerPreferenciasConsulta(usuarioId), token);
            return resultado is not null ? Results.Ok(resultado) : Results.NotFound();
        });

        grupo.MapPut("tema", async (
            CambiarTemaComando comando,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                var resultado = await mediador.Send(comando, token);
                return Results.Ok(resultado);
            }
            catch (ExcepcionDominio ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        });

        return app;
    }
}
