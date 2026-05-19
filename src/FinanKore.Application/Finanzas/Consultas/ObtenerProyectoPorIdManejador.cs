using FinanKore.Aplicacion.Finanzas.Dtos;
using FinanKore.Dominio.Finanzas;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Consultas;

public sealed class ObtenerProyectoPorIdManejador(
    IProyectoRepositorio repositorio)
    : IRequestHandler<ObtenerProyectoPorIdConsulta, ProyectoDto?>
{
    public async Task<ProyectoDto?> Handle(
        ObtenerProyectoPorIdConsulta consulta,
        CancellationToken token)
    {
        var proyecto = await repositorio.ObtenerPorIdAsync(consulta.Id, token);

        if (proyecto is null)
            return null;

        return new ProyectoDto(proyecto.Id, proyecto.Nombre);
    }
}
