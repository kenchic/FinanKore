# Graph Report - E:\Documentos\Proyectos\FinanKore  (2026-05-11)

## Corpus Check
- Corpus is ~3,569 words - fits in a single context window. You may not need a graph.

## Summary
- 85 nodes · 65 edges · 13 communities detected
- Extraction: 74% EXTRACTED · 26% INFERRED · 0% AMBIGUOUS · INFERRED: 17 edges (avg confidence: 0.89)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- [[_COMMUNITY_Solution Architecture|Solution Architecture]]
- [[_COMMUNITY_Use Cases & Workflows|Use Cases & Workflows]]
- [[_COMMUNITY_Brand Identity & Favicon|Brand Identity & Favicon]]
- [[_COMMUNITY_Weather API Controller|Weather API Controller]]
- [[_COMMUNITY_Reconnect Modal Logic|Reconnect Modal Logic]]
- [[_COMMUNITY_App Root Component|App Root Component]]
- [[_COMMUNITY_Routes Component|Routes Component]]
- [[_COMMUNITY__Imports Component|_Imports Component]]
- [[_COMMUNITY_NavMenu Component|NavMenu Component]]
- [[_COMMUNITY_ReconnectModal Component|ReconnectModal Component]]
- [[_COMMUNITY_Embedded Attribute|Embedded Attribute]]
- [[_COMMUNITY_Validation Attributes|Validation Attributes]]
- [[_COMMUNITY_WeatherForecast Model|WeatherForecast Model]]

## God Nodes (most connected - your core abstractions)
1. `Arquitectura por Capas` - 6 edges
2. `Financore.Core` - 5 edges
3. `Financore.Api.Test` - 5 edges
4. `WeatherForecastController` - 4 edges
5. `FinanKore Solution` - 4 edges
6. `Financore.Client` - 4 edges
7. `Crear Proyecto` - 4 edges
8. `Financore.Api` - 3 edges
9. `Financore.Blazor` - 3 edges
10. `Registrar Cuenta` - 3 edges

## Surprising Connections (you probably didn't know these)
- `FinanKore Solution` --conceptually_related_to--> `Registrar Cuenta`  [INFERRED]
  README.md → docs/plan use-cases/plan.md

## Communities

### Community 0 - "Solution Architecture"
Cohesion: 0.44
Nodes (9): Documentacion de Arquitectura, CI/CD 80% Cobertura Minima, Financore.Api, Financore.Api.Test, Financore.Blazor, Financore.Client, Financore.Core, FinanKore Solution (+1 more)

### Community 1 - "Use Cases & Workflows"
Cohesion: 0.22
Nodes (9): Cargar Archivos Concepto Reporte, Crear Categorias Proyecto, Crear Concepto Proyecto, Crear Concepto Reporte, Crear Proyecto, Crear Reporte Proyecto, Orden de Desarrollo por Dependencias, Iniciar Sesion (Login) (+1 more)

### Community 2 - "Brand Identity & Favicon"
Cohesion: 0.25
Nodes (9): App.razor, Browser Tab Icon, Circular Badge/Coin Shape, #512BD4 (Deep Purple), #F6F6F6 (Off-White), $ Dollar Sign, favicon.png, FinanKore Financial Domain (+1 more)

### Community 3 - "Weather API Controller"
Cohesion: 0.33
Nodes (4): ControllerBase, FinanKore.WebApi.Controllers, WeatherForecastController, string

### Community 4 - "Reconnect Modal Logic"
Cohesion: 0.5
Nodes (2): retry(), retryWhenDocumentBecomesVisible()

### Community 5 - "App Root Component"
Cohesion: 0.5
Nodes (2): App, FinanKore.Web.Components

### Community 6 - "Routes Component"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components, Routes

### Community 7 - "_Imports Component"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components, _Imports

### Community 8 - "NavMenu Component"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Layout, NavMenu

### Community 9 - "ReconnectModal Component"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Layout, ReconnectModal

### Community 10 - "Embedded Attribute"
Cohesion: 0.67
Nodes (2): EmbeddedAttribute, Microsoft.CodeAnalysis

### Community 11 - "Validation Attributes"
Cohesion: 0.67
Nodes (2): Microsoft.Extensions.Validation.Embedded, ValidatableTypeAttribute

### Community 12 - "WeatherForecast Model"
Cohesion: 0.67
Nodes (2): FinanKore.WebApi, WeatherForecast

## Knowledge Gaps
- **18 isolated node(s):** `Microsoft.CodeAnalysis`, `EmbeddedAttribute`, `Microsoft.Extensions.Validation.Embedded`, `ValidatableTypeAttribute`, `FinanKore.Web.Components` (+13 more)
  These have ≤1 connection - possible missing edges or undocumented components.
- **Thin community `Reconnect Modal Logic`** (5 nodes): `ReconnectModal.razor.js`, `handleReconnectStateChanged()`, `resume()`, `retry()`, `retryWhenDocumentBecomesVisible()`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `App Root Component`** (4 nodes): `App`, `.BuildRenderTree()`, `FinanKore.Web.Components`, `App.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Routes Component`** (4 nodes): `FinanKore.Web.Components`, `Routes`, `.BuildRenderTree()`, `Routes.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `_Imports Component`** (4 nodes): `FinanKore.Web.Components`, `_Imports`, `.Execute()`, `_Imports.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `NavMenu Component`** (4 nodes): `NavMenu.razor.g.cs`, `FinanKore.Web.Components.Layout`, `NavMenu`, `.BuildRenderTree()`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `ReconnectModal Component`** (4 nodes): `ReconnectModal.razor.g.cs`, `FinanKore.Web.Components.Layout`, `ReconnectModal`, `.BuildRenderTree()`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Embedded Attribute`** (3 nodes): `EmbeddedAttribute.cs`, `EmbeddedAttribute`, `Microsoft.CodeAnalysis`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Validation Attributes`** (3 nodes): `ValidatableTypeAttribute.cs`, `Microsoft.Extensions.Validation.Embedded`, `ValidatableTypeAttribute`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `WeatherForecast Model`** (3 nodes): `WeatherForecast.cs`, `FinanKore.WebApi`, `WeatherForecast`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `FinanKore Solution` connect `Solution Architecture` to `Use Cases & Workflows`?**
  _High betweenness centrality (0.023) - this node is a cross-community bridge._
- **Why does `Registrar Cuenta` connect `Use Cases & Workflows` to `Solution Architecture`?**
  _High betweenness centrality (0.023) - this node is a cross-community bridge._
- **Are the 6 inferred relationships involving `Arquitectura por Capas` (e.g. with `FinanKore Solution` and `Financore.Core`) actually correct?**
  _`Arquitectura por Capas` has 6 INFERRED edges - model-reasoned connections that need verification._
- **Are the 2 inferred relationships involving `Financore.Api.Test` (e.g. with `Arquitectura por Capas` and `CI/CD 80% Cobertura Minima`) actually correct?**
  _`Financore.Api.Test` has 2 INFERRED edges - model-reasoned connections that need verification._
- **What connects `Microsoft.CodeAnalysis`, `EmbeddedAttribute`, `Microsoft.Extensions.Validation.Embedded` to the rest of the system?**
  _18 weakly-connected nodes found - possible documentation gaps or missing edges._