using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Eventos;
using FinanKore.Dominio.Excepciones;
using FinanKore.Dominio.Perfil.Eventos;
using FinanKore.Dominio.Perfil.ObjetosValor;

namespace FinanKore.Dominio.Perfil;

public sealed class Usuario : Entidad, IRaizAgregado
{
    public CorreoElectronico Correo { get; private set; }
    public NombrePersona Nombre { get; private set; }
    public Credencial Credencial { get; private set; }
    public ImagenPerfil Imagen { get; private set; }
    public DateTimeOffset FechaRegistro { get; private set; }
    public DateTimeOffset? FechaUltimoAcceso { get; private set; }
    public bool Activo { get; private set; }

    private Usuario()
    {
        Correo = default!;
        Nombre = default!;
        Credencial = default!;
        Imagen = default!;
    }

    private Usuario(
        CorreoElectronico correo,
        NombrePersona nombre,
        Credencial credencial,
        ImagenPerfil imagen)
    {
        Id = Guid.NewGuid();
        Correo = correo;
        Nombre = nombre;
        Credencial = credencial;
        Imagen = imagen;
        FechaRegistro = DateTimeOffset.UtcNow;
        Activo = true;

        AgregarEvento(new UsuarioRegistrado(Id, Correo, Nombre.Completo, FechaRegistro));
    }

    public static Usuario Registrar(
        CorreoElectronico correo,
        NombrePersona nombre,
        string passwordPlano,
        ImagenPerfil? imagen = null)
    {
        if (correo is null)
            throw new ExcepcionDominio("El correo electrónico es obligatorio.");

        if (nombre is null)
            throw new ExcepcionDominio("El nombre es obligatorio.");

        if (string.IsNullOrWhiteSpace(passwordPlano))
            throw new ExcepcionDominio("La contraseña es obligatoria.");

        var credencial = Credencial.Crear(passwordPlano);

        return new Usuario(correo, nombre, credencial, imagen ?? ImagenPerfil.Predeterminada);
    }

    public void IniciarSesion(string passwordPlano)
    {
        if (string.IsNullOrWhiteSpace(passwordPlano))
            throw new ExcepcionDominio("La contraseña es obligatoria.");

        if (!Activo)
            throw new ExcepcionDominio("Tu cuenta está desactivada. Contacta a soporte.");

        var exito = Credencial.Verificar(passwordPlano);

        if (!exito)
            throw new ExcepcionDominio("Correo o contraseña incorrectos.");

        FechaUltimoAcceso = DateTimeOffset.UtcNow;

        AgregarEvento(new SesionIniciada(Id, Correo, FechaUltimoAcceso.Value));
    }

    public void ActualizarNombre(NombrePersona nuevoNombre)
    {
        if (nuevoNombre is null)
            throw new ExcepcionDominio("El nombre no puede ser nulo.");

        Nombre = nuevoNombre;
    }

    public void ActualizarImagen(ImagenPerfil nuevaImagen)
    {
        Imagen = nuevaImagen ?? ImagenPerfil.Predeterminada;
    }

    public void CambiarPassword(string passwordActual, string passwordNuevo)
    {
        if (string.IsNullOrWhiteSpace(passwordNuevo))
            throw new ExcepcionDominio("La nueva contraseña no puede estar vacía.");

        if (!Credencial.Verificar(passwordActual))
            throw new ExcepcionDominio("La contraseña actual no es válida.");

        Credencial = Credencial.Crear(passwordNuevo);
    }

    public void RegistrarAcceso()
    {
        FechaUltimoAcceso = DateTimeOffset.UtcNow;
    }

    public void Desactivar()
    {
        Activo = false;
    }

    public void Activar()
    {
        Activo = true;
    }
}
