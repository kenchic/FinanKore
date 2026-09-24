using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Finanzas.Dtos;
using FinanKore.Dominio.Finanzas;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed class ActualizarConceptoManejador(
    IProyectoRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<ActualizarConceptoComando, ConceptoDto>
{
    public async Task<ConceptoDto> Handle(
        ActualizarConceptoComando comando,
        CancellationToken token)
    {
        var concepto = await repositorio.ObtenerConceptoPorIdAsync(comando.ConceptoId, token);

        if (concepto is null)
            throw new InvalidOperationException($"No se encontró el concepto Id {comando.ConceptoId}");

        var proyecto = await repositorio.ObtenerPorIdConConceptosAsync(concepto.ProyectoId, token)
            ?? throw new InvalidOperationException($"No se encontró el proyecto Id {concepto.ProyectoId}");

        proyecto.ActualizarConcepto(
            comando.ConceptoId,
            comando.Nombre,
            comando.Valor,
            comando.CategoriaId,
            comando.CategoriaSecundariaId);

        await unidadDeTrabajo.GuardarCambiosAsync(token);

        return new ConceptoDto(
            concepto.Id,
            concepto.Nombre,
            concepto.Valor,
            concepto.Tipo,
            concepto.ProyectoId,
            concepto.CategoriaId,
            concepto.FechaCreacion,
            concepto.CategoriaSecundariaId);
    }
}
