using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Proyecto.Dtos;
using FinanKore.Dominio.Proyecto;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Comandos;

public sealed class CrearConceptoReporteManejador(
    IReporteRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<CrearConceptoReporteComando, ConceptoReporteDto>
{
    public async Task<ConceptoReporteDto> Handle(
        CrearConceptoReporteComando comando,
        CancellationToken token)
    {
        var reporte = await repositorio.ObtenerPorIdConConceptosAsync(comando.ReporteId, token)
            ?? throw new global::FinanKore.Dominio.Excepciones.ExcepcionDominio("El reporte no existe.");

        var concepto = reporte.CrearConceptoReporte(comando.Nombre, comando.Valor, comando.Tipo, comando.CategoriaId);

        await unidadDeTrabajo.GuardarCambiosAsync(token);

        return new ConceptoReporteDto(
            concepto.Id,
            concepto.Nombre,
            concepto.Valor,
            (int)concepto.Tipo,
            concepto.ReporteId,
            concepto.CategoriaId,
            concepto.FechaCreacion);
    }
}
