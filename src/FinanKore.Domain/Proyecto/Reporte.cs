using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Finanzas.ObjetosValor;
using FinanKore.Dominio.Proyecto.Eventos;

namespace FinanKore.Dominio.Proyecto;

public sealed class Reporte : Entidad, IRaizAgregado
{
    private readonly List<ConceptoReporte> _conceptos = [];

    public Guid ProyectoId { get; private set; }
    public string Nombre { get; private set; }
    public string Descripcion { get; private set; }
    public DateTimeOffset FechaCreacion { get; private set; }
    public IReadOnlyCollection<ConceptoReporte> Conceptos => _conceptos.AsReadOnly();

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

    public ConceptoReporte CrearConceptoReporte(string nombre, decimal valor, TipoMovimiento tipo, Guid categoriaId)
    {
        if (_conceptos.Any(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
            throw new Excepciones.ExcepcionDominio("Ya existe un concepto con el mismo nombre en este reporte.");

        var concepto = ConceptoReporte.Crear(nombre, valor, tipo, Id, categoriaId);
        _conceptos.Add(concepto);

        return concepto;
    }

    public void EliminarConceptoReporte(Guid conceptoId)
    {
        var concepto = _conceptos.FirstOrDefault(c => c.Id == conceptoId)
            ?? throw new Excepciones.ExcepcionDominio("El concepto no existe en este reporte.");

        _conceptos.Remove(concepto);
    }
}
