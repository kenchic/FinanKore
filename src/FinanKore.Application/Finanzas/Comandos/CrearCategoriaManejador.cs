using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Finanzas.Dtos;
using FinanKore.Dominio.Finanzas;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed class CrearCategoriaManejador(
    ICategoriaRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<CrearCategoriaComando, CategoriaDto>
{
    public async Task<CategoriaDto> Handle(
        CrearCategoriaComando comando,
        CancellationToken token)
    {
        var categoria = Categoria.Crear(comando.Nombre, comando.Descripcion, comando.ProyectoId);

        await repositorio.AgregarAsync(categoria, token);
        await unidadDeTrabajo.GuardarCambiosAsync(token);

        return new CategoriaDto(categoria.Id, categoria.Nombre, categoria.Descripcion, categoria.ProyectoId, categoria.Activo, categoria.FechaCreacion);
    }
}
