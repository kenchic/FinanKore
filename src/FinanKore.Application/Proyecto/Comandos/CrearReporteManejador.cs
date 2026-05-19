using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Proyecto.Dtos;
using FinanKore.Dominio.Proyecto;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Comandos;

public sealed class CrearReporteManejador(
    IReporteRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<CrearReporteComando, ReporteDto>
{
    public async Task<ReporteDto> Handle(
        CrearReporteComando comando,
        CancellationToken token)
    {
        var reporte = Reporte.Crear(comando.ProyectoId, comando.Nombre, comando.Descripcion);

        await repositorio.AgregarAsync(reporte, token);
        await unidadDeTrabajo.GuardarCambiosAsync(token);

        return new ReporteDto(reporte.Id, reporte.ProyectoId, reporte.Nombre, reporte.Descripcion, reporte.FechaCreacion);
    }
}
