using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Finanzas.Eventos;

namespace FinanKore.Dominio.Finanzas;

public sealed class Proyecto : Entidad, IRaizAgregado
{
    public string Nombre { get; private set; }

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
}
