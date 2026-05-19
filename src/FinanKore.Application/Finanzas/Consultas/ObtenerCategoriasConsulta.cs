using FinanKore.Aplicacion.Finanzas.Dtos;
using MediatR;

namespace FinanKore.Aplicacion.Finanzas.Consultas;

public sealed record ObtenerCategoriasConsulta(Guid ProyectoId) : IRequest<IReadOnlyList<CategoriaDto>>;
