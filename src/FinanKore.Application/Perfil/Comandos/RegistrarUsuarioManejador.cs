using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Perfil.Dtos;
using FinanKore.Dominio.Excepciones;
using FinanKore.Dominio.Perfil;
using FinanKore.Dominio.Perfil.ObjetosValor;
using MediatR;

namespace FinanKore.Aplicacion.Perfil.Comandos;

public sealed class RegistrarUsuarioManejador : IRequestHandler<RegistrarUsuarioComando, UsuarioDto>
{
    private readonly IUsuarioRepositorio _repositorio;
    private readonly IUnidadDeTrabajo _unidadDeTrabajo;

    public RegistrarUsuarioManejador(
        IUsuarioRepositorio repositorio,
        IUnidadDeTrabajo unidadDeTrabajo)
    {
        _repositorio = repositorio;
        _unidadDeTrabajo = unidadDeTrabajo;
    }

    public async Task<UsuarioDto> Handle(
        RegistrarUsuarioComando comando,
        CancellationToken token)
    {
        var correo = new CorreoElectronico(comando.Correo);
        var nombre = NombrePersona.Crear(comando.Nombre);
        var imagen = ImagenPerfil.Crear(comando.ImagenUrl ?? string.Empty);

        if (await _repositorio.ExisteCorreoAsync(correo, token))
            throw new ExcepcionDominio($"El correo '{correo}' ya está registrado.");

        var usuario = Usuario.Registrar(correo, nombre, imagen);

        await _repositorio.AgregarAsync(usuario, token);
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
