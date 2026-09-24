using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Finanzas.Eventos;
using FinanKore.Dominio.Finanzas.ObjetosValor;

namespace FinanKore.Dominio.Finanzas;

public sealed class Proyecto : Entidad, IRaizAgregado
{
    private readonly List<Concepto> _conceptos = [];

    public string Nombre { get; private set; }
    public IReadOnlyCollection<Concepto> Conceptos => _conceptos.AsReadOnly();

    private Proyecto()
    {
        Nombre = string.Empty;
    }

    private Proyecto(string nombre)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;

        AgregarEvento(new ProyectoCreado(Id, Nombre));
    }

    public static Proyecto Crear(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new Excepciones.ExcepcionDominio("El nombre del proyecto es obligatorio.");

        return new Proyecto(nombre);
    }

    public Concepto CrearConcepto(string nombre, decimal valor, TipoMovimiento tipo, Guid categoriaId, Guid? categoriaSecundariaId = null)
    {
        if (_conceptos.Any(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) && c.CategoriaId == categoriaId))
            throw new Excepciones.ExcepcionDominio("Ya existe un concepto con el mismo nombre y categoría en este proyecto.");

        var concepto = Concepto.Crear(nombre, valor, tipo, Id, categoriaId, categoriaSecundariaId);
        _conceptos.Add(concepto);

        return concepto;
    }

    public void ActualizarConcepto(Guid conceptoId, string nombre, decimal valor, Guid categoriaId, Guid? categoriaSecundariaId)
    {
        var concepto = _conceptos.FirstOrDefault(c => c.Id == conceptoId)
            ?? throw new Excepciones.ExcepcionDominio("El concepto no existe en este proyecto.");

        if (_conceptos.Any(c =>
                c.Id != conceptoId &&
                c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
                c.CategoriaId == categoriaId))
            throw new Excepciones.ExcepcionDominio("Ya existe un concepto con el mismo nombre y categoría en este proyecto.");

        concepto.ActualizarNombre(nombre);
        concepto.ActualizarValor(valor);
        concepto.ActualizarCategoria(categoriaId);
        concepto.ActualizarCategoriaSecundaria(categoriaSecundariaId);
    }

    public void EliminarConcepto(Guid conceptoId)
    {
        var concepto = _conceptos.FirstOrDefault(c => c.Id == conceptoId)
            ?? throw new Excepciones.ExcepcionDominio("El concepto no existe en este proyecto.");

        _conceptos.Remove(concepto);
    }
}
