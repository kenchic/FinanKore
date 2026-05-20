using FinanKore.Aplicacion.Finanzas.Dtos;
using FinanKore.Dominio.Finanzas;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Consultas;

public sealed class ObtenerConceptosPorProyectoManejador(
    IProyectoRepositorio repositorio)
    : IRequestHandler<ObtenerConceptosPorProyectoConsulta, IReadOnlyList<ConceptoDto>>
{
    public async Task<IReadOnlyList<ConceptoDto>> Handle(
        ObtenerConceptosPorProyectoConsulta consulta,
        CancellationToken token)
    {
        var proyecto = await repositorio.ObtenerPorIdConConceptosAsync(consulta.ProyectoId, token);

        if (proyecto is null)
            return [];

        return proyecto.Conceptos
            .Select(c => new ConceptoDto(
                c.Id,
                c.Nombre,
                c.Valor,
                c.Tipo,
                c.ProyectoId,
                c.FechaCreacion))
            .ToList();
    }
}
