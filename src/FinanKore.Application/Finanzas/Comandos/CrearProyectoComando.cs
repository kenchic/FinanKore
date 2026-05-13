using FinanKore.Aplicacion.Finanzas.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed record CrearProyectoComando(string Nombre) : IRequest<ProyectoDto>;
