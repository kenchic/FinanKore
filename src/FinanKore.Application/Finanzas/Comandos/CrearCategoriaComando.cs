using FinanKore.Aplicacion.Finanzas.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Comandos;

public sealed record CrearCategoriaComando(string Nombre, string? Descripcion) : IRequest<CategoriaDto>;
