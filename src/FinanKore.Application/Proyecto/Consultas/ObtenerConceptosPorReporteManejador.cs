using FinanKore.Aplicacion.Proyecto.Dtos;
using FinanKore.Dominio.Proyecto;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Consultas;

public sealed class ObtenerConceptosPorReporteManejador(
    IReporteRepositorio repositorio)
    : IRequestHandler<ObtenerConceptosPorReporteConsulta, IReadOnlyList<ConceptoReporteDto>>
{
    public async Task<IReadOnlyList<ConceptoReporteDto>> Handle(
        ObtenerConceptosPorReporteConsulta consulta,
        CancellationToken token)
    {
        var reporte = await repositorio.ObtenerPorIdConConceptosAsync(consulta.ReporteId, token);

        if (reporte is null)
            return [];

        return reporte.Conceptos
            .Select(c => new ConceptoReporteDto(
                c.Id,
                c.Nombre,
                c.Valor,
                (int)c.Tipo,
                c.ReporteId,
                c.CategoriaId,
                c.FechaCreacion))
            .ToList();
    }
}
