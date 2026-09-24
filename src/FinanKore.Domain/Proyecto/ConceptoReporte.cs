using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Finanzas.ObjetosValor;
using FinanKore.Dominio.Proyecto.Eventos;

namespace FinanKore.Dominio.Proyecto;

public sealed class ConceptoReporte : Entidad
{
    public string Nombre { get; private set; }
    public decimal Valor { get; private set; }
    public TipoMovimiento Tipo { get; private set; }
    public Guid ReporteId { get; private set; }
    public Guid CategoriaId { get; private set; }
    public Guid? CategoriaSecundariaId { get; private set; }
    public DateTimeOffset FechaCreacion { get; private set; }

    private ConceptoReporte()
    {
        Nombre = string.Empty;
    }

    private ConceptoReporte(string nombre, decimal valor, TipoMovimiento tipo, Guid reporteId, Guid categoriaId, Guid? categoriaSecundariaId)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Valor = valor;
        Tipo = tipo;
        ReporteId = reporteId;
        CategoriaId = categoriaId;
        CategoriaSecundariaId = categoriaSecundariaId;
        FechaCreacion = DateTimeOffset.UtcNow;

        AgregarEvento(new ConceptoReporteCreado(Id, Nombre, Valor, Tipo, ReporteId, CategoriaId, CategoriaSecundariaId));
    }

    public static ConceptoReporte Crear(string nombre, decimal valor, TipoMovimiento tipo, Guid reporteId, Guid categoriaId, Guid? categoriaSecundariaId = null)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new Excepciones.ExcepcionDominio("El nombre del concepto es obligatorio.");

        if (nombre.Length > 200)
            throw new Excepciones.ExcepcionDominio("El nombre del concepto no puede exceder los 200 caracteres.");

        if (valor < 0)
            throw new Excepciones.ExcepcionDominio("El valor del concepto no puede ser negativo.");

        if (!Enum.IsDefined(typeof(TipoMovimiento), tipo))
            throw new Excepciones.ExcepcionDominio("El tipo de movimiento no es válido.");

        if (reporteId == Guid.Empty)
            throw new Excepciones.ExcepcionDominio("El reporte asociado es obligatorio.");

        if (categoriaId == Guid.Empty)
            throw new Excepciones.ExcepcionDominio("La categoría asociada es obligatoria.");

        if (categoriaSecundariaId.HasValue && categoriaSecundariaId.Value == Guid.Empty)
            throw new Excepciones.ExcepcionDominio("La categoría secundaria no es válida.");

        if (categoriaSecundariaId == categoriaId)
            throw new Excepciones.ExcepcionDominio("La categoría secundaria no puede ser igual a la categoría principal.");

        return new ConceptoReporte(nombre.Trim(), valor, tipo, reporteId, categoriaId, categoriaSecundariaId);
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

    public void ActualizarCategoria(Guid categoriaId)
    {
        if (categoriaId == Guid.Empty)
            throw new Excepciones.ExcepcionDominio("La categoría asociada es obligatoria.");

        CategoriaId = categoriaId;
    }

    public void ActualizarCategoriaSecundaria(Guid? categoriaSecundariaId)
    {
        if (categoriaSecundariaId.HasValue && categoriaSecundariaId.Value == Guid.Empty)
            throw new Excepciones.ExcepcionDominio("La categoría secundaria no es válida.");

        if (categoriaSecundariaId.HasValue && categoriaSecundariaId.Value == CategoriaId)
            throw new Excepciones.ExcepcionDominio("La categoría secundaria no puede ser igual a la categoría principal.");

        CategoriaSecundariaId = categoriaSecundariaId;
    }
}
