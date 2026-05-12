using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Perfil.Dtos;
using FinanKore.Dominio.Excepciones;
using FinanKore.Dominio.Perfil;
using FinanKore.Dominio.Perfil.ObjetosValor;
using MediatR;

namespace FinanKore.Aplicacion.Perfil.Comandos;

public sealed class IniciarSesionManejador : IRequestHandler<IniciarSesionComando, UsuarioDto>
{
    private readonly IUsuarioRepositorio _repositorio;
    private readonly IUnidadDeTrabajo _unidadDeTrabajo;

    public IniciarSesionManejador(
        IUsuarioRepositorio repositorio,
        IUnidadDeTrabajo unidadDeTrabajo)
    {
        _repositorio = repositorio;
        _unidadDeTrabajo = unidadDeTrabajo;
    }

    public async Task<UsuarioDto> Handle(
        IniciarSesionComando comando,
        CancellationToken token)
    {
        var correo = new CorreoElectronico(comando.Correo);

        var usuario = await _repositorio.ObtenerPorCorreoAsync(correo, token)
            ?? throw new ExcepcionDominio("Correo o contraseña incorrectos.");

        var exito = usuario.IniciarSesion(comando.Password);

        if (!exito)
            throw new ExcepcionDominio("Correo o contraseña incorrectos.");

        if (!usuario.Activo)
            throw new ExcepcionDominio("Tu cuenta está desactivada. Contacta a soporte.");

        await _unidadDeTrabajo.GuardarCambiosAsync(token);

        return new UsuarioDto(
            usuario.Id,
            usuario.Correo,
            usuario.Nombre.Completo,
            usuario.Imagen.Url,
            usuario.FechaRegistro
        );
    }
}
