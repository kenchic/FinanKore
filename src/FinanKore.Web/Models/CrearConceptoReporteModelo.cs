namespace FinanKore.Web.Models;

public sealed class CrearConceptoReporteModelo
{
    public string Nombre { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public int Tipo { get; set; } = 1; // 1 = Entrada, 2 = Salida
    public Guid ReporteId { get; set; }
    public Guid CategoriaId { get; set; }
}
