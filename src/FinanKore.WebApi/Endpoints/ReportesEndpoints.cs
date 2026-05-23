using FinanKore.Aplicacion.Proyecto.Comandos;
using FinanKore.Aplicacion.Proyecto.Consultas;
using FinanKore.Dominio.Excepciones;
using MediatR;

namespace FinanKore.WebApi.Endpoints;

public static class ReportesEndpoints
{
    public static IEndpointRouteBuilder MapReportesEndpoints(this IEndpointRouteBuilder app)
    {
        var grupo = app.MapGroup("api/reportes")
            .WithTags("Reportes");

        grupo.MapGet("", async (
            IMediator mediador,
            CancellationToken token) =>
        {
            var resultado = await mediador.Send(new ObtenerTodosLosReportesConsulta(), token);
            return Results.Ok(resultado);
        });

        // Conceptos del reporte
        grupo.MapGet("{reporteId:guid}/conceptos", async (
            Guid reporteId,
            IMediator mediador,
            CancellationToken token) =>
        {
            var resultado = await mediador.Send(new ObtenerConceptosPorReporteConsulta(reporteId), token);
            return Results.Ok(resultado);
        });

        grupo.MapPost("{reporteId:guid}/conceptos", async (
            Guid reporteId,
            CrearConceptoReporteComando comando,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                var comandoConReporte = comando with { ReporteId = reporteId };
                var resultado = await mediador.Send(comandoConReporte, token);
                return Results.Created($"/api/reportes/{reporteId}/conceptos/{resultado.Id}", resultado);
            }
            catch (ExcepcionDominio ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        });

        grupo.MapPut("{reporteId:guid}/conceptos/{conceptoId:guid}/valor", async (
            Guid reporteId,
            Guid conceptoId,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                var comando = new ActualizarConceptoReporteValorComando(conceptoId, 0);
                var resultado = await mediador.Send(comando, token);
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

        grupo.MapPut("{reporteId:guid}/conceptos/{conceptoId:guid}", async (
            Guid reporteId,
            Guid conceptoId,
            ActualizarConceptoReporteComando comando,
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

        return app;
    }
}
