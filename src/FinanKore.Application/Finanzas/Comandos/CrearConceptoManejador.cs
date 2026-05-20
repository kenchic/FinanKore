using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Finanzas.Dtos;
using FinanKore.Dominio.Finanzas;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed class CrearConceptoManejador(
    IProyectoRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<CrearConceptoComando, ConceptoDto>
{
    public async Task<ConceptoDto> Handle(
        CrearConceptoComando comando,
        CancellationToken token)
    {
        var proyecto = await repositorio.ObtenerPorIdConConceptosAsync(comando.ProyectoId, token)
            ?? throw new global::FinanKore.Dominio.Excepciones.ExcepcionDominio("El proyecto no existe.");

        var concepto = proyecto.CrearConcepto(comando.Nombre, comando.Valor, comando.Tipo);

        await unidadDeTrabajo.GuardarCambiosAsync(token);

        return new ConceptoDto(
            concepto.Id,
            concepto.Nombre,
            concepto.Valor,
            concepto.Tipo,
            concepto.ProyectoId,
            concepto.FechaCreacion);
    }
}
