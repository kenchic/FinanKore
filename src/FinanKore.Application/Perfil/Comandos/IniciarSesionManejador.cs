using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Perfil.Dtos;
using FinanKore.Dominio.Excepciones;
using FinanKore.Dominio.Perfil;
using FinanKore.Dominio.Perfil.ObjetosValor;
using MediatR;

namespace FinanKore.Aplicacion.Perfil.Comandos;

public sealed class IniciarSesionManejador(
    IUsuarioRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<IniciarSesionComando, UsuarioDto>
{

    public async Task<UsuarioDto> Handle(
        IniciarSesionComando comando,
        CancellationToken token)
    {
        var correo = new CorreoElectronico(comando.Correo);

        var usuario = await repositorio.ObtenerPorCorreoAsync(correo, token)
            ?? throw new ExcepcionDominio("Correo o contraseña incorrectos.");

        usuario.IniciarSesion(comando.Password);

        await unidadDeTrabajo.GuardarCambiosAsync(token);

        return new UsuarioDto(
            usuario.Id,
            usuario.Correo,
            usuario.Nombre.Completo,
            usuario.Imagen.Url,
            usuario.FechaRegistro
        );
    }
}
