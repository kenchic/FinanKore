using FinanKore.Aplicacion.Perfil.Comandos;
using FinanKore.Aplicacion.Perfil.Dtos;
using FinanKore.Dominio.Excepciones;
using MediatR;

namespace FinanKore.WebApi.Endpoints;

public static class PerfilEndpoints
{
    public static IEndpointRouteBuilder MapPerfilEndpoints(this IEndpointRouteBuilder app)
    {
        var grupo = app.MapGroup("api/perfil")
            .WithTags("Perfil");

        grupo.MapPost("registrar", async (
            RegistrarUsuarioComando comando,
            IMediator mediador,
            CancellationToken token) =>
        {
            try
            {
                var resultado = await mediador.Send(comando, token);
                return Results.Created($"/api/perfil/{resultado.Id}", resultado);
            }
            catch (ExcepcionDominio ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        });

        grupo.MapPost("iniciar-sesion", async (
            IniciarSesionComando comando,
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
