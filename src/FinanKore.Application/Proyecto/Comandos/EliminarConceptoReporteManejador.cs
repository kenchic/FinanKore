using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Dominio.Proyecto;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Comandos;

public sealed class EliminarConceptoReporteManejador(
    IReporteRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<EliminarConceptoReporteComando>
{
    public async Task Handle(
        EliminarConceptoReporteComando comando,
        CancellationToken token)
    {
        var reporte = await repositorio.ObtenerPorIdConConceptosAsync(comando.ReporteId, token)
            ?? throw new InvalidOperationException("El reporte no existe.");

        reporte.EliminarConceptoReporte(comando.ConceptoId);

        await unidadDeTrabajo.GuardarCambiosAsync(token);
    }
}
