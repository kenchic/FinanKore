using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Proyecto.Eventos;

namespace FinanKore.Dominio.Proyecto;

public sealed class Reporte : Entidad, IRaizAgregado
{
    public Guid ProyectoId { get; private set; }
    public string Nombre { get; private set; }
    public string Descripcion { get; private set; }
    public DateTimeOffset FechaCreacion { get; private set; }

    private Reporte()
    {
        Nombre = string.Empty;
        Descripcion = string.Empty;
    }

    private Reporte(Guid proyectoId, string nombre, string descripcion)
    {
        Id = Guid.NewGuid();
        ProyectoId = proyectoId;
        Nombre = nombre;
        Descripcion = descripcion;
        FechaCreacion = DateTimeOffset.UtcNow;

        AgregarEvento(new ReporteCreado(Id, ProyectoId, Nombre));
    }

    public static Reporte Crear(Guid proyectoId, string nombre, string descripcion)
    {
        if (proyectoId == Guid.Empty)
            throw new Excepciones.ExcepcionDominio("El identificador del proyecto es obligatorio.");

        if (string.IsNullOrWhiteSpace(nombre))
            throw new Excepciones.ExcepcionDominio("El nombre del reporte es obligatorio.");

        return new Reporte(proyectoId, nombre.Trim(), descripcion?.Trim() ?? string.Empty);
    }
}
