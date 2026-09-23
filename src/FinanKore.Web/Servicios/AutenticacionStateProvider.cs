using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace FinanKore.Web.Servicios;

public sealed class AutenticacionStateProvider : AuthenticationStateProvider
{
    private const string ClaveSesion = "usuario_sesion";

    private static readonly Task<AuthenticationState> EstadoAnonimo = Task.FromResult(
        new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));

    private readonly EstadoAutenticacion _estado;
    private readonly ProtectedSessionStorage _almacenamiento;

    public AutenticacionStateProvider(EstadoAutenticacion estado, ProtectedSessionStorage almacenamiento)
    {
        _estado = estado;
        _almacenamiento = almacenamiento;
        _estado.AlCambiarEstado += OnEstadoCambio;
    }

    public async Task RestaurarSesionAsync()
    {
        if (_estado.Usuario is not null)
        {
            return;
        }

        try
        {
            var resultado = await _almacenamiento.GetAsync<UsuarioRegistradoDto>(ClaveSesion);
            if (resultado.Success && resultado.Value is not null)
            {
                _estado.Usuario = resultado.Value;
            }
        }
        catch
        {
            // Sin circuito disponible (prerendering SSR) o sesión expirada.
        }
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        await RestaurarSesionAsync();

        var usuario = _estado.Usuario;
        if (usuario is null)
        {
            return await EstadoAnonimo;
        }

        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
            new(ClaimTypes.Name, usuario.NombreCompleto),
            new(ClaimTypes.Email, usuario.Correo),
        };

        var identidad = new ClaimsIdentity(claims, authenticationType: "SesionFinanKore");
        return new AuthenticationState(new ClaimsPrincipal(identidad));
    }

    private void OnEstadoCambio()
    {
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
}
