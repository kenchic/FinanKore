using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Configuracion.Dtos;
using FinanKore.Dominio.Configuracion;
using FinanKore.Dominio.Configuracion.ObjetosValor;
using FinanKore.Dominio.Excepciones;
using MediatR;

namespace FinanKore.Aplicacion.Configuracion.Comandos;

public sealed class CambiarTemaManejador(
    IPreferenciasRepositorio repositorio,
    IUnidadDeTrabajo unidadDeTrabajo)
    : IRequestHandler<CambiarTemaComando, PreferenciasDto>
{
    public async Task<PreferenciasDto> Handle(
        CambiarTemaComando comando,
        CancellationToken token)
    {
        if (!Enum.TryParse<ModoTema>(comando.Tema, ignoreCase: true, out var nuevoTema))
            throw new ExcepcionDominio($"El tema '{comando.Tema}' no es válido. Use 'Claro' u 'Oscuro'.");

        var preferencias = await repositorio.ObtenerPorUsuarioAsync(comando.UsuarioId, token);

        if (preferencias is null)
        {
            preferencias = Preferencias.Crear(comando.UsuarioId, nuevoTema);
            await repositorio.AgregarAsync(preferencias, token);
        }
        else
        {
            preferencias.CambiarTema(nuevoTema);
            repositorio.Actualizar(preferencias);
        }

        await unidadDeTrabajo.GuardarCambiosAsync(token);

        return new PreferenciasDto(
            preferencias.Id,
            preferencias.UsuarioId,
            preferencias.Tema.ToString()
        );
    }
}
