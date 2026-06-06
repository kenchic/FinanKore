using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Configuracion.Eventos;
using FinanKore.Dominio.Configuracion.ObjetosValor;
using FinanKore.Dominio.Excepciones;

namespace FinanKore.Dominio.Configuracion;

public sealed class Preferencias : Entidad, IRaizAgregado
{
    public Guid UsuarioId { get; private set; }
    public ModoTema Tema { get; private set; }

    private Preferencias()
    {
    }

    private Preferencias(Guid usuarioId, ModoTema tema)
    {
        Id = Guid.NewGuid();
        UsuarioId = usuarioId;
        Tema = tema;

        AgregarEvento(new TemaCambiado(Id, UsuarioId, tema));
    }

    public static Preferencias Crear(Guid usuarioId, ModoTema tema = ModoTema.Claro)
    {
        if (usuarioId == Guid.Empty)
            throw new ExcepcionDominio("El UsuarioId es obligatorio.");

        return new Preferencias(usuarioId, tema);
    }

    public void CambiarTema(ModoTema nuevoTema)
    {
        if (Tema == nuevoTema)
            return;

        Tema = nuevoTema;

        AgregarEvento(new TemaCambiado(Id, UsuarioId, nuevoTema));
    }
}
