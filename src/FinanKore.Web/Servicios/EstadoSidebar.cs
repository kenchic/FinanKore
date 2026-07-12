namespace FinanKore.Web.Servicios;

public sealed class EstadoSidebar
{
    public const string StorageKey = "fk_sidebar_colapsado";
    private bool _colapsado;

    public event Action? AlCambiar;

    public bool Colapsado
    {
        get => _colapsado;
        set
        {
            if (_colapsado == value) return;
            _colapsado = value;
            AlCambiar?.Invoke();
        }
    }

    public void Alternar() => Colapsado = !Colapsado;
}
