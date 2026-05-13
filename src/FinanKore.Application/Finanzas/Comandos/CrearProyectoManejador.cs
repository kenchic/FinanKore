using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Finanzas.Dtos;
using FinanKore.Dominio.Finanzas;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed class CrearProyectoManejador(
    IProyectoRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<CrearProyectoComando, ProyectoDto>
{
    public async Task<ProyectoDto> Handle(
        CrearProyectoComando comando,
        CancellationToken token)
    {
        var proyecto = Proyecto.Crear(comando.Nombre);

        await repositorio.AgregarAsync(proyecto, token);
        await unidadDeTrabajo.GuardarCambiosAsync(token);

        return new ProyectoDto(proyecto.Id, proyecto.Nombre);
    }
}
