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

        // Categorías: globales al sistema
        grupo.MapGet("categorias", async (
            IMediator mediador,
            CancellationToken token) =>
        {
            var resultado = await mediador.Send(new ObtenerCategoriasConsulta(), token);
            return Results.Ok(resultado);
        });

        grupo.MapPost("categorias", async (
            CrearCategoriaComando comando,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                var resultado = await mediador.Send(comando, token);
                return Results.Created($"/api/finanzas/categorias/{resultado.Id}", resultado);
            }
            catch (ExcepcionDominio ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        });

        // Conceptos: por proyecto
        var conceptoGrupo = app.MapGroup("api/finanzas/proyectos/{proyectoId:guid}/conceptos")
            .WithTags("Finanzas");

        conceptoGrupo.MapGet("", async (
            Guid proyectoId,
            IMediator mediador,
            CancellationToken token) =>
        {
            var resultado = await mediador.Send(new ObtenerConceptosPorProyectoConsulta(proyectoId), token);
            return Results.Ok(resultado);
        });

        conceptoGrupo.MapPost("", async (
            Guid proyectoId,
            CrearConceptoComando comando,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                var resultado = await mediador.Send(comando, token);
                return Results.Created($"/api/finanzas/proyectos/{proyectoId}/conceptos/{resultado.Id}", resultado);
            }
            catch (ExcepcionDominio ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        });

        conceptoGrupo.MapPut("{conceptoId:guid}", async (
            Guid conceptoId,
            ActualizarConceptoComando comando,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                var comandoConId = comando with { ConceptoId = conceptoId };
                var resultado = await mediador.Send(comandoConId, token);
                return Results.Ok(resultado);
            }
            catch (ExcepcionDominio ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return Results.NotFound(new { error = ex.Message });
            }
        });

        conceptoGrupo.MapDelete("{conceptoId:guid}", async (
            Guid proyectoId,
            Guid conceptoId,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                await mediador.Send(new EliminarConceptoComando(proyectoId, conceptoId), token);
                return Results.NoContent();
            }
            catch (ExcepcionDominio ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return Results.NotFound(new { error = ex.Message });
            }
        });

        return app;
    }
}
