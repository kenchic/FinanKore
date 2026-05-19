using FinanKore.Aplicacion.Proyecto.Dtos;
using FinanKore.Dominio.Finanzas;
using FinanKore.Dominio.Proyecto;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Consultas;

public sealed class ObtenerTodosLosReportesManejador(
    IReporteRepositorio repositorioReportes,
    IProyectoRepositorio repositorioProyectos)
    : IRequestHandler<ObtenerTodosLosReportesConsulta, IReadOnlyList<ReporteListadoDto>>
{
    public async Task<IReadOnlyList<ReporteListadoDto>> Handle(
        ObtenerTodosLosReportesConsulta consulta,
        CancellationToken token)
    {
        var reportes = await repositorioReportes.ObtenerTodosAsync(token);
        var proyectos = await repositorioProyectos.ObtenerTodosAsync(token);

        var proyectoPorId = proyectos.ToDictionary(p => p.Id, p => p.Nombre);

        return reportes
            .Select(r => new ReporteListadoDto(
                r.Id,
                r.ProyectoId,
                proyectoPorId.GetValueOrDefault(r.ProyectoId, "Desconocido"),
                r.Nombre,
                r.Descripcion,
                r.FechaCreacion))
            .OrderByDescending(r => r.FechaCreacion)
            .ToList();
    }
}
