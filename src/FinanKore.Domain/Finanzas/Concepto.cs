using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Finanzas.Eventos;
using FinanKore.Dominio.Finanzas.ObjetosValor;

namespace FinanKore.Dominio.Finanzas;

public sealed class Concepto : Entidad
{
    public string Nombre { get; private set; }
    public decimal Valor { get; private set; }
    public TipoMovimiento Tipo { get; private set; }
    public Guid ProyectoId { get; private set; }
    public Guid CategoriaId { get; private set; }
    public DateTimeOffset FechaCreacion { get; private set; }

    private Concepto()
    {
        Nombre = string.Empty;
    }

    private Concepto(string nombre, decimal valor, TipoMovimiento tipo, Guid proyectoId, Guid categoriaId)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Valor = valor;
        Tipo = tipo;
        ProyectoId = proyectoId;
        CategoriaId = categoriaId;
        FechaCreacion = DateTimeOffset.UtcNow;

        AgregarEvento(new ConceptoCreado(Id, Nombre, Valor, Tipo, ProyectoId, CategoriaId));
    }

    public static Concepto Crear(string nombre, decimal valor, TipoMovimiento tipo, Guid proyectoId, Guid categoriaId)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new Excepciones.ExcepcionDominio("El nombre del concepto es obligatorio.");

        if (nombre.Length > 200)
            throw new Excepciones.ExcepcionDominio("El nombre del concepto no puede exceder los 200 caracteres.");

        if (valor < 0)
            throw new Excepciones.ExcepcionDominio("El valor del concepto no puede ser negativo.");

        if (!Enum.IsDefined(typeof(TipoMovimiento), tipo))
            throw new Excepciones.ExcepcionDominio("El tipo de movimiento no es válido.");

        if (proyectoId == Guid.Empty)
            throw new Excepciones.ExcepcionDominio("El proyecto asociado es obligatorio.");

        if (categoriaId == Guid.Empty)
            throw new Excepciones.ExcepcionDominio("La categoría asociada es obligatoria.");

        return new Concepto(nombre.Trim(), valor, tipo, proyectoId, categoriaId);
    }

    public void ActualizarNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new Excepciones.ExcepcionDominio("El nombre del concepto es obligatorio.");

        if (nombre.Length > 200)
            throw new Excepciones.ExcepcionDominio("El nombre del concepto no puede exceder los 200 caracteres.");

        Nombre = nombre.Trim();
    }

    public void ActualizarValor(decimal valor)
    {
        if (valor < 0)
            throw new Excepciones.ExcepcionDominio("El valor del concepto no puede ser negativo.");

        Valor = valor;
    }

    public void ActualizarTipo(TipoMovimiento tipo)
    {
        if (!Enum.IsDefined(typeof(TipoMovimiento), tipo))
            throw new Excepciones.ExcepcionDominio("El tipo de movimiento no es válido.");

        Tipo = tipo;
    }
}
