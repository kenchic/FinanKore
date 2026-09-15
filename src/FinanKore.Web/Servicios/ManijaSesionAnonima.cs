using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FinanKore.Web.Servicios;

public sealed class ManijaSesionAnonima : AuthenticationHandler<AuthenticationSchemeOptions>
{
    public ManijaSesionAnonima(
        IOptionsMonitor<AuthenticationSchemeOptions> opciones,
        ILoggerFactory fabricaLog,
        UrlEncoder codificador)
        : base(opciones, fabricaLog, codificador)
    {
    }

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        => Task.FromResult(AuthenticateResult.NoResult());

    protected override Task HandleChallengeAsync(AuthenticationProperties properties)
    {
        Response.Redirect("/iniciar-sesion");
        return Task.CompletedTask;
    }
}
