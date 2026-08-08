namespace FinanKore.Web.Servicios;

public sealed class EstadoCalculadora
{
    public const double PosXDefecto = -1;
    public const double PosYDefecto = -1;

    public event Action? AlCambiar;
    public event Action? AlCambiarPosicion;
    public event Action? AlCambiarMinimizada;

    private bool _abierta;
    private double _posX = PosXDefecto;
    private double _posY = PosYDefecto;
    private bool _minimizada;

    public bool Abierta
    {
        get => _abierta;
        private set
        {
            if (_abierta == value) return;
            _abierta = value;
            AlCambiar?.Invoke();
        }
    }

    public double PosX
    {
        get => _posX;
        set
        {
            if (_posX == value) return;
            _posX = value;
            AlCambiarPosicion?.Invoke();
        }
    }

    public double PosY
    {
        get => _posY;
        set
        {
            if (_posY == value) return;
            _posY = value;
            AlCambiarPosicion?.Invoke();
        }
    }

    public bool Minimizada
    {
        get => _minimizada;
        set
        {
            if (_minimizada == value) return;
            _minimizada = value;
            AlCambiarMinimizada?.Invoke();
        }
    }

    public void Abrir()
    {
        Abierta = true;
        if (_minimizada) Minimizada = false;
    }

    public void Cerrar()
    {
        Abierta = false;
        Minimizada = false;
    }

    public void Alternar() => Abierta = !Abierta;

    public void AlternarMinimizar()
    {
        if (!Abierta) return;
        Minimizada = !Minimizada;
    }

    public void ActualizarPosicion(double x, double y)
    {
        var cambio = false;
        if (_posX != x) { _posX = x; cambio = true; }
        if (_posY != y) { _posY = y; cambio = true; }
        if (cambio) AlCambiarPosicion?.Invoke();
    }
}
