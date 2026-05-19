using FinanKore.Aplicacion.Finanzas.Comandos;
using FinanKore.Aplicacion.Finanzas.Consultas;
using FinanKore.Dominio.Excepciones;
using MediatR;

namespace FinanKore.WebApi.Endpoints;

public static class FinanzasEndpoints
{
    public static IEndpointRouteBuilder MapFinanzasEndpoints(this IEndpointRouteBuilder app)
    {
        var grupo = app.MapGroup("api/finanzas")
            .WithTags("Finanzas");

        grupo.MapGet("proyectos", async (
            IMediator mediador,
            CancellationToken token) =>
        {
            var resultado = await mediador.Send(new ObtenerProyectosConsulta(), token);
            return Results.Ok(resultado);
        });

        grupo.MapGet("proyectos/{id:guid}", async (
            Guid id,
            IMediator mediador,
            CancellationToken token) =>
        {
            var resultado = await mediador.Send(new ObtenerProyectoPorIdConsulta(id), token);
            return resultado is null ? Results.NotFound() : Results.Ok(resultado);
        });

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

        var categoriaGrupo = app.MapGroup("api/finanzas/proyectos/{proyectoId:guid}/categorias")
            .WithTags("Finanzas");

        categoriaGrupo.MapGet("", async (
            Guid proyectoId,
            IMediator mediador,
            CancellationToken token) =>
        {
            var resultado = await mediador.Send(new ObtenerCategoriasConsulta(proyectoId), token);
            return Results.Ok(resultado);
        });

        categoriaGrupo.MapPost("", async (
            Guid proyectoId,
            CrearCategoriaComando comando,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                var resultado = await mediador.Send(comando, token);
                return Results.Created($"/api/finanzas/proyectos/{proyectoId}/categorias/{resultado.Id}", resultado);
            }
            catch (ExcepcionDominio ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        });

        return app;
    }
}
