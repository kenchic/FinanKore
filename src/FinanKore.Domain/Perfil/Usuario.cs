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
    public ImagenPerfil Imagen { get; private set; }
    public DateTime FechaRegistro { get; private set; }
    public DateTime? FechaUltimoAcceso { get; private set; }
    public bool Activo { get; private set; }

    private Usuario()
    {
        Correo = default!;
        Nombre = default!;
        Imagen = default!;
    }

    private Usuario(
        CorreoElectronico correo,
        NombrePersona nombre,
        ImagenPerfil imagen)
    {
        Id = Guid.NewGuid();
        Correo = correo;
        Nombre = nombre;
        Imagen = imagen;
        FechaRegistro = DateTime.UtcNow;
        Activo = true;

        AgregarEvento(new UsuarioRegistrado(Id, Correo, Nombre.Completo, FechaRegistro));
    }

    public static Usuario Registrar(
        CorreoElectronico correo,
        NombrePersona nombre,
        ImagenPerfil? imagen = null)
    {
        if (correo is null)
            throw new ExcepcionDominio("El correo electrónico es obligatorio.");

        if (nombre is null)
            throw new ExcepcionDominio("El nombre es obligatorio.");

        return new Usuario(correo, nombre, imagen ?? ImagenPerfil.Predeterminada);
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

    public void RegistrarAcceso()
    {
        FechaUltimoAcceso = DateTime.UtcNow;
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
