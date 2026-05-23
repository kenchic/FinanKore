using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Proyecto.Dtos;
using FinanKore.Dominio.Finanzas;
using FinanKore.Dominio.Proyecto;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Comandos;

public sealed class CrearReporteManejador(
    IReporteRepositorio repositorio,
    IProyectoRepositorio proyectoRepositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<CrearReporteComando, ReporteDto>
{
    public async Task<ReporteDto> Handle(
        CrearReporteComando comando,
        CancellationToken token)
    {
        var proyecto = await proyectoRepositorio.ObtenerPorIdConConceptosAsync(comando.ProyectoId, token);

        if (proyecto is null)
            throw new InvalidOperationException($"No se encontró el proyecto con Id {comando.ProyectoId}");

        var reporte = Reporte.Crear(comando.ProyectoId, comando.Nombre, comando.Descripcion);

        foreach (var concepto in proyecto.Conceptos)
        {
            reporte.CrearConceptoReporte(
                concepto.Nombre,
                concepto.Valor,
                concepto.Tipo,
                concepto.CategoriaId);
        }

        await repositorio.AgregarAsync(reporte, token);
        await unidadDeTrabajo.GuardarCambiosAsync(token);

        return new ReporteDto(reporte.Id, reporte.ProyectoId, reporte.Nombre, reporte.Descripcion, reporte.FechaCreacion);
    }
}
