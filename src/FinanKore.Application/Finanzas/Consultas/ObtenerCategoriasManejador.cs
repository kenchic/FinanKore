using FinanKore.Aplicacion.Finanzas.Dtos;
using FinanKore.Dominio.Finanzas;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Consultas;

public sealed class ObtenerCategoriasManejador(
    ICategoriaRepositorio repositorio)
    : IRequestHandler<ObtenerCategoriasConsulta, IReadOnlyList<CategoriaDto>>
{
    public async Task<IReadOnlyList<CategoriaDto>> Handle(
        ObtenerCategoriasConsulta consulta,
        CancellationToken token)
    {
        var categorias = await repositorio.ObtenerActivasAsync(token);

        return categorias
            .Select(c => new CategoriaDto(c.Id, c.Nombre, c.Descripcion, c.Activo, c.FechaCreacion))
            .ToList();
    }
}
