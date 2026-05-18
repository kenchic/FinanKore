using FinanKore.Aplicacion.Finanzas.Consultas;
using FinanKore.Aplicacion.Finanzas.Dtos;
using FinanKore.Dominio.Finanzas;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Consultas;

public sealed class ObtenerProyectosManejador(
    IProyectoRepositorio repositorio)
    : IRequestHandler<ObtenerProyectosConsulta, IReadOnlyList<ProyectoDto>>
{
    public async Task<IReadOnlyList<ProyectoDto>> Handle(
        ObtenerProyectosConsulta consulta,
        CancellationToken token)
    {
        var proyectos = await repositorio.ObtenerTodosAsync(token);

        return proyectos
            .Select(p => new ProyectoDto(p.Id, p.Nombre))
            .ToList();
    }
}
