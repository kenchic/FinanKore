using FinanKore.Aplicacion.Proyecto.Dtos;
using FinanKore.Dominio.Proyecto;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Consultas;

public sealed class ObtenerReportesPorProyectoManejador(
    IReporteRepositorio repositorio)
    : IRequestHandler<ObtenerReportesPorProyectoConsulta, IReadOnlyList<ReporteDto>>
{
    public async Task<IReadOnlyList<ReporteDto>> Handle(
        ObtenerReportesPorProyectoConsulta consulta,
        CancellationToken token)
    {
        var reportes = await repositorio.ObtenerPorProyectoAsync(consulta.ProyectoId, token);

        return reportes
            .Select(r => new ReporteDto(r.Id, r.ProyectoId, r.Nombre, r.Descripcion, r.FechaCreacion))
            .ToList();
    }
}
