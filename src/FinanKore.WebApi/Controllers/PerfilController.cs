using FinanKore.Aplicacion.Perfil.Comandos;
using FinanKore.Aplicacion.Perfil.Dtos;
using FinanKore.Dominio.Excepciones;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FinanKore.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PerfilController : ControllerBase
{
    private readonly IMediator _mediador;

    public PerfilController(IMediator mediador)
    {
        _mediador = mediador;
    }

    [HttpPost("registrar")]
    public async Task<ActionResult<UsuarioDto>> Registrar(
        [FromBody] RegistrarUsuarioComando comando,
        CancellationToken token)
    {
        try
        {
            var resultado = await _mediador.Send(comando, token);
            return CreatedAtAction(nameof(Registrar), new { id = resultado.Id }, resultado);
        }
        catch (ExcepcionDominio ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }
}
