namespace FinanKore.Aplicacion.Configuracion.Dtos;

public sealed record PreferenciasDto(
    Guid Id,
    Guid UsuarioId,
    string Tema
);
