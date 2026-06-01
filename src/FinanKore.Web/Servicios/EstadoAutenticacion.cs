namespace FinanKore.Web.Servicios;

public sealed class EstadoAutenticacion
{
    private UsuarioRegistradoDto? _usuario;

    public event Action? AlCambiarEstado;

    public UsuarioRegistradoDto? Usuario
    {
        get => _usuario;
        set
        {
            _usuario = value;
            AlCambiarEstado?.Invoke();
        }
    }

    public bool Autenticado => Usuario is not null;
}
