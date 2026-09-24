using MediatR;

namespace FinanKore.Aplicacion.Comun.Mensajeria;

public sealed record EnvoltorioEventoDominio<TEvento>(TEvento Evento) : INotification
    where TEvento : FinanKore.Dominio.Eventos.IDominioEvento;
