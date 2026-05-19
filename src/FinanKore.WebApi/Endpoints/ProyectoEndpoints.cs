using FinanKore.Aplicacion.Proyecto.Comandos;
using FinanKore.Aplicacion.Proyecto.Consultas;
using FinanKore.Dominio.Excepciones;
using MediatR;

namespace FinanKore.WebApi.Endpoints;

public static class ProyectoEndpoints
{
    public static IEndpointRouteBuilder MapProyectoEndpoints(this IEndpointRouteBuilder app)
    {
        var grupo = app.MapGroup("api/proyectos/{proyectoId:guid}/reportes")
            .WithTags("Proyecto");

        grupo.MapGet("", async (
            Guid proyectoId,
            IMediator mediador,
            CancellationToken token) =>
        {
            var resultado = await mediador.Send(new ObtenerReportesPorProyectoConsulta(proyectoId), token);
            return Results.Ok(resultado);
        });

        grupo.MapPost("", async (
            Guid proyectoId,
            CrearReporteComando comando,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                var comandoConProyecto = comando with { ProyectoId = proyectoId };
                var resultado = await mediador.Send(comandoConProyecto, token);
                return Results.Created($"/api/proyectos/{proyectoId}/reportes/{resultado.Id}", resultado);
            }
            catch (ExcepcionDominio ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        });

        return app;
    }
}
