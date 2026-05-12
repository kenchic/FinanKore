# Graph Report - .  (2026-05-12)

## Corpus Check
- Corpus is ~7,927 words - fits in a single context window. You may not need a graph.

## Summary
- 338 nodes · 290 edges · 59 communities detected
- Extraction: 88% EXTRACTED · 12% INFERRED · 0% AMBIGUOUS · INFERRED: 36 edges (avg confidence: 0.84)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- [[_COMMUNITY_Manejadores de Comandos|Manejadores de Comandos]]
- [[_COMMUNITY_Plan Casos de Uso|Plan Casos de Uso]]
- [[_COMMUNITY_Entidades y Eventos de Dominio|Entidades y Eventos de Dominio]]
- [[_COMMUNITY_DbContext y Objetos de Valor|DbContext y Objetos de Valor]]
- [[_COMMUNITY_Agregado Usuario|Agregado Usuario]]
- [[_COMMUNITY_Controladores API|Controladores API]]
- [[_COMMUNITY_Assets Web|Assets Web]]
- [[_COMMUNITY_Repositorio Usuarios|Repositorio Usuarios]]
- [[_COMMUNITY_Credencial y Seguridad|Credencial y Seguridad]]
- [[_COMMUNITY_Pagina Iniciar Sesion|Pagina Iniciar Sesion]]
- [[_COMMUNITY_Pagina Registrar Cuenta|Pagina Registrar Cuenta]]
- [[_COMMUNITY_Entidad Base|Entidad Base]]
- [[_COMMUNITY_Repositorio Base|Repositorio Base]]
- [[_COMMUNITY_Pagina Home|Pagina Home]]
- [[_COMMUNITY_Modelos y Servicios Web|Modelos y Servicios Web]]
- [[_COMMUNITY_Migraciones EF Core|Migraciones EF Core]]
- [[_COMMUNITY_Plan Funcional|Plan Funcional]]
- [[_COMMUNITY_Modal Reconexion|Modal Reconexion]]
- [[_COMMUNITY_Componentes Razor Generados|Componentes Razor Generados]]
- [[_COMMUNITY_Componentes Razor Generados|Componentes Razor Generados]]
- [[_COMMUNITY_Componentes Razor Generados|Componentes Razor Generados]]
- [[_COMMUNITY_Componentes Razor Generados|Componentes Razor Generados]]
- [[_COMMUNITY_Componentes Razor Generados|Componentes Razor Generados]]
- [[_COMMUNITY_Community 23|Community 23]]
- [[_COMMUNITY_Community 24|Community 24]]
- [[_COMMUNITY_Community 25|Community 25]]
- [[_COMMUNITY_Community 26|Community 26]]
- [[_COMMUNITY_Migraciones|Migraciones]]
- [[_COMMUNITY_Componentes Razor Generados|Componentes Razor Generados]]
- [[_COMMUNITY_Componentes Razor Generados|Componentes Razor Generados]]
- [[_COMMUNITY_Flujo Iniciar Sesion|Flujo Iniciar Sesion]]
- [[_COMMUNITY_Community 31|Community 31]]
- [[_COMMUNITY_Migraciones|Migraciones]]
- [[_COMMUNITY_Community 33|Community 33]]
- [[_COMMUNITY_Componentes Razor Generados|Componentes Razor Generados]]
- [[_COMMUNITY_Community 35|Community 35]]
- [[_COMMUNITY_Community 36|Community 36]]
- [[_COMMUNITY_Community 37|Community 37]]
- [[_COMMUNITY_Weather Forecast|Weather Forecast]]
- [[_COMMUNITY_Community 39|Community 39]]
- [[_COMMUNITY_Community 40|Community 40]]
- [[_COMMUNITY_Community 41|Community 41]]
- [[_COMMUNITY_Community 42|Community 42]]
- [[_COMMUNITY_Community 43|Community 43]]
- [[_COMMUNITY_Flujo Iniciar Sesion|Flujo Iniciar Sesion]]
- [[_COMMUNITY_Flujo Registrar Usuario|Flujo Registrar Usuario]]
- [[_COMMUNITY_Community 76|Community 76]]
- [[_COMMUNITY_Community 77|Community 77]]
- [[_COMMUNITY_Community 78|Community 78]]
- [[_COMMUNITY_Community 79|Community 79]]
- [[_COMMUNITY_Community 80|Community 80]]
- [[_COMMUNITY_Community 81|Community 81]]
- [[_COMMUNITY_Community 82|Community 82]]
- [[_COMMUNITY_Community 83|Community 83]]
- [[_COMMUNITY_Community 84|Community 84]]
- [[_COMMUNITY_Community 85|Community 85]]
- [[_COMMUNITY_Community 86|Community 86]]
- [[_COMMUNITY_Community 87|Community 87]]
- [[_COMMUNITY_Community 88|Community 88]]

## God Nodes (most connected - your core abstractions)
1. `Usuario` - 11 edges
2. `Usuario` - 11 edges
3. `UsuarioRepositorio` - 10 edges
4. `Configure` - 8 edges
5. `Credencial` - 7 edges
6. `IniciarSesionManejador` - 7 edges
7. `RegistrarUsuarioManejador` - 7 edges
8. `Usuarios` - 7 edges
9. `Arquitectura por Capas` - 6 edges
10. `Entidad` - 6 edges

## Surprising Connections (you probably didn't know these)
- `Iniciar Sesion` --conceptually_related_to--> `Usuario`  [INFERRED]
  docs/plan use-cases/plan.md → src/FinanKore.Domain/Perfil/Usuario.cs
- `Registrar Cuenta` --conceptually_related_to--> `Usuario`  [INFERRED]
  docs/plan use-cases/plan.md → src/FinanKore.Domain/Perfil/Usuario.cs
- `FinanKore Solution` --conceptually_related_to--> `Registrar Cuenta`  [INFERRED]
  README.md → docs/plan use-cases/plan.md
- `Tabla Perfil.Usuarios` --shares_data_with--> `Usuario`  [INFERRED]
  docs/sql/0001_Usuarios.sql → src/FinanKore.Domain/Perfil/Usuario.cs
- `Tabla Perfil.Usuarios` --shares_data_with--> `UsuarioDto`  [INFERRED]
  docs/sql/0001_Usuarios.sql → src/FinanKore.Application/Perfil/Dtos/UsuarioDto.cs

## Hyperedges (group relationships)
- **DDD Base Abstractions** — entidad_entidad, iraizagregado_iraizagregado, irepositorio_irepositorio, idominioevento_idominioevento, objetovalor_objetovalor, excepciondominio_excepciondominio [INFERRED 0.85]
- **Registrar Cuenta Flow** — registrarusuariocomando_registrarusuariocomando, registrarusuariomanejador_registrarusuariomanejador, usuario_usuario, usuariodto_usuariodto, iusuariorepositorio_iusuariorepositorio [INFERRED 0.85]
- **Iniciar Sesion Flow** — iniciarsesioncomando_iniciarsesioncomando, iniciarsesionmanejador_iniciarsesionmanejador, usuario_usuario, usuariodto_usuariodto, iusuariorepositorio_iusuariorepositorio [INFERRED 0.85]
- **Perfil Domain Value Objects** — correoelectronico_correoelectronico, credencial_credencial, imagenperfil_imagenperfil, nombrepersona_nombrepersona [INFERRED 0.85]
- **Authentication and Registration Flow** — iniciarsesionmodelo_iniciarsesionmodelo, registrarcuentamodelo_registrarcuentamodelo, servicioperfil_registrarasync, servicioperfil_iniciarsesionasync, perfilcontroller_registrar, perfilcontroller_iniciarsesion, servicioperfil_usuarioregistradodto [INFERRED 0.75]
- **Credencial Database Schema Definition** — agregarcredencialusuario_agregarcredencialusuario, usuarioconfiguracion_usuarioconfiguracion, appdbcontextmodelsnapshot_appdbcontextmodelsnapshot, agregarcredencialusuario_designer_agregarcredencialusuario [INFERRED 0.95]

## Communities

### Community 0 - "Manejadores de Comandos"
Cohesion: 0.09
Nodes (9): AppDbContext, IniciarSesionManejador, RegistrarUsuarioManejador, DbContext, IRequestHandler, IUnidadDeTrabajo, IUsuarioRepositorio, AppDbContext (+1 more)

### Community 1 - "Plan Casos de Uso"
Cohesion: 0.16
Nodes (18): Cargar Archivos Concepto Reporte, Crear Categorias Proyecto, Crear Concepto Proyecto, Crear Concepto Reporte, Crear Proyecto, Crear Reporte Proyecto, Orden de Desarrollo por Dependencias, Iniciar Sesion (Login) (+10 more)

### Community 2 - "Entidades y Eventos de Dominio"
Cohesion: 0.21
Nodes (18): Perfil Schema, Tabla Perfil.Usuarios, Entidad, ExcepcionDominio, IDominioEvento, IniciarSesionComando, IniciarSesionManejador, IRaizAgregado (+10 more)

### Community 3 - "DbContext y Objetos de Valor"
Cohesion: 0.15
Nodes (14): AppDbContext, AppDbContextModelSnapshot, CorreoElectronico, Credencial, ImagenPerfil, Url, AgregarInfraestructura, Apellidos (+6 more)

### Community 4 - "Agregado Usuario"
Cohesion: 0.17
Nodes (3): Entidad, IRaizAgregado, Usuario

### Community 5 - "Controladores API"
Cohesion: 0.18
Nodes (6): ControllerBase, PerfilController, FinanKore.WebApi.Controllers, WeatherForecastController, IMediator, string

### Community 6 - "Assets Web"
Cohesion: 0.25
Nodes (9): App.razor, Browser Tab Icon, Circular Badge/Coin Shape, #512BD4 (Deep Purple), #F6F6F6 (Off-White), $ Dollar Sign, favicon.png, FinanKore Financial Domain (+1 more)

### Community 7 - "Repositorio Usuarios"
Cohesion: 0.25
Nodes (9): Usuarios, Valor, Actualizar, AgregarAsync, Eliminar, ExisteCorreoAsync, ObtenerPorCorreoAsync, ObtenerPorIdAsync (+1 more)

### Community 8 - "Credencial y Seguridad"
Cohesion: 0.36
Nodes (1): Credencial

### Community 9 - "Pagina Iniciar Sesion"
Cohesion: 0.25
Nodes (4): IniciarSesionModelo, FinanKore.Web.Components.Pages, IniciarSesion, __PrivateComponentRenderModeAttribute

### Community 10 - "Pagina Registrar Cuenta"
Cohesion: 0.25
Nodes (4): FinanKore.Web.Components.Pages, __PrivateComponentRenderModeAttribute, RegistrarCuenta, RegistrarCuentaModelo

### Community 11 - "Entidad Base"
Cohesion: 0.29
Nodes (2): Entidad, List

### Community 12 - "Repositorio Base"
Cohesion: 0.29
Nodes (1): IRepositorio

### Community 13 - "Pagina Home"
Cohesion: 0.29
Nodes (3): FinanKore.Web.Components.Pages, Home, __PrivateComponentRenderModeAttribute

### Community 14 - "Modelos y Servicios Web"
Cohesion: 0.33
Nodes (7): IniciarSesionModelo, IniciarSesion, Registrar, RegistrarCuentaModelo, IniciarSesionAsync, RegistrarAsync, UsuarioRegistradoDto

### Community 15 - "Migraciones EF Core"
Cohesion: 0.33
Nodes (3): Migration, AgregarCredencialUsuario, FinanKore.Infrastructure.Migrations

### Community 16 - "Plan Funcional"
Cohesion: 0.33
Nodes (6): Cargar Archivos Concepto Reporte, Crear Categorias Proyecto, Crear Concepto Proyecto, Crear Concepto Reporte, Crear Proyecto, Crear Reporte Proyecto

### Community 17 - "Modal Reconexion"
Cohesion: 0.5
Nodes (2): retry(), retryWhenDocumentBecomesVisible()

### Community 18 - "Componentes Razor Generados"
Cohesion: 0.5
Nodes (2): App, FinanKore.Web.Components

### Community 19 - "Componentes Razor Generados"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components, Routes

### Community 20 - "Componentes Razor Generados"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components, _Imports

### Community 21 - "Componentes Razor Generados"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Layout, NavMenu

### Community 22 - "Componentes Razor Generados"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Layout, ReconnectModal

### Community 23 - "Community 23"
Cohesion: 0.6
Nodes (1): ObjetoValor

### Community 24 - "Community 24"
Cohesion: 0.4
Nodes (2): IRepositorio, IUsuarioRepositorio

### Community 25 - "Community 25"
Cohesion: 0.4
Nodes (1): ImagenPerfil

### Community 26 - "Community 26"
Cohesion: 0.4
Nodes (1): NombrePersona

### Community 27 - "Migraciones"
Cohesion: 0.4
Nodes (3): AppDbContextModelSnapshot, FinanKore.Infrastructure.Migrations, ModelSnapshot

### Community 28 - "Componentes Razor Generados"
Cohesion: 0.4
Nodes (3): FinanKore.Web.Components.Layout, MainLayout, LayoutComponentBase

### Community 29 - "Componentes Razor Generados"
Cohesion: 0.4
Nodes (2): Error, FinanKore.Web.Components.Pages

### Community 30 - "Flujo Iniciar Sesion"
Cohesion: 0.4
Nodes (2): HttpClient, ServicioPerfil

### Community 31 - "Community 31"
Cohesion: 0.5
Nodes (1): CorreoElectronico

### Community 32 - "Migraciones"
Cohesion: 0.5
Nodes (2): AgregarCredencialUsuario, FinanKore.Infrastructure.Migrations

### Community 33 - "Community 33"
Cohesion: 0.5
Nodes (2): UsuarioConfiguracion, IEntityTypeConfiguration

### Community 34 - "Componentes Razor Generados"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Pages, NotFound

### Community 35 - "Community 35"
Cohesion: 0.5
Nodes (4): Crear, GenerarSalt, Hashear, Verificar

### Community 36 - "Community 36"
Cohesion: 0.67
Nodes (2): EmbeddedAttribute, Microsoft.CodeAnalysis

### Community 37 - "Community 37"
Cohesion: 0.67
Nodes (2): Microsoft.Extensions.Validation.Embedded, ValidatableTypeAttribute

### Community 38 - "Weather Forecast"
Cohesion: 0.67
Nodes (2): FinanKore.WebApi, WeatherForecast

### Community 39 - "Community 39"
Cohesion: 0.67
Nodes (1): IUnidadDeTrabajo

### Community 40 - "Community 40"
Cohesion: 0.67
Nodes (2): ExcepcionDominio, Exception

### Community 41 - "Community 41"
Cohesion: 0.67
Nodes (1): InyeccionDependencia

### Community 42 - "Community 42"
Cohesion: 1.0
Nodes (1): IRaizAgregado

### Community 43 - "Community 43"
Cohesion: 1.0
Nodes (1): IDominioEvento

### Community 44 - "Flujo Iniciar Sesion"
Cohesion: 1.0
Nodes (1): IniciarSesionModelo

### Community 45 - "Flujo Registrar Usuario"
Cohesion: 1.0
Nodes (1): RegistrarCuentaModelo

### Community 76 - "Community 76"
Cohesion: 1.0
Nodes (1): ObjetoValor

### Community 77 - "Community 77"
Cohesion: 1.0
Nodes (1): DesdePersistencia

### Community 78 - "Community 78"
Cohesion: 1.0
Nodes (1): InyeccionDependencia

### Community 79 - "Community 79"
Cohesion: 1.0
Nodes (1): AgregarCredencialUsuario

### Community 80 - "Community 80"
Cohesion: 1.0
Nodes (1): Up

### Community 81 - "Community 81"
Cohesion: 1.0
Nodes (1): Down

### Community 82 - "Community 82"
Cohesion: 1.0
Nodes (1): AgregarCredencialUsuario

### Community 83 - "Community 83"
Cohesion: 1.0
Nodes (1): BuildTargetModel

### Community 84 - "Community 84"
Cohesion: 1.0
Nodes (1): BuildModel

### Community 85 - "Community 85"
Cohesion: 1.0
Nodes (1): OnModelCreating

### Community 86 - "Community 86"
Cohesion: 1.0
Nodes (1): GuardarCambiosAsync

### Community 87 - "Community 87"
Cohesion: 1.0
Nodes (1): ServicioPerfil

### Community 88 - "Community 88"
Cohesion: 1.0
Nodes (1): PerfilController

## Knowledge Gaps
- **68 isolated node(s):** `Microsoft.CodeAnalysis`, `EmbeddedAttribute`, `Microsoft.Extensions.Validation.Embedded`, `ValidatableTypeAttribute`, `FinanKore.WebApi` (+63 more)
  These have ≤1 connection - possible missing edges or undocumented components.
- **Thin community `Credencial y Seguridad`** (8 nodes): `Credencial`, `.Crear()`, `.DesdePersistencia()`, `.GenerarSalt()`, `.Hashear()`, `.ObtenerComponentesIgualdad()`, `.Verificar()`, `Credencial.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Entidad Base`** (7 nodes): `Entidad`, `.AgregarEvento()`, `.Equals()`, `.GetHashCode()`, `.LimpiarEventos()`, `List`, `Entidad.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Repositorio Base`** (7 nodes): `IRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ObtenerPorIdAsync()`, `.ObtenerTodosAsync()`, `IRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Modal Reconexion`** (5 nodes): `ReconnectModal.razor.js`, `handleReconnectStateChanged()`, `resume()`, `retry()`, `retryWhenDocumentBecomesVisible()`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Componentes Razor Generados`** (5 nodes): `App`, `.BuildRenderTree()`, `FinanKore.Web.Components`, `App.razor.g.cs`, `App.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Componentes Razor Generados`** (5 nodes): `FinanKore.Web.Components`, `Routes`, `.BuildRenderTree()`, `Routes.razor.g.cs`, `Routes.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Componentes Razor Generados`** (5 nodes): `FinanKore.Web.Components`, `_Imports`, `.Execute()`, `_Imports.razor.g.cs`, `_Imports.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Componentes Razor Generados`** (5 nodes): `NavMenu.razor.g.cs`, `FinanKore.Web.Components.Layout`, `NavMenu`, `.BuildRenderTree()`, `NavMenu.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Componentes Razor Generados`** (5 nodes): `ReconnectModal.razor.g.cs`, `FinanKore.Web.Components.Layout`, `ReconnectModal`, `.BuildRenderTree()`, `ReconnectModal.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 23`** (5 nodes): `ObjetoValor`, `.Equals()`, `.GetHashCode()`, `.ObtenerComponentesIgualdad()`, `ObjetoValor.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 24`** (5 nodes): `IRepositorio`, `IUsuarioRepositorio`, `.ExisteCorreoAsync()`, `.ObtenerPorCorreoAsync()`, `IUsuarioRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 25`** (5 nodes): `ImagenPerfil`, `.Crear()`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `ImagenPerfil.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 26`** (5 nodes): `NombrePersona`, `.Crear()`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `NombrePersona.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Componentes Razor Generados`** (5 nodes): `Error`, `.BuildRenderTree()`, `.OnInitialized()`, `FinanKore.Web.Components.Pages`, `Error.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Flujo Iniciar Sesion`** (5 nodes): `HttpClient`, `ServicioPerfil`, `.IniciarSesionAsync()`, `.RegistrarAsync()`, `ServicioPerfil.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 31`** (4 nodes): `CorreoElectronico`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `CorreoElectronico.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Migraciones`** (4 nodes): `AgregarCredencialUsuario`, `.BuildTargetModel()`, `FinanKore.Infrastructure.Migrations`, `20260512161738_AgregarCredencialUsuario.Designer.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 33`** (4 nodes): `UsuarioConfiguracion`, `.Configure()`, `IEntityTypeConfiguration`, `UsuarioConfiguracion.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Componentes Razor Generados`** (4 nodes): `FinanKore.Web.Components.Pages`, `NotFound`, `.BuildRenderTree()`, `NotFound.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 36`** (3 nodes): `EmbeddedAttribute.cs`, `EmbeddedAttribute`, `Microsoft.CodeAnalysis`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 37`** (3 nodes): `ValidatableTypeAttribute.cs`, `Microsoft.Extensions.Validation.Embedded`, `ValidatableTypeAttribute`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Weather Forecast`** (3 nodes): `WeatherForecast.cs`, `FinanKore.WebApi`, `WeatherForecast`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 39`** (3 nodes): `IUnidadDeTrabajo`, `.GuardarCambiosAsync()`, `IUnidadDeTrabajo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 40`** (3 nodes): `ExcepcionDominio`, `Exception`, `ExcepcionDominio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 41`** (3 nodes): `InyeccionDependencia`, `.AgregarInfraestructura()`, `InyeccionDependencia.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 42`** (2 nodes): `IRaizAgregado`, `IRaizAgregado.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 43`** (2 nodes): `IDominioEvento`, `IDominioEvento.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Flujo Iniciar Sesion`** (2 nodes): `IniciarSesionModelo`, `IniciarSesionModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Flujo Registrar Usuario`** (2 nodes): `RegistrarCuentaModelo`, `RegistrarCuentaModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 76`** (1 nodes): `ObjetoValor`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 77`** (1 nodes): `DesdePersistencia`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 78`** (1 nodes): `InyeccionDependencia`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 79`** (1 nodes): `AgregarCredencialUsuario`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 80`** (1 nodes): `Up`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 81`** (1 nodes): `Down`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 82`** (1 nodes): `AgregarCredencialUsuario`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 83`** (1 nodes): `BuildTargetModel`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 84`** (1 nodes): `BuildModel`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 85`** (1 nodes): `OnModelCreating`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 86`** (1 nodes): `GuardarCambiosAsync`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 87`** (1 nodes): `ServicioPerfil`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 88`** (1 nodes): `PerfilController`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `Registrar Cuenta` connect `Entidades y Eventos de Dominio` to `Plan Funcional`?**
  _High betweenness centrality (0.002) - this node is a cross-community bridge._
- **Are the 4 inferred relationships involving `Usuario` (e.g. with `Tabla Perfil.Usuarios` and `Registrar Cuenta`) actually correct?**
  _`Usuario` has 4 INFERRED edges - model-reasoned connections that need verification._
- **What connects `Microsoft.CodeAnalysis`, `EmbeddedAttribute`, `Microsoft.Extensions.Validation.Embedded` to the rest of the system?**
  _68 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `Manejadores de Comandos` be split into smaller, more focused modules?**
  _Cohesion score 0.09 - nodes in this community are weakly interconnected._