namespace FinanKore.Web.Models;

public sealed class CrearReporteModelo
{
    public Guid ProyectoId { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
}
