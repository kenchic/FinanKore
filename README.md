# Financore

Solución .NET con arquitectura por capas:

- Financore.Core: DTOs, utilidades y extensiones transversales.
- Financore.Api: API RESTful con EF Core (SQLite) y DI.
- Financore.Client: servicios HTTP tipados con HttpClient y Polly.
- Financore.Blazor: UI con componentes reutilizables.
- Financore.Api.Test: pruebas unitarias e integración.

## Relación entre proyectos

- `Financore.Api` referencia `Financore.Core`.
- `Financore.Client` referencia `Financore.Core`.
- `Financore.Blazor` referencia `Financore.Client` y `Financore.Core`.
- `Financore.Api.Test` referencia `Financore.Api`, `Financore.Core` y `Financore.Client`.

## Ejecutar local

- Restaurar: `dotnet restore`
- Aplicar migraciones: `dotnet ef database update -p Financore.Api -s Financore.Api`
- Ejecutar API: `dotnet run --project Financore.Api`
- Ejecutar Blazor: `dotnet run --project Financore.Blazor`

## Cobertura y CI/CD

- Pruebas locales: `dotnet test -p:CollectCoverage=true -p:CoverletOutputFormat=cobertura`
- CI exige 80% de cobertura mínima y empaqueta `Core` y `Client` con versionado semántico basado en tags.

## Documentación de arquitectura

Consulta `docs/ARCHITECTURE.md` para un diagrama textual de relaciones y responsabilidades.

