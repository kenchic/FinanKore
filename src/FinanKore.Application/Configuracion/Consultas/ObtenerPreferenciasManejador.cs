using FinanKore.Aplicacion.Configuracion.Dtos;
using FinanKore.Dominio.Configuracion;
using MediatR;

namespace FinanKore.Aplicacion.Configuracion.Consultas;

public sealed class ObtenerPreferenciasManejador(
    IPreferenciasRepositorio repositorio)
    : IRequestHandler<ObtenerPreferenciasConsulta, PreferenciasDto?>
{
    public async Task<PreferenciasDto?> Handle(
        ObtenerPreferenciasConsulta consulta,
        CancellationToken token)
    {
        var preferencias = await repositorio.ObtenerPorUsuarioAsync(consulta.UsuarioId, token);

        if (preferencias is null)
            return null;

        return new PreferenciasDto(
            preferencias.Id,
            preferencias.UsuarioId,
            preferencias.Tema.ToString()
        );
    }
}
