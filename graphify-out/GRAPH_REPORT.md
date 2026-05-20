# Graph Report - E:\Documentos\Proyectos\FinanKore  (2026-05-19)

## Corpus Check
- Corpus is ~18,116 words - fits in a single context window. You may not need a graph.

## Summary
- 677 nodes · 702 edges · 77 communities detected
- Extraction: 88% EXTRACTED · 12% INFERRED · 0% AMBIGUOUS · INFERRED: 81 edges (avg confidence: 0.84)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Application|Finankore.Application]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Application|Finankore.Application]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Docs Plan Use-Cases|Docs Plan Use-Cases]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Application|Finankore.Application]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Community 16|Community 16]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Docs Plan Use-Cases|Docs Plan Use-Cases]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Community 26|Community 26]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Community 44|Community 44]]
- [[_COMMUNITY_Finankore.Application|Finankore.Application]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Webapi|Finankore.Webapi]]
- [[_COMMUNITY_Finankore.Webapi|Finankore.Webapi]]
- [[_COMMUNITY_Finankore.Webapi|Finankore.Webapi]]
- [[_COMMUNITY_Finankore.Webapi|Finankore.Webapi]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Webapi|Finankore.Webapi]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Infrastructure|Finankore.Infrastructure]]
- [[_COMMUNITY_Finankore.Web|Finankore.Web]]
- [[_COMMUNITY_Finankore.Webapi|Finankore.Webapi]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]
- [[_COMMUNITY_Finankore.Domain|Finankore.Domain]]

## God Nodes (most connected - your core abstractions)
1. `Usuario` - 25 edges
2. `Categorias` - 15 edges
3. `IniciarSesionManejador` - 12 edges
4. `RegistrarUsuarioManejador` - 12 edges
5. `AppDbContext` - 12 edges
6. `ServicioFinanzas` - 12 edges
7. `Usuario` - 11 edges
8. `Home` - 11 edges
9. `Caso de Uso Iniciar Sesion` - 11 edges
10. `Caso de Uso: Registrar Cuenta` - 11 edges

## Surprising Connections (you probably didn't know these)
- `Iniciar Sesion` --conceptually_related_to--> `Usuario`  [INFERRED]
  docs/plan use-cases/plan.md → src/FinanKore.Domain/Perfil/Usuario.cs
- `Registrar Cuenta` --conceptually_related_to--> `Usuario`  [INFERRED]
  docs/plan use-cases/plan.md → src/FinanKore.Domain/Perfil/Usuario.cs
- `IUnidadDeTrabajo` --references--> `Caso de Uso: Crear Proyecto`  [EXTRACTED]
  src/FinanKore.Application/Comun/Interfaces/IUnidadDeTrabajo.cs → docs/use-cases/crear_proyecto.md
- `CorreoElectronico` --references--> `Caso de Uso: Registrar Cuenta`  [EXTRACTED]
  src/FinanKore.Domain/Perfil/ObjetosValor/CorreoElectronico.cs → docs/use-cases/registrar_cuenta.md
- `ImagenPerfil` --references--> `Caso de Uso: Registrar Cuenta`  [EXTRACTED]
  src/FinanKore.Domain/Perfil/ObjetosValor/ImagenPerfil.cs → docs/use-cases/registrar_cuenta.md

## Communities

### Community 0 - "Finankore.Domain"
Cohesion: 0.07
Nodes (54): Script SQL 0001 Usuarios, Perfil Schema, Perfil.Usuarios, Tabla Perfil.Usuarios, Script SQL 0002 Usuarios Sesion, Perfil.Usuarios (SQL), IniciarSesionManejador, RegistrarUsuarioManejador (+46 more)

### Community 1 - "Finankore.Domain"
Cohesion: 0.06
Nodes (9): Entidad, Entidad, Categoria, Concepto, Proyecto, IRaizAgregado, List, Usuario (+1 more)

### Community 2 - "Finankore.Web"
Cohesion: 0.06
Nodes (14): bool, IniciarSesionModelo, FinanKore.Web.Components.Layout, NavMenu, FinanKore.Web.Components.Pages, Home, __PrivateComponentRenderModeAttribute, FinanKore.Web.Components.Pages (+6 more)

### Community 3 - "Finankore.Application"
Cohesion: 0.07
Nodes (27): Script SQL 0003 Proyectos, Finanzas.Proyectos, Script SQL 0004 Categorias, Finanzas.Categorias, Script SQL 0005 Reportes, Proyecto.Reportes, Script SQL 0006 Conceptos, Finanzas.Conceptos (+19 more)

### Community 4 - "Finankore.Domain"
Cohesion: 0.1
Nodes (32): Finanzas.Categorias (SQL), Finanzas.Conceptos (SQL), Categoria, CategoriaCreada, CategoriaDto, Concepto, ConceptoCreado, ConceptoDto (+24 more)

### Community 5 - "Finankore.Application"
Cohesion: 0.06
Nodes (11): CrearCategoriaManejador, CrearConceptoManejador, CrearProyectoManejador, CrearReporteManejador, ObtenerCategoriasManejador, ObtenerConceptosPorProyectoManejador, ObtenerProyectoPorIdManejador, ObtenerProyectosManejador (+3 more)

### Community 6 - "Finankore.Web"
Cohesion: 0.08
Nodes (11): ControllerBase, PerfilController, FinanKore.WebApi.Controllers, WeatherForecastController, CrearCategoriaModelo, Guid, IMediator, Categorias (+3 more)

### Community 7 - "Finankore.Infrastructure"
Cohesion: 0.12
Nodes (25): AppDbContext, AppDbContextModelSnapshot, CategoriaConfiguracion, CategoriaCreada, CategoriaRepositorio, ConceptoConfiguracion, ConceptoCreado, CrearCategoriaModelo (+17 more)

### Community 8 - "Docs Plan Use-Cases"
Cohesion: 0.16
Nodes (18): Cargar Archivos Concepto Reporte, Crear Categorias Proyecto, Crear Concepto Proyecto, Crear Concepto Reporte, Crear Proyecto, Crear Reporte Proyecto, Orden de Desarrollo por Dependencias, Iniciar Sesion (Login) (+10 more)

### Community 9 - "Finankore.Web"
Cohesion: 0.12
Nodes (3): HttpClient, ServicioFinanzas, ServicioPerfil

### Community 10 - "Finankore.Application"
Cohesion: 0.16
Nodes (10): CrearReporteComando, CrearReporteManejador, IReporteRepositorio, ObtenerReportesPorProyectoConsulta, ObtenerReportesPorProyectoManejador, ObtenerTodosLosReportesConsulta, ObtenerTodosLosReportesManejador, ReporteDto (+2 more)

### Community 11 - "Finankore.Infrastructure"
Cohesion: 0.12
Nodes (6): CategoriaConfiguracion, ConceptoConfiguracion, ProyectoConfiguracion, ReporteConfiguracion, UsuarioConfiguracion, IEntityTypeConfiguration

### Community 12 - "Finankore.Domain"
Cohesion: 0.13
Nodes (5): ICategoriaRepositorio, IProyectoRepositorio, IRepositorio, IUsuarioRepositorio, IReporteRepositorio

### Community 13 - "Finankore.Web"
Cohesion: 0.13
Nodes (15): CrearCategoriaModelo, CrearConceptoModelo, CrearProyectoModelo, CrearReporteModelo, EstadoAutenticacion, IniciarSesionModelo, RegistrarCuentaModelo, CategoriaCreadaDto (+7 more)

### Community 14 - "Finankore.Infrastructure"
Cohesion: 0.2
Nodes (2): AppDbContext, UsuarioRepositorio

### Community 15 - "Finankore.Infrastructure"
Cohesion: 0.2
Nodes (2): ICategoriaRepositorio, CategoriaRepositorio

### Community 16 - "Community 16"
Cohesion: 0.25
Nodes (9): App.razor, Browser Tab Icon, Circular Badge/Coin Shape, #512BD4 (Deep Purple), #F6F6F6 (Off-White), $ Dollar Sign, favicon.png, FinanKore Financial Domain (+1 more)

### Community 17 - "Finankore.Infrastructure"
Cohesion: 0.25
Nodes (9): Usuarios, Valor, Actualizar, AgregarAsync, Eliminar, ExisteCorreoAsync, ObtenerPorCorreoAsync, ObtenerPorIdAsync (+1 more)

### Community 18 - "Finankore.Domain"
Cohesion: 0.36
Nodes (1): Credencial

### Community 19 - "Finankore.Web"
Cohesion: 0.25
Nodes (4): FinanKore.Web.Components.Pages, __PrivateComponentRenderModeAttribute, RegistrarCuenta, RegistrarCuentaModelo

### Community 20 - "Finankore.Web"
Cohesion: 0.25
Nodes (4): CrearProyectoModelo, CrearProyecto, FinanKore.Web.Components.Pages, __PrivateComponentRenderModeAttribute

### Community 21 - "Finankore.Domain"
Cohesion: 0.29
Nodes (1): IRepositorio

### Community 22 - "Finankore.Web"
Cohesion: 0.33
Nodes (7): IniciarSesionModelo, IniciarSesion, Registrar, RegistrarCuentaModelo, IniciarSesionAsync, RegistrarAsync, UsuarioRegistradoDto

### Community 23 - "Finankore.Infrastructure"
Cohesion: 0.33
Nodes (3): Migration, AgregarCredencialUsuario, FinanKore.Infrastructure.Migrations

### Community 24 - "Docs Plan Use-Cases"
Cohesion: 0.33
Nodes (6): Cargar Archivos Concepto Reporte, Crear Categorias Proyecto, Crear Concepto Proyecto, Crear Concepto Reporte, Crear Proyecto, Crear Reporte Proyecto

### Community 25 - "Finankore.Web"
Cohesion: 0.33
Nodes (3): FinanKore.Web.Components.Pages, __PrivateComponentRenderModeAttribute, Reportes

### Community 26 - "Community 26"
Cohesion: 0.5
Nodes (2): retry(), retryWhenDocumentBecomesVisible()

### Community 27 - "Finankore.Web"
Cohesion: 0.5
Nodes (2): App, FinanKore.Web.Components

### Community 28 - "Finankore.Web"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components, Routes

### Community 29 - "Finankore.Web"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components, _Imports

### Community 30 - "Finankore.Web"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Layout, ReconnectModal

### Community 31 - "Finankore.Domain"
Cohesion: 0.6
Nodes (1): ObjetoValor

### Community 32 - "Finankore.Domain"
Cohesion: 0.4
Nodes (1): ImagenPerfil

### Community 33 - "Finankore.Domain"
Cohesion: 0.4
Nodes (1): NombrePersona

### Community 34 - "Finankore.Infrastructure"
Cohesion: 0.4
Nodes (3): AppDbContextModelSnapshot, FinanKore.Infrastructure.Migrations, ModelSnapshot

### Community 35 - "Finankore.Infrastructure"
Cohesion: 0.4
Nodes (2): DbContext, AppDbContext

### Community 36 - "Finankore.Web"
Cohesion: 0.4
Nodes (3): FinanKore.Web.Components.Layout, MainLayout, LayoutComponentBase

### Community 37 - "Finankore.Web"
Cohesion: 0.4
Nodes (2): Error, FinanKore.Web.Components.Pages

### Community 38 - "Finankore.Web"
Cohesion: 0.67
Nodes (2): EmbeddedAttribute, Microsoft.CodeAnalysis

### Community 39 - "Finankore.Web"
Cohesion: 0.67
Nodes (2): Microsoft.Extensions.Validation.Embedded, ValidatableTypeAttribute

### Community 40 - "Finankore.Domain"
Cohesion: 0.5
Nodes (1): CorreoElectronico

### Community 41 - "Finankore.Infrastructure"
Cohesion: 0.5
Nodes (2): AgregarCredencialUsuario, FinanKore.Infrastructure.Migrations

### Community 42 - "Finankore.Web"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Pages, NotFound

### Community 43 - "Finankore.Domain"
Cohesion: 0.5
Nodes (4): Crear, GenerarSalt, Hashear, Verificar

### Community 44 - "Community 44"
Cohesion: 0.67
Nodes (2): FinanKore.WebApi, WeatherForecast

### Community 45 - "Finankore.Application"
Cohesion: 0.67
Nodes (1): IUnidadDeTrabajo

### Community 46 - "Finankore.Domain"
Cohesion: 0.67
Nodes (2): ExcepcionDominio, Exception

### Community 47 - "Finankore.Infrastructure"
Cohesion: 0.67
Nodes (1): InyeccionDependencia

### Community 48 - "Finankore.Webapi"
Cohesion: 0.67
Nodes (1): PerfilEndpoints

### Community 49 - "Finankore.Webapi"
Cohesion: 0.67
Nodes (1): FinanzasEndpoints

### Community 50 - "Finankore.Webapi"
Cohesion: 0.67
Nodes (1): ProyectoEndpoints

### Community 51 - "Finankore.Webapi"
Cohesion: 0.67
Nodes (1): ReportesEndpoints

### Community 52 - "Finankore.Domain"
Cohesion: 1.0
Nodes (1): IRaizAgregado

### Community 53 - "Finankore.Domain"
Cohesion: 1.0
Nodes (1): IDominioEvento

### Community 54 - "Finankore.Web"
Cohesion: 1.0
Nodes (1): IniciarSesionModelo

### Community 55 - "Finankore.Web"
Cohesion: 1.0
Nodes (1): RegistrarCuentaModelo

### Community 56 - "Finankore.Web"
Cohesion: 1.0
Nodes (1): CrearCategoriaModelo

### Community 57 - "Finankore.Web"
Cohesion: 1.0
Nodes (1): CrearConceptoModelo

### Community 58 - "Finankore.Web"
Cohesion: 1.0
Nodes (1): CrearProyectoModelo

### Community 59 - "Finankore.Web"
Cohesion: 1.0
Nodes (1): CrearReporteModelo

### Community 60 - "Finankore.Web"
Cohesion: 1.0
Nodes (1): EstadoAutenticacion

### Community 61 - "Finankore.Webapi"
Cohesion: 1.0
Nodes (2): ObtenerTodosLosReportesConsulta, ReportesEndpoints

### Community 92 - "Finankore.Domain"
Cohesion: 1.0
Nodes (1): ObjetoValor

### Community 93 - "Finankore.Domain"
Cohesion: 1.0
Nodes (1): DesdePersistencia

### Community 94 - "Finankore.Infrastructure"
Cohesion: 1.0
Nodes (1): AgregarCredencialUsuario

### Community 95 - "Finankore.Infrastructure"
Cohesion: 1.0
Nodes (1): Up

### Community 96 - "Finankore.Infrastructure"
Cohesion: 1.0
Nodes (1): Down

### Community 97 - "Finankore.Infrastructure"
Cohesion: 1.0
Nodes (1): AgregarCredencialUsuario

### Community 98 - "Finankore.Infrastructure"
Cohesion: 1.0
Nodes (1): BuildTargetModel

### Community 99 - "Finankore.Infrastructure"
Cohesion: 1.0
Nodes (1): BuildModel

### Community 100 - "Finankore.Infrastructure"
Cohesion: 1.0
Nodes (1): OnModelCreating

### Community 101 - "Finankore.Infrastructure"
Cohesion: 1.0
Nodes (1): GuardarCambiosAsync

### Community 102 - "Finankore.Web"
Cohesion: 1.0
Nodes (1): ServicioPerfil

### Community 103 - "Finankore.Webapi"
Cohesion: 1.0
Nodes (1): PerfilController

### Community 133 - "Finankore.Domain"
Cohesion: 1.0
Nodes (1): IRepositorio

### Community 134 - "Finankore.Domain"
Cohesion: 1.0
Nodes (1): ObjetoValor

### Community 135 - "Finankore.Domain"
Cohesion: 1.0
Nodes (1): IDominioEvento

## Knowledge Gaps
- **111 isolated node(s):** `FinanKore.WebApi`, `WeatherForecast`, `FinanKore.WebApi.Controllers`, `Documentacion de Arquitectura`, `Crear Categorias Proyecto` (+106 more)
  These have ≤1 connection - possible missing edges or undocumented components.
- **Thin community `Finankore.Infrastructure`** (10 nodes): `AppDbContext`, `UsuarioRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ExisteCorreoAsync()`, `.ObtenerPorCorreoAsync()`, `.ObtenerPorIdAsync()`, `.ObtenerTodosAsync()`, `UsuarioRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (10 nodes): `ICategoriaRepositorio`, `CategoriaRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ObtenerActivasAsync()`, `.ObtenerPorIdAsync()`, `.ObtenerPorProyectoAsync()`, `.ObtenerTodosAsync()`, `CategoriaRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (8 nodes): `Credencial`, `.Crear()`, `.DesdePersistencia()`, `.GenerarSalt()`, `.Hashear()`, `.ObtenerComponentesIgualdad()`, `.Verificar()`, `Credencial.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (7 nodes): `IRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ObtenerPorIdAsync()`, `.ObtenerTodosAsync()`, `IRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 26`** (5 nodes): `ReconnectModal.razor.js`, `handleReconnectStateChanged()`, `resume()`, `retry()`, `retryWhenDocumentBecomesVisible()`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (5 nodes): `App`, `.BuildRenderTree()`, `FinanKore.Web.Components`, `App.razor.g.cs`, `App.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (5 nodes): `FinanKore.Web.Components`, `Routes`, `.BuildRenderTree()`, `Routes.razor.g.cs`, `Routes.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (5 nodes): `FinanKore.Web.Components`, `_Imports`, `.Execute()`, `_Imports.razor.g.cs`, `_Imports.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (5 nodes): `ReconnectModal.razor.g.cs`, `FinanKore.Web.Components.Layout`, `ReconnectModal`, `.BuildRenderTree()`, `ReconnectModal.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (5 nodes): `ObjetoValor`, `.Equals()`, `.GetHashCode()`, `.ObtenerComponentesIgualdad()`, `ObjetoValor.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (5 nodes): `ImagenPerfil`, `.Crear()`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `ImagenPerfil.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (5 nodes): `NombrePersona`, `.Crear()`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `NombrePersona.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (5 nodes): `DbContext`, `AppDbContext`, `.GuardarCambiosAsync()`, `.OnModelCreating()`, `AppDbContext.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (5 nodes): `Error`, `.BuildRenderTree()`, `.OnInitialized()`, `FinanKore.Web.Components.Pages`, `Error.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (4 nodes): `EmbeddedAttribute.cs`, `EmbeddedAttribute`, `Microsoft.CodeAnalysis`, `EmbeddedAttribute.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (4 nodes): `ValidatableTypeAttribute.cs`, `Microsoft.Extensions.Validation.Embedded`, `ValidatableTypeAttribute`, `ValidatableTypeAttribute.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (4 nodes): `CorreoElectronico`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `CorreoElectronico.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (4 nodes): `AgregarCredencialUsuario`, `.BuildTargetModel()`, `FinanKore.Infrastructure.Migrations`, `20260512161738_AgregarCredencialUsuario.Designer.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (4 nodes): `FinanKore.Web.Components.Pages`, `NotFound`, `.BuildRenderTree()`, `NotFound.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 44`** (3 nodes): `WeatherForecast.cs`, `FinanKore.WebApi`, `WeatherForecast`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Application`** (3 nodes): `IUnidadDeTrabajo`, `.GuardarCambiosAsync()`, `IUnidadDeTrabajo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (3 nodes): `ExcepcionDominio`, `Exception`, `ExcepcionDominio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (3 nodes): `InyeccionDependencia`, `.AgregarInfraestructura()`, `InyeccionDependencia.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Webapi`** (3 nodes): `PerfilEndpoints`, `.MapPerfilEndpoints()`, `PerfilEndpoints.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Webapi`** (3 nodes): `FinanzasEndpoints`, `.MapFinanzasEndpoints()`, `FinanzasEndpoints.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Webapi`** (3 nodes): `ProyectoEndpoints`, `.MapProyectoEndpoints()`, `ProyectoEndpoints.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Webapi`** (3 nodes): `ReportesEndpoints`, `.MapReportesEndpoints()`, `ReportesEndpoints.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (2 nodes): `IRaizAgregado`, `IRaizAgregado.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (2 nodes): `IDominioEvento`, `IDominioEvento.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (2 nodes): `IniciarSesionModelo`, `IniciarSesionModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (2 nodes): `RegistrarCuentaModelo`, `RegistrarCuentaModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (2 nodes): `CrearCategoriaModelo`, `CrearCategoriaModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (2 nodes): `CrearConceptoModelo`, `CrearConceptoModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (2 nodes): `CrearProyectoModelo`, `CrearProyectoModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (2 nodes): `CrearReporteModelo`, `CrearReporteModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (2 nodes): `EstadoAutenticacion`, `EstadoAutenticacion.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Webapi`** (2 nodes): `ObtenerTodosLosReportesConsulta`, `ReportesEndpoints`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (1 nodes): `ObjetoValor`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (1 nodes): `DesdePersistencia`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (1 nodes): `AgregarCredencialUsuario`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (1 nodes): `Up`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (1 nodes): `Down`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (1 nodes): `AgregarCredencialUsuario`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (1 nodes): `BuildTargetModel`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (1 nodes): `BuildModel`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (1 nodes): `OnModelCreating`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Infrastructure`** (1 nodes): `GuardarCambiosAsync`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Web`** (1 nodes): `ServicioPerfil`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Webapi`** (1 nodes): `PerfilController`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (1 nodes): `IRepositorio`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (1 nodes): `ObjetoValor`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finankore.Domain`** (1 nodes): `IDominioEvento`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `Usuario` connect `Finankore.Domain` to `Finankore.Domain`?**
  _High betweenness centrality (0.033) - this node is a cross-community bridge._
- **Are the 6 inferred relationships involving `Usuario` (e.g. with `Tabla Perfil.Usuarios` and `Registrar Cuenta`) actually correct?**
  _`Usuario` has 6 INFERRED edges - model-reasoned connections that need verification._
- **Are the 2 inferred relationships involving `IniciarSesionManejador` (e.g. with `RegistrarUsuarioManejador` and `PerfilEndpoints`) actually correct?**
  _`IniciarSesionManejador` has 2 INFERRED edges - model-reasoned connections that need verification._
- **Are the 2 inferred relationships involving `RegistrarUsuarioManejador` (e.g. with `IniciarSesionManejador` and `PerfilEndpoints`) actually correct?**
  _`RegistrarUsuarioManejador` has 2 INFERRED edges - model-reasoned connections that need verification._
- **What connects `FinanKore.WebApi`, `WeatherForecast`, `FinanKore.WebApi.Controllers` to the rest of the system?**
  _111 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `Finankore.Domain` be split into smaller, more focused modules?**
  _Cohesion score 0.07 - nodes in this community are weakly interconnected._
- **Should `Finankore.Domain` be split into smaller, more focused modules?**
  _Cohesion score 0.06 - nodes in this community are weakly interconnected._