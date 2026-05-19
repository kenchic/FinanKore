using FinanKore.Aplicacion.Proyecto.Consultas;
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

        return app;
    }
}
