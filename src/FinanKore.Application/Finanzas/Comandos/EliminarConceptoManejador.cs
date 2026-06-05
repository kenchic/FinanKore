using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Dominio.Finanzas;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed class EliminarConceptoManejador(
    IProyectoRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<EliminarConceptoComando>
{
    public async Task Handle(
        EliminarConceptoComando comando,
        CancellationToken token)
    {
        var proyecto = await repositorio.ObtenerPorIdConConceptosAsync(comando.ProyectoId, token)
            ?? throw new InvalidOperationException("El proyecto no existe.");

        proyecto.EliminarConcepto(comando.ConceptoId);

        await unidadDeTrabajo.GuardarCambiosAsync(token);
    }
}
