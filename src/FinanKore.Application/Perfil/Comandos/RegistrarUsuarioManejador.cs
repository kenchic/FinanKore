using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Perfil.Dtos;
using FinanKore.Dominio.Excepciones;
using FinanKore.Dominio.Perfil;
using FinanKore.Dominio.Perfil.ObjetosValor;
using MediatR;

namespace FinanKore.Aplicacion.Perfil.Comandos;

public sealed class RegistrarUsuarioManejador(
    IUsuarioRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<RegistrarUsuarioComando, UsuarioDto>
{
    public async Task<UsuarioDto> Handle(
        RegistrarUsuarioComando comando,
        CancellationToken token)
    {
        var correo = new CorreoElectronico(comando.Correo);
        var nombre = NombrePersona.Crear(comando.Nombre);
        var imagen = ImagenPerfil.Crear(comando.ImagenUrl ?? string.Empty);

        if (await repositorio.ExisteCorreoAsync(correo, token))
            throw new ExcepcionDominio($"El correo '{correo}' ya está registrado.");

        var usuario = Usuario.Registrar(correo, nombre, comando.Password, imagen);

        await repositorio.AgregarAsync(usuario, token);
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
