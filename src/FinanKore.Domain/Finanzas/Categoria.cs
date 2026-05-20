using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Finanzas.Eventos;

namespace FinanKore.Dominio.Finanzas;

public sealed class Categoria : Entidad, IRaizAgregado
{
    public string Nombre { get; private set; }
    public string? Descripcion { get; private set; }
    public bool Activo { get; private set; }
    public DateTimeOffset FechaCreacion { get; private set; }

    private Categoria()
    {
        Nombre = string.Empty;
    }

    private Categoria(string nombre, string? descripcion)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Descripcion = descripcion;
        Activo = true;
        FechaCreacion = DateTimeOffset.UtcNow;

        AgregarEvento(new CategoriaCreada(Id, Nombre));
    }

    public static Categoria Crear(string nombre, string? descripcion)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new Excepciones.ExcepcionDominio("El nombre de la categoría es obligatorio.");

        if (nombre.Length > 200)
            throw new Excepciones.ExcepcionDominio("El nombre de la categoría no puede exceder los 200 caracteres.");

        if (descripcion is { Length: > 500 })
            throw new Excepciones.ExcepcionDominio("La descripción de la categoría no puede exceder los 500 caracteres.");

        return new Categoria(nombre.Trim(), descripcion?.Trim());
    }

    public void ActualizarNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new Excepciones.ExcepcionDominio("El nombre de la categoría es obligatorio.");

        if (nombre.Length > 200)
            throw new Excepciones.ExcepcionDominio("El nombre de la categoría no puede exceder los 200 caracteres.");

        Nombre = nombre.Trim();
    }

    public void ActualizarDescripcion(string? descripcion)
    {
        if (descripcion is { Length: > 500 })
            throw new Excepciones.ExcepcionDominio("La descripción de la categoría no puede exceder los 500 caracteres.");

        Descripcion = descripcion?.Trim();
    }

    public void Desactivar() => Activo = false;

    public void ActivarCategoria() => Activo = true;
}
