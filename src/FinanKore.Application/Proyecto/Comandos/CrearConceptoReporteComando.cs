using FinanKore.Aplicacion.Proyecto.Dtos;
using FinanKore.Dominio.Finanzas.ObjetosValor;
using MediatR;

namespace FinanKore.Aplicacion.Proyecto.Comandos;

public sealed record CrearConceptoReporteComando(
    Guid ReporteId,
    Guid CategoriaId,
    string Nombre,
    decimal Valor,
    TipoMovimiento Tipo) : IRequest<ConceptoReporteDto>;
