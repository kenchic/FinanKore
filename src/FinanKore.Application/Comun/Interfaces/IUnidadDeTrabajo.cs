namespace FinanKore.Aplicacion.Comun.Interfaces;

public interface IUnidadDeTrabajo
{
    Task<int> GuardarCambiosAsync(CancellationToken token = default);
}
