using FinanKore.Aplicacion.Finanzas.Comandos;
using FinanKore.Dominio.Excepciones;
using MediatR;

namespace FinanKore.WebApi.Endpoints;

public static class FinanzasEndpoints
{
    public static IEndpointRouteBuilder MapFinanzasEndpoints(this IEndpointRouteBuilder app)
    {
        var grupo = app.MapGroup("api/finanzas")
            .WithTags("Finanzas");

        grupo.MapPost("proyectos", async (
            CrearProyectoComando comando,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                var resultado = await mediador.Send(comando, token);
                return Results.Created($"/api/finanzas/proyectos/{resultado.Id}", resultado);
            }
            catch (ExcepcionDominio ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        });

        return app;
    }
}
