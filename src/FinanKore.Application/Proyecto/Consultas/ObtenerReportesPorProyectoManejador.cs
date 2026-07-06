using FinanKore.Aplicacion.Proyecto.Dtos;
using FinanKore.Dominio.Proyecto;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Consultas;

public sealed class ObtenerReportesPorProyectoManejador(
    IReporteRepositorio repositorio)
    : IRequestHandler<ObtenerReportesPorProyectoConsulta, IReadOnlyList<ReporteConConceptosDto>>
{
    public async Task<IReadOnlyList<ReporteConConceptosDto>> Handle(
        ObtenerReportesPorProyectoConsulta consulta,
        CancellationToken token)
    {
        var reportes = await repositorio.ObtenerPorProyectoConConceptosAsync(consulta.ProyectoId, token);

        return reportes
            .Select(r => new ReporteConConceptosDto(
                r.Id,
                r.ProyectoId,
                r.Nombre,
                r.Descripcion,
                r.FechaCreacion,
                r.Conceptos
                    .Select(c => new ConceptoReporteDto(
                        c.Id,
                        c.Nombre,
                        c.Valor,
                        (int)c.Tipo,
                        c.ReporteId,
                        c.CategoriaId,
                        c.FechaCreacion))
                    .ToList()))
            .ToList();
    }
}
