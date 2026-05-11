# Arquitectura Financore

## Proyectos

- Financore.Core
  - DTOs compartidos: 
    - `ProyectoDto`
    - `ConceptoDto`
    - `ReporteDto`
    - `ReporteConceptoDto`
    - `ListaImagenesDto`
  - Utilidades: `Result<T>`
  - Extensiones DI y logging
  - Validaciones genéricas

- Financore.Api
  - `FinancoreDbContext` (SQL)
  - Controladores RESTful: 
    - `ProyectoController`
    - `ConceptoController`
    - `ReporteController`
    - `ReporteConceptoController`
    - `ListaImagenesController`
  - Autenticación JWT opcional
  - Migraciones y DI

- Financore.Client
  - Cliente HTTP tipado: 
    - `ProyectoClient`
    - `ConceptoClient`
    - `ReporteClient`
    - `ReporteConceptoClient`
    - `ListaImagenesClient`
  - Polly para reintentos
  - Extensión `AddFinancoreApiClient`

- Financore.Blazor
  - Componentes: 
    - `ProyectoList`, `ProyectoForm`
    - `ConceptoList`, `ConceptoForm`
    - `ReporteList`, `ReporteForm`
  - Registro de HttpClient
  - Libreria de componente MudBlazor

- Financore.Api.Test
  - Pruebas unitarias e integración
  - Cobertura configurada (mínimo 80% en CI)

## Dependencias

- Financore → Blazor
- Api → Core
- Client → Core
- Blazor → Client, Core
- Api.Test → Api, Core, Client

## Notas de seguridad

- Sin secretos en código
- JWT configurables vía `appsettings.json`

