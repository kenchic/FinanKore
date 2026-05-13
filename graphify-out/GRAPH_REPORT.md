# Graph Report - .  (2026-05-12)

## Corpus Check
- Corpus is ~10,156 words - fits in a single context window. You may not need a graph.

## Summary
- 352 nodes · 321 edges · 60 communities detected
- Extraction: 86% EXTRACTED · 14% INFERRED · 0% AMBIGUOUS · INFERRED: 44 edges (avg confidence: 0.85)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- [[_COMMUNITY_Sesion Usuarios|Sesion Usuarios]]
- [[_COMMUNITY_Usuariorepositorio Appdbcontext|Usuariorepositorio Appdbcontext]]
- [[_COMMUNITY_Plan Usecases|Plan Usecases]]
- [[_COMMUNITY_Usuario Entidad|Usuario Entidad]]
- [[_COMMUNITY_Perfilcontroller Weatherforecastcontroller|Perfilcontroller Weatherforecastcontroller]]
- [[_COMMUNITY_Nombrepersona Imagenperfil|Nombrepersona Imagenperfil]]
- [[_COMMUNITY_Favicon App|Favicon App]]
- [[_COMMUNITY_Usuariorepositorio Appdbcontext|Usuariorepositorio Appdbcontext]]
- [[_COMMUNITY_Credencial Crear|Credencial Crear]]
- [[_COMMUNITY_Iniciarsesion Iniciarsesionmodelo|Iniciarsesion Iniciarsesionmodelo]]
- [[_COMMUNITY_Registrarcuenta Privatecomponentrendermodeattribute|Registrarcuenta Privatecomponentrendermodeattribute]]
- [[_COMMUNITY_Entidad Agregarevento|Entidad Agregarevento]]
- [[_COMMUNITY_Irepositorio Actualizar|Irepositorio Actualizar]]
- [[_COMMUNITY_Home Buildrendertree|Home Buildrendertree]]
- [[_COMMUNITY_Servicioperfil Iniciarsesionmodelo|Servicioperfil Iniciarsesionmodelo]]
- [[_COMMUNITY_Agregarcredencialusuario Migrations|Agregarcredencialusuario Migrations]]
- [[_COMMUNITY_Plan Crear|Plan Crear]]
- [[_COMMUNITY_Layout Reconnectmodal|Layout Reconnectmodal]]
- [[_COMMUNITY_App Net10|App Net10]]
- [[_COMMUNITY_Routes Net10|Routes Net10]]
- [[_COMMUNITY_Imports Net10|Imports Net10]]
- [[_COMMUNITY_Navmenu Layout|Navmenu Layout]]
- [[_COMMUNITY_Reconnectmodal Layout|Reconnectmodal Layout]]
- [[_COMMUNITY_Objetovalor Equals|Objetovalor Equals]]
- [[_COMMUNITY_Iusuariorepositorio Irepositorio|Iusuariorepositorio Irepositorio]]
- [[_COMMUNITY_Imagenperfil Crear|Imagenperfil Crear]]
- [[_COMMUNITY_Nombrepersona Crear|Nombrepersona Crear]]
- [[_COMMUNITY_Appdbcontextmodelsnapshot Migrations|Appdbcontextmodelsnapshot Migrations]]
- [[_COMMUNITY_Mainlayout Layout|Mainlayout Layout]]
- [[_COMMUNITY_Error Buildrendertree|Error Buildrendertree]]
- [[_COMMUNITY_Servicioperfil Servicios|Servicioperfil Servicios]]
- [[_COMMUNITY_Correoelectronico Obtenercomponentesigualdad|Correoelectronico Obtenercomponentesigualdad]]
- [[_COMMUNITY_Agregarcredencialusuario Migrations|Agregarcredencialusuario Migrations]]
- [[_COMMUNITY_Usuarioconfiguracion Configuraciones|Usuarioconfiguracion Configuraciones]]
- [[_COMMUNITY_Notfound Buildrendertree|Notfound Buildrendertree]]
- [[_COMMUNITY_Credencial Crear|Credencial Crear]]
- [[_COMMUNITY_Embeddedattribute Net10|Embeddedattribute Net10]]
- [[_COMMUNITY_Validatabletypeattribute Net10|Validatabletypeattribute Net10]]
- [[_COMMUNITY_Weatherforecast|Weatherforecast]]
- [[_COMMUNITY_Iunidaddetrabajo Interfaces|Iunidaddetrabajo Interfaces]]
- [[_COMMUNITY_Excepciondominio Excepciones|Excepciondominio Excepciones]]
- [[_COMMUNITY_Inyecciondependencia Agregarinfraestructura|Inyecciondependencia Agregarinfraestructura]]
- [[_COMMUNITY_Perfilendpoints Endpoints|Perfilendpoints Endpoints]]
- [[_COMMUNITY_Iraizagregado|Iraizagregado]]
- [[_COMMUNITY_Idominioevento Eventos|Idominioevento Eventos]]
- [[_COMMUNITY_Iniciarsesionmodelo Models|Iniciarsesionmodelo Models]]
- [[_COMMUNITY_Registrarcuentamodelo Models|Registrarcuentamodelo Models]]
- [[_COMMUNITY_Objetovalor|Objetovalor]]
- [[_COMMUNITY_Credencial Desdepersistencia|Credencial Desdepersistencia]]
- [[_COMMUNITY_Inyecciondependencia|Inyecciondependencia]]
- [[_COMMUNITY_Agregarcredencialusuario 20260512161738|Agregarcredencialusuario 20260512161738]]
- [[_COMMUNITY_20260512161738 Agregarcredencialusuario|20260512161738 Agregarcredencialusuario]]
- [[_COMMUNITY_20260512161738 Agregarcredencialusuario|20260512161738 Agregarcredencialusuario]]
- [[_COMMUNITY_Agregarcredencialusuario 20260512161738|Agregarcredencialusuario 20260512161738]]
- [[_COMMUNITY_20260512161738 Agregarcredencialusuario|20260512161738 Agregarcredencialusuario]]
- [[_COMMUNITY_Appdbcontextmodelsnapshot Buildmodel|Appdbcontextmodelsnapshot Buildmodel]]
- [[_COMMUNITY_Appdbcontext Onmodelcreating|Appdbcontext Onmodelcreating]]
- [[_COMMUNITY_Appdbcontext Guardarcambiosasync|Appdbcontext Guardarcambiosasync]]
- [[_COMMUNITY_Servicioperfil|Servicioperfil]]
- [[_COMMUNITY_Perfilcontroller|Perfilcontroller]]

## God Nodes (most connected - your core abstractions)
1. `Usuario` - 16 edges
2. `Usuario` - 11 edges
3. `Caso de Uso Iniciar Sesion` - 11 edges
4. `UsuarioRepositorio` - 10 edges
5. `IniciarSesionManejador` - 10 edges
6. `RegistrarUsuarioManejador` - 10 edges
7. `Configure` - 8 edges
8. `Caso de Uso Registrar Cuenta` - 8 edges
9. `Credencial` - 7 edges
10. `Usuarios` - 7 edges

## Surprising Connections (you probably didn't know these)
- `Iniciar Sesion` --conceptually_related_to--> `Usuario`  [INFERRED]
  docs/plan use-cases/plan.md → src/FinanKore.Domain/Perfil/Usuario.cs
- `Registrar Cuenta` --conceptually_related_to--> `Usuario`  [INFERRED]
  docs/plan use-cases/plan.md → src/FinanKore.Domain/Perfil/Usuario.cs
- `IniciarSesionManejador` --references--> `Caso de Uso Iniciar Sesion`  [EXTRACTED]
  src/FinanKore.Application/Perfil/Comandos/IniciarSesionManejador.cs → docs/use-cases/iniciar_sesion.md
- `RegistrarUsuarioManejador` --references--> `Caso de Uso Registrar Cuenta`  [EXTRACTED]
  src/FinanKore.Application/Perfil/Comandos/RegistrarUsuarioManejador.cs → docs/use-cases/registrar_cuenta.md
- `Usuario` --references--> `Caso de Uso Iniciar Sesion`  [EXTRACTED]
  src/FinanKore.Domain/Perfil/Usuario.cs → docs/use-cases/iniciar_sesion.md

## Hyperedges (group relationships)
- **Flujo de Autenticacion** — perfilendpoints_perfilendpoints, iniciarsesionmanejador_iniciarsesionmanejador, usuario_usuario, usuariorepositorio_usuariorepositorio, sesioniniciada_sesioniniciada [INFERRED 0.85]
- **Flujo de Registro de Cuenta** — perfilendpoints_perfilendpoints, registrarusuariomanejador_registrarusuariomanejador, usuario_usuario, usuariorepositorio_usuariorepositorio [INFERRED 0.85]

## Communities

### Community 0 - "Sesion Usuarios"
Cohesion: 0.14
Nodes (31): Perfil Schema, Tabla Perfil.Usuarios, Perfil.Usuarios (SQL), AppDbContext, Entidad, ExcepcionDominio, IDominioEvento, Caso de Uso Iniciar Sesion (+23 more)

### Community 1 - "Usuariorepositorio Appdbcontext"
Cohesion: 0.09
Nodes (9): AppDbContext, IniciarSesionManejador, RegistrarUsuarioManejador, DbContext, IRequestHandler, IUnidadDeTrabajo, IUsuarioRepositorio, AppDbContext (+1 more)

### Community 2 - "Plan Usecases"
Cohesion: 0.16
Nodes (18): Cargar Archivos Concepto Reporte, Crear Categorias Proyecto, Crear Concepto Proyecto, Crear Concepto Reporte, Crear Proyecto, Crear Reporte Proyecto, Orden de Desarrollo por Dependencias, Iniciar Sesion (Login) (+10 more)

### Community 3 - "Usuario Entidad"
Cohesion: 0.17
Nodes (3): Entidad, IRaizAgregado, Usuario

### Community 4 - "Perfilcontroller Weatherforecastcontroller"
Cohesion: 0.18
Nodes (6): ControllerBase, PerfilController, FinanKore.WebApi.Controllers, WeatherForecastController, IMediator, string

### Community 5 - "Nombrepersona Imagenperfil"
Cohesion: 0.18
Nodes (11): AppDbContextModelSnapshot, CorreoElectronico, Credencial, ImagenPerfil, Url, Apellidos, Completo, NombrePersona (+3 more)

### Community 6 - "Favicon App"
Cohesion: 0.25
Nodes (9): App.razor, Browser Tab Icon, Circular Badge/Coin Shape, #512BD4 (Deep Purple), #F6F6F6 (Off-White), $ Dollar Sign, favicon.png, FinanKore Financial Domain (+1 more)

### Community 7 - "Usuariorepositorio Appdbcontext"
Cohesion: 0.25
Nodes (9): Usuarios, Valor, Actualizar, AgregarAsync, Eliminar, ExisteCorreoAsync, ObtenerPorCorreoAsync, ObtenerPorIdAsync (+1 more)

### Community 8 - "Credencial Crear"
Cohesion: 0.36
Nodes (1): Credencial

### Community 9 - "Iniciarsesion Iniciarsesionmodelo"
Cohesion: 0.25
Nodes (4): IniciarSesionModelo, FinanKore.Web.Components.Pages, IniciarSesion, __PrivateComponentRenderModeAttribute

### Community 10 - "Registrarcuenta Privatecomponentrendermodeattribute"
Cohesion: 0.25
Nodes (4): FinanKore.Web.Components.Pages, __PrivateComponentRenderModeAttribute, RegistrarCuenta, RegistrarCuentaModelo

### Community 11 - "Entidad Agregarevento"
Cohesion: 0.29
Nodes (2): Entidad, List

### Community 12 - "Irepositorio Actualizar"
Cohesion: 0.29
Nodes (1): IRepositorio

### Community 13 - "Home Buildrendertree"
Cohesion: 0.29
Nodes (3): FinanKore.Web.Components.Pages, Home, __PrivateComponentRenderModeAttribute

### Community 14 - "Servicioperfil Iniciarsesionmodelo"
Cohesion: 0.33
Nodes (7): IniciarSesionModelo, IniciarSesion, Registrar, RegistrarCuentaModelo, IniciarSesionAsync, RegistrarAsync, UsuarioRegistradoDto

### Community 15 - "Agregarcredencialusuario Migrations"
Cohesion: 0.33
Nodes (3): Migration, AgregarCredencialUsuario, FinanKore.Infrastructure.Migrations

### Community 16 - "Plan Crear"
Cohesion: 0.33
Nodes (6): Cargar Archivos Concepto Reporte, Crear Categorias Proyecto, Crear Concepto Proyecto, Crear Concepto Reporte, Crear Proyecto, Crear Reporte Proyecto

### Community 17 - "Layout Reconnectmodal"
Cohesion: 0.5
Nodes (2): retry(), retryWhenDocumentBecomesVisible()

### Community 18 - "App Net10"
Cohesion: 0.5
Nodes (2): App, FinanKore.Web.Components

### Community 19 - "Routes Net10"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components, Routes

### Community 20 - "Imports Net10"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components, _Imports

### Community 21 - "Navmenu Layout"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Layout, NavMenu

### Community 22 - "Reconnectmodal Layout"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Layout, ReconnectModal

### Community 23 - "Objetovalor Equals"
Cohesion: 0.6
Nodes (1): ObjetoValor

### Community 24 - "Iusuariorepositorio Irepositorio"
Cohesion: 0.4
Nodes (2): IRepositorio, IUsuarioRepositorio

### Community 25 - "Imagenperfil Crear"
Cohesion: 0.4
Nodes (1): ImagenPerfil

### Community 26 - "Nombrepersona Crear"
Cohesion: 0.4
Nodes (1): NombrePersona

### Community 27 - "Appdbcontextmodelsnapshot Migrations"
Cohesion: 0.4
Nodes (3): AppDbContextModelSnapshot, FinanKore.Infrastructure.Migrations, ModelSnapshot

### Community 28 - "Mainlayout Layout"
Cohesion: 0.4
Nodes (3): FinanKore.Web.Components.Layout, MainLayout, LayoutComponentBase

### Community 29 - "Error Buildrendertree"
Cohesion: 0.4
Nodes (2): Error, FinanKore.Web.Components.Pages

### Community 30 - "Servicioperfil Servicios"
Cohesion: 0.4
Nodes (2): HttpClient, ServicioPerfil

### Community 31 - "Correoelectronico Obtenercomponentesigualdad"
Cohesion: 0.5
Nodes (1): CorreoElectronico

### Community 32 - "Agregarcredencialusuario Migrations"
Cohesion: 0.5
Nodes (2): AgregarCredencialUsuario, FinanKore.Infrastructure.Migrations

### Community 33 - "Usuarioconfiguracion Configuraciones"
Cohesion: 0.5
Nodes (2): UsuarioConfiguracion, IEntityTypeConfiguration

### Community 34 - "Notfound Buildrendertree"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Pages, NotFound

### Community 35 - "Credencial Crear"
Cohesion: 0.5
Nodes (4): Crear, GenerarSalt, Hashear, Verificar

### Community 36 - "Embeddedattribute Net10"
Cohesion: 0.67
Nodes (2): EmbeddedAttribute, Microsoft.CodeAnalysis

### Community 37 - "Validatabletypeattribute Net10"
Cohesion: 0.67
Nodes (2): Microsoft.Extensions.Validation.Embedded, ValidatableTypeAttribute

### Community 38 - "Weatherforecast"
Cohesion: 0.67
Nodes (2): FinanKore.WebApi, WeatherForecast

### Community 39 - "Iunidaddetrabajo Interfaces"
Cohesion: 0.67
Nodes (1): IUnidadDeTrabajo

### Community 40 - "Excepciondominio Excepciones"
Cohesion: 0.67
Nodes (2): ExcepcionDominio, Exception

### Community 41 - "Inyecciondependencia Agregarinfraestructura"
Cohesion: 0.67
Nodes (1): InyeccionDependencia

### Community 42 - "Perfilendpoints Endpoints"
Cohesion: 0.67
Nodes (1): PerfilEndpoints

### Community 43 - "Iraizagregado"
Cohesion: 1.0
Nodes (1): IRaizAgregado

### Community 44 - "Idominioevento Eventos"
Cohesion: 1.0
Nodes (1): IDominioEvento

### Community 45 - "Iniciarsesionmodelo Models"
Cohesion: 1.0
Nodes (1): IniciarSesionModelo

### Community 46 - "Registrarcuentamodelo Models"
Cohesion: 1.0
Nodes (1): RegistrarCuentaModelo

### Community 77 - "Objetovalor"
Cohesion: 1.0
Nodes (1): ObjetoValor

### Community 78 - "Credencial Desdepersistencia"
Cohesion: 1.0
Nodes (1): DesdePersistencia

### Community 79 - "Inyecciondependencia"
Cohesion: 1.0
Nodes (1): InyeccionDependencia

### Community 80 - "Agregarcredencialusuario 20260512161738"
Cohesion: 1.0
Nodes (1): AgregarCredencialUsuario

### Community 81 - "20260512161738 Agregarcredencialusuario"
Cohesion: 1.0
Nodes (1): Up

### Community 82 - "20260512161738 Agregarcredencialusuario"
Cohesion: 1.0
Nodes (1): Down

### Community 83 - "Agregarcredencialusuario 20260512161738"
Cohesion: 1.0
Nodes (1): AgregarCredencialUsuario

### Community 84 - "20260512161738 Agregarcredencialusuario"
Cohesion: 1.0
Nodes (1): BuildTargetModel

### Community 85 - "Appdbcontextmodelsnapshot Buildmodel"
Cohesion: 1.0
Nodes (1): BuildModel

### Community 86 - "Appdbcontext Onmodelcreating"
Cohesion: 1.0
Nodes (1): OnModelCreating

### Community 87 - "Appdbcontext Guardarcambiosasync"
Cohesion: 1.0
Nodes (1): GuardarCambiosAsync

### Community 88 - "Servicioperfil"
Cohesion: 1.0
Nodes (1): ServicioPerfil

### Community 89 - "Perfilcontroller"
Cohesion: 1.0
Nodes (1): PerfilController

## Knowledge Gaps
- **70 isolated node(s):** `Microsoft.CodeAnalysis`, `EmbeddedAttribute`, `Microsoft.Extensions.Validation.Embedded`, `ValidatableTypeAttribute`, `FinanKore.WebApi` (+65 more)
  These have ≤1 connection - possible missing edges or undocumented components.
- **Thin community `Credencial Crear`** (8 nodes): `Credencial`, `.Crear()`, `.DesdePersistencia()`, `.GenerarSalt()`, `.Hashear()`, `.ObtenerComponentesIgualdad()`, `.Verificar()`, `Credencial.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Entidad Agregarevento`** (7 nodes): `Entidad`, `.AgregarEvento()`, `.Equals()`, `.GetHashCode()`, `.LimpiarEventos()`, `List`, `Entidad.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Irepositorio Actualizar`** (7 nodes): `IRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ObtenerPorIdAsync()`, `.ObtenerTodosAsync()`, `IRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Layout Reconnectmodal`** (5 nodes): `ReconnectModal.razor.js`, `handleReconnectStateChanged()`, `resume()`, `retry()`, `retryWhenDocumentBecomesVisible()`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `App Net10`** (5 nodes): `App`, `.BuildRenderTree()`, `FinanKore.Web.Components`, `App.razor.g.cs`, `App.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Routes Net10`** (5 nodes): `FinanKore.Web.Components`, `Routes`, `.BuildRenderTree()`, `Routes.razor.g.cs`, `Routes.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Imports Net10`** (5 nodes): `FinanKore.Web.Components`, `_Imports`, `.Execute()`, `_Imports.razor.g.cs`, `_Imports.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Navmenu Layout`** (5 nodes): `NavMenu.razor.g.cs`, `FinanKore.Web.Components.Layout`, `NavMenu`, `.BuildRenderTree()`, `NavMenu.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Reconnectmodal Layout`** (5 nodes): `ReconnectModal.razor.g.cs`, `FinanKore.Web.Components.Layout`, `ReconnectModal`, `.BuildRenderTree()`, `ReconnectModal.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Objetovalor Equals`** (5 nodes): `ObjetoValor`, `.Equals()`, `.GetHashCode()`, `.ObtenerComponentesIgualdad()`, `ObjetoValor.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Iusuariorepositorio Irepositorio`** (5 nodes): `IRepositorio`, `IUsuarioRepositorio`, `.ExisteCorreoAsync()`, `.ObtenerPorCorreoAsync()`, `IUsuarioRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Imagenperfil Crear`** (5 nodes): `ImagenPerfil`, `.Crear()`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `ImagenPerfil.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Nombrepersona Crear`** (5 nodes): `NombrePersona`, `.Crear()`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `NombrePersona.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Error Buildrendertree`** (5 nodes): `Error`, `.BuildRenderTree()`, `.OnInitialized()`, `FinanKore.Web.Components.Pages`, `Error.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Servicioperfil Servicios`** (5 nodes): `HttpClient`, `ServicioPerfil`, `.IniciarSesionAsync()`, `.RegistrarAsync()`, `ServicioPerfil.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Correoelectronico Obtenercomponentesigualdad`** (4 nodes): `CorreoElectronico`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `CorreoElectronico.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Agregarcredencialusuario Migrations`** (4 nodes): `AgregarCredencialUsuario`, `.BuildTargetModel()`, `FinanKore.Infrastructure.Migrations`, `20260512161738_AgregarCredencialUsuario.Designer.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Usuarioconfiguracion Configuraciones`** (4 nodes): `UsuarioConfiguracion`, `.Configure()`, `IEntityTypeConfiguration`, `UsuarioConfiguracion.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Notfound Buildrendertree`** (4 nodes): `FinanKore.Web.Components.Pages`, `NotFound`, `.BuildRenderTree()`, `NotFound.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Embeddedattribute Net10`** (3 nodes): `EmbeddedAttribute.cs`, `EmbeddedAttribute`, `Microsoft.CodeAnalysis`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Validatabletypeattribute Net10`** (3 nodes): `ValidatableTypeAttribute.cs`, `Microsoft.Extensions.Validation.Embedded`, `ValidatableTypeAttribute`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Weatherforecast`** (3 nodes): `WeatherForecast.cs`, `FinanKore.WebApi`, `WeatherForecast`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Iunidaddetrabajo Interfaces`** (3 nodes): `IUnidadDeTrabajo`, `.GuardarCambiosAsync()`, `IUnidadDeTrabajo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Excepciondominio Excepciones`** (3 nodes): `ExcepcionDominio`, `Exception`, `ExcepcionDominio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Inyecciondependencia Agregarinfraestructura`** (3 nodes): `InyeccionDependencia`, `.AgregarInfraestructura()`, `InyeccionDependencia.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Perfilendpoints Endpoints`** (3 nodes): `PerfilEndpoints`, `.MapPerfilEndpoints()`, `PerfilEndpoints.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Iraizagregado`** (2 nodes): `IRaizAgregado`, `IRaizAgregado.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Idominioevento Eventos`** (2 nodes): `IDominioEvento`, `IDominioEvento.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Iniciarsesionmodelo Models`** (2 nodes): `IniciarSesionModelo`, `IniciarSesionModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Registrarcuentamodelo Models`** (2 nodes): `RegistrarCuentaModelo`, `RegistrarCuentaModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Objetovalor`** (1 nodes): `ObjetoValor`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Credencial Desdepersistencia`** (1 nodes): `DesdePersistencia`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Inyecciondependencia`** (1 nodes): `InyeccionDependencia`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Agregarcredencialusuario 20260512161738`** (1 nodes): `AgregarCredencialUsuario`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `20260512161738 Agregarcredencialusuario`** (1 nodes): `Up`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `20260512161738 Agregarcredencialusuario`** (1 nodes): `Down`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Agregarcredencialusuario 20260512161738`** (1 nodes): `AgregarCredencialUsuario`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `20260512161738 Agregarcredencialusuario`** (1 nodes): `BuildTargetModel`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Appdbcontextmodelsnapshot Buildmodel`** (1 nodes): `BuildModel`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Appdbcontext Onmodelcreating`** (1 nodes): `OnModelCreating`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Appdbcontext Guardarcambiosasync`** (1 nodes): `GuardarCambiosAsync`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Servicioperfil`** (1 nodes): `ServicioPerfil`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Perfilcontroller`** (1 nodes): `PerfilController`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `AppDbContext` connect `Sesion Usuarios` to `Nombrepersona Imagenperfil`?**
  _High betweenness centrality (0.006) - this node is a cross-community bridge._
- **Are the 6 inferred relationships involving `Usuario` (e.g. with `Tabla Perfil.Usuarios` and `Registrar Cuenta`) actually correct?**
  _`Usuario` has 6 INFERRED edges - model-reasoned connections that need verification._
- **Are the 2 inferred relationships involving `IniciarSesionManejador` (e.g. with `RegistrarUsuarioManejador` and `PerfilEndpoints`) actually correct?**
  _`IniciarSesionManejador` has 2 INFERRED edges - model-reasoned connections that need verification._
- **What connects `Microsoft.CodeAnalysis`, `EmbeddedAttribute`, `Microsoft.Extensions.Validation.Embedded` to the rest of the system?**
  _70 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `Sesion Usuarios` be split into smaller, more focused modules?**
  _Cohesion score 0.14 - nodes in this community are weakly interconnected._
- **Should `Usuariorepositorio Appdbcontext` be split into smaller, more focused modules?**
  _Cohesion score 0.09 - nodes in this community are weakly interconnected._