using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Proyecto.Dtos;
using FinanKore.Dominio.Proyecto;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Comandos;

public sealed class ActualizarConceptoReporteValorManejador(
    IReporteRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<ActualizarConceptoReporteValorComando, ConceptoReporteDto>
{
    public async Task<ConceptoReporteDto> Handle(
        ActualizarConceptoReporteValorComando comando,
        CancellationToken token)
    {
        var concepto = await repositorio.ObtenerConceptoPorIdAsync(comando.ConceptoId, token);

        if (concepto is null)
            throw new InvalidOperationException($"No se encontró el concepto Id {comando.ConceptoId}");

        concepto.ActualizarValor(comando.Valor);

        await unidadDeTrabajo.GuardarCambiosAsync(token);

        return new ConceptoReporteDto(
            concepto.Id,
            concepto.Nombre,
            concepto.Valor,
            concepto.Tipo,
            concepto.ReporteId,
            concepto.CategoriaId,
            concepto.FechaCreacion);
    }
}
