using FinanKore.Aplicacion.Proyecto.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Comandos;

public sealed record CrearReporteComando(Guid ProyectoId, string Nombre, string Descripcion) : IRequest<ReporteDto>;
