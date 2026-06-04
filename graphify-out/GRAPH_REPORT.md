# Graph Report - E:\Documentos\Proyectos\FinanKore  (2026-06-03)

## Corpus Check
- Corpus is ~25,693 words - fits in a single context window. You may not need a graph.

## Summary
- 752 nodes · 816 edges · 78 communities detected
- Extraction: 90% EXTRACTED · 10% INFERRED · 0% AMBIGUOUS · INFERRED: 84 edges (avg confidence: 0.83)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- [[_COMMUNITY_Infraestructura Persistencia|Infraestructura Persistencia]]
- [[_COMMUNITY_Dominio Base Entidades|Dominio Base Entidades]]
- [[_COMMUNITY_Modelos Web y DTOs|Modelos Web y DTOs]]
- [[_COMMUNITY_Manejadores Aplicacion|Manejadores Aplicacion]]
- [[_COMMUNITY_Autenticacion y Perfil|Autenticacion y Perfil]]
- [[_COMMUNITY_Scripts SQL y Tablas|Scripts SQL y Tablas]]
- [[_COMMUNITY_Entidades Dominio Finanzas|Entidades Dominio Finanzas]]
- [[_COMMUNITY_Consultas Proyectos y Reportes|Consultas Proyectos y Reportes]]
- [[_COMMUNITY_Paginas Razor Reportes|Paginas Razor Reportes]]
- [[_COMMUNITY_Servicios Web HTTP|Servicios Web HTTP]]
- [[_COMMUNITY_Configuraciones EF Core|Configuraciones EF Core]]
- [[_COMMUNITY_Pagina Home Dashboard|Pagina Home Dashboard]]
- [[_COMMUNITY_Comandos y DTOs Finanzas|Comandos y DTOs Finanzas]]
- [[_COMMUNITY_Caso Uso Reportes|Caso Uso Reportes]]
- [[_COMMUNITY_Interfaces Repositorio|Interfaces Repositorio]]
- [[_COMMUNITY_Endpoints API Finanzas|Endpoints API Finanzas]]
- [[_COMMUNITY_Endpoints API Perfil|Endpoints API Perfil]]
- [[_COMMUNITY_Endpoints API Reportes|Endpoints API Reportes]]
- [[_COMMUNITY_Objetos Valor Dominio|Objetos Valor Dominio]]
- [[_COMMUNITY_Community 19|Community 19]]
- [[_COMMUNITY_Community 20|Community 20]]
- [[_COMMUNITY_Community 21|Community 21]]
- [[_COMMUNITY_Community 22|Community 22]]
- [[_COMMUNITY_Community 23|Community 23]]
- [[_COMMUNITY_Community 24|Community 24]]
- [[_COMMUNITY_Community 25|Community 25]]
- [[_COMMUNITY_Community 26|Community 26]]
- [[_COMMUNITY_Community 27|Community 27]]
- [[_COMMUNITY_Community 28|Community 28]]
- [[_COMMUNITY_Community 29|Community 29]]
- [[_COMMUNITY_Community 30|Community 30]]
- [[_COMMUNITY_Community 31|Community 31]]
- [[_COMMUNITY_Community 32|Community 32]]
- [[_COMMUNITY_Community 33|Community 33]]
- [[_COMMUNITY_Community 34|Community 34]]
- [[_COMMUNITY_Community 35|Community 35]]
- [[_COMMUNITY_Community 36|Community 36]]
- [[_COMMUNITY_Community 37|Community 37]]
- [[_COMMUNITY_Community 38|Community 38]]
- [[_COMMUNITY_Community 39|Community 39]]
- [[_COMMUNITY_Community 40|Community 40]]
- [[_COMMUNITY_Community 41|Community 41]]
- [[_COMMUNITY_Community 42|Community 42]]
- [[_COMMUNITY_Community 43|Community 43]]
- [[_COMMUNITY_Community 44|Community 44]]
- [[_COMMUNITY_Community 45|Community 45]]
- [[_COMMUNITY_Community 46|Community 46]]
- [[_COMMUNITY_Community 47|Community 47]]
- [[_COMMUNITY_Community 48|Community 48]]
- [[_COMMUNITY_Community 49|Community 49]]
- [[_COMMUNITY_Community 50|Community 50]]
- [[_COMMUNITY_Community 51|Community 51]]
- [[_COMMUNITY_Community 52|Community 52]]
- [[_COMMUNITY_Community 53|Community 53]]
- [[_COMMUNITY_Community 54|Community 54]]
- [[_COMMUNITY_Community 55|Community 55]]
- [[_COMMUNITY_Community 56|Community 56]]
- [[_COMMUNITY_Community 57|Community 57]]
- [[_COMMUNITY_Community 58|Community 58]]
- [[_COMMUNITY_Community 59|Community 59]]
- [[_COMMUNITY_Community 114|Community 114]]
- [[_COMMUNITY_Community 115|Community 115]]
- [[_COMMUNITY_Community 116|Community 116]]
- [[_COMMUNITY_Community 117|Community 117]]
- [[_COMMUNITY_Community 118|Community 118]]
- [[_COMMUNITY_Community 119|Community 119]]
- [[_COMMUNITY_Community 120|Community 120]]
- [[_COMMUNITY_Community 121|Community 121]]
- [[_COMMUNITY_Community 122|Community 122]]
- [[_COMMUNITY_Community 123|Community 123]]
- [[_COMMUNITY_Community 124|Community 124]]
- [[_COMMUNITY_Community 125|Community 125]]
- [[_COMMUNITY_Community 126|Community 126]]
- [[_COMMUNITY_Community 127|Community 127]]
- [[_COMMUNITY_Community 128|Community 128]]
- [[_COMMUNITY_Community 129|Community 129]]
- [[_COMMUNITY_Community 130|Community 130]]
- [[_COMMUNITY_Community 131|Community 131]]

## God Nodes (most connected - your core abstractions)
1. `ReporteConceptos` - 22 edges
2. `Home` - 17 edges
3. `ServicioFinanzas` - 16 edges
4. `Conceptos` - 14 edges
5. `ProyectoConceptos` - 14 edges
6. `ServicioFinanzas` - 13 edges
7. `Reportes` - 12 edges
8. `AppDbContext (EF Core DbContext)` - 12 edges
9. `List` - 11 edges
10. `Usuario` - 11 edges

## Surprising Connections (you probably didn't know these)
- `Caso de Uso: Iniciar Sesion` --references--> `IUnidadDeTrabajo`  [EXTRACTED]
  docs/use-cases/iniciar_sesion.md → src/FinanKore.Application/Comun/Interfaces/IUnidadDeTrabajo.cs
- `Caso de Uso: Registrar Cuenta` --references--> `IUnidadDeTrabajo`  [EXTRACTED]
  docs/use-cases/registrar_cuenta.md → src/FinanKore.Application/Comun/Interfaces/IUnidadDeTrabajo.cs
- `Caso de Uso: Crear Proyecto` --references--> `CrearProyectoComando`  [EXTRACTED]
  docs/use-cases/crear_proyecto.md → src/FinanKore.Application/Finanzas/Comandos/CrearProyectoComando.cs
- `Caso de Uso: Crear Proyecto` --references--> `IProyectoRepositorio`  [EXTRACTED]
  docs/use-cases/crear_proyecto.md → src/FinanKore.Domain/Finanzas/IProyectoRepositorio.cs
- `Caso de Uso: Iniciar Sesion` --references--> `SesionIniciada`  [EXTRACTED]
  docs/use-cases/iniciar_sesion.md → src/FinanKore.Domain/Perfil/Eventos/SesionIniciada.cs

## Hyperedges (group relationships)
- **SQL Finanzas Schema Tables** — 0003_proyectos_finanzas_proyectos, 0004_categorias_finanzas_categorias, 0006_conceptos_finanzas_conceptos [EXTRACTED 1.00]
- **Finanzas Command Handlers** — crearproyectomanejador_crearproyectomanejador, crearcategoriamanejador_crearcategoriamanejador, crearconceptomanejador_crearconceptomanejador [INFERRED 0.85]
- **Proyecto Consultas Handlers** — obtenerproyectoporidmanejador_obtenerproyectoporidmanejador, obtenerproyectosmanejador_obtenerproyectosmanejador, proyectodto_proyectodto [INFERRED 0.85]
- **Perfil Comandos Handlers** — iniciarsesionmanejador_iniciarsesionmanejador, registrarusuariomanejador_registrarusuariomanejador, usuariodto_usuariodto [INFERRED 0.85]
- **Usuario Aggregate Composition** — usuario_usuario, correo_electronico_correo_electronico, nombre_persona_nombre_persona, credencial_credencial, imagen_perfil_imagen_perfil [EXTRACTED 1.00]
- **Usuario Domain Events** — usuario_usuario, usuario_registrado_usuario_registrado, sesion_iniciada_sesion_iniciada [EXTRACTED 1.00]
- **Minimal API Endpoints with MediatR** — perfil_endpoints_perfil_endpoints, proyecto_endpoints_proyecto_endpoints, reportes_endpoints_reportes_endpoints [INFERRED 0.75]
- **Crear Categoria CQRS Pipeline** — CrearCategoriaComando, CrearCategoriaManejador, ICategoriaRepositorio, CategoriaDto, Categoria_entity, IUnidadDeTrabajo [EXTRACTED 1.00]
- **Crear Concepto CQRS Pipeline** — CrearConceptoComando, CrearConceptoManejador, IProyectoRepositorio, ConceptoDto, IUnidadDeTrabajo [EXTRACTED 1.00]
- **Obtener Categorias CQRS Query Pipeline** — ObtenerCategoriasConsulta, ObtenerCategoriasManejador, ICategoriaRepositorio, CategoriaDto [EXTRACTED 1.00]
- **Iniciar Sesion CQRS Pipeline** — IniciarSesionComando, IniciarSesionManejador, IUsuarioRepositorio, CorreoElectronico_vo, Usuario_entity, UsuarioDto, IUnidadDeTrabajo [EXTRACTED 1.00]
- **Registrar Usuario CQRS Pipeline** — RegistrarUsuarioComando, RegistrarUsuarioManejador, IUsuarioRepositorio, CorreoElectronico_vo, NombrePersona_vo, ImagenPerfil_vo, Usuario_entity, UsuarioDto, IUnidadDeTrabajo [EXTRACTED 1.00]
- **Actualizar Concepto Reporte CQRS Pipeline** — ActualizarConceptoReporteComando, ActualizarConceptoReporteManejador, IReporteRepositorio, ConceptoReporteDto, IUnidadDeTrabajo [EXTRACTED 1.00]
- **Cross-Schema FK: ConceptoReportes references Finanzas.Categorias** — 0007_ConceptoReportes_table, 0004_Categorias_table, Finanzas_schema, Proyecto_schema [EXTRACTED 1.00]
- **Conceptos references both Proyectos and Categorias** — 0006_Conceptos_table, Proyectos_table, 0004_Categorias_table, Finanzas_schema [EXTRACTED 1.00]
- **CQRS Command: CrearConceptoReporte** — CrearConceptoReporteComando_CrearConceptoReporteComando, CrearConceptoReporteManejador_CrearConceptoReporteManejador, ConceptoReporteDto_ConceptoReporteDto [EXTRACTED 1.00]
- **CQRS Command: CrearReporte** — CrearReporteComando_CrearReporteComando, CrearReporteManejador_CrearReporteManejador, ReporteDto_ReporteDto [EXTRACTED 1.00]
- **CQRS Query: ObtenerConceptosPorReporte** — ObtenerConceptosPorReporteConsulta_ObtenerConceptosPorReporteConsulta, ObtenerConceptosPorReporteManejador_ObtenerConceptosPorReporteManejador, ConceptoReporteDto_ConceptoReporteDto [EXTRACTED 1.00]
- **CQRS Query: ObtenerReportesPorProyecto** — ObtenerReportesPorProyectoConsulta_ObtenerReportesPorProyectoConsulta, ObtenerReportesPorProyectoManejador_ObtenerReportesPorProyectoManejador, ReporteDto_ReporteDto [EXTRACTED 1.00]
- **CQRS Query: ObtenerTodosLosReportes** — ObtenerTodosLosReportesConsulta_ObtenerTodosLosReportesConsulta, ObtenerTodosLosReportesManejador_ObtenerTodosLosReportesManejador, ReporteListadoDto_ReporteListadoDto [EXTRACTED 1.00]
- **DDD Aggregate Root: Categoria** — Categoria_Categoria, Entidad_Entidad, IRaizAgregado_IRaizAgregado, IDominioEvento_IDominioEvento [EXTRACTED 1.00]
- **DDD Entity: Concepto** — Concepto_Concepto, Entidad_Entidad, IDominioEvento_IDominioEvento [EXTRACTED 1.00]
- **DDD Common Kernel: Entidad, ObjetoValor, IRepositorio, IRaizAgregado** — Entidad_Entidad, ObjetoValor_ObjetoValor, IRepositorio_IRepositorio, IRaizAgregado_IRaizAgregado [EXTRACTED 0.95]
- **Perfil Aggregate Root composition** — Usuario_Usuario, CorreoElectronico_CorreoElectronico, NombrePersona_NombrePersona, Credencial_Credencial, ImagenPerfil_ImagenPerfil [EXTRACTED 1.00]
- **Finanzas Proyecto Aggregate composition** — Proyecto_Proyecto, ProyectoCreado_ProyectoCreado, TipoMovimiento_TipoMovimiento [EXTRACTED 0.85]
- **Proyecto Reporte Aggregate composition** — Reporte_Reporte, ConceptoReporte_ConceptoReporte, TipoMovimiento_TipoMovimiento, ReporteCreado_ReporteCreado, ConceptoReporteCreado_ConceptoReporteCreado [EXTRACTED 1.00]
- **Perfil domain events raised by Usuario** — Usuario_Usuario, UsuarioRegistrado_UsuarioRegistrado, SesionIniciada_SesionIniciada [EXTRACTED 1.00]
- **DI Repository Interface Bindings** — InyeccionDependencia_InyeccionDependencia, IUsuarioRepositorio_IUsuarioRepositorio, IProyectoRepositorio_IProyectoRepositorio, ICategoriaRepositorio_ICategoriaRepositorio, IReporteRepositorio_IReporteRepositorio [EXTRACTED 1.00]
- **AppDbContext persisted entities** — AppDbContext_AppDbContext, Usuario_Usuario, Proyecto_Proyecto, Reporte_Reporte, ConceptoReporte_ConceptoReporte [EXTRACTED 1.00]
- **TipoMovimiento shared across Finanzas and Proyecto contexts** — TipoMovimiento_TipoMovimiento, Proyecto_Proyecto, ConceptoReporte_ConceptoReporte, Reporte_Reporte [INFERRED 0.85]
- **EF Core Configuration for Categoria** — CategoriaConfiguracion_CategoriaConfiguracion, Dominio_Categoria [EXTRACTED 1.00]
- **EF Core Configuration for Concepto** — ConceptoConfiguracion_ConceptoConfiguracion, Dominio_Concepto, Dominio_Proyecto, Dominio_Categoria [EXTRACTED 1.00]
- **EF Core Configuration for ConceptoReporte** — ConceptoReporteConfiguracion_ConceptoReporteConfiguracion, Dominio_ConceptoReporte, Dominio_Reporte, Dominio_Categoria [EXTRACTED 1.00]
- **EF Core Configuration for Proyecto with Conceptos** — ProyectoConfiguracion_ProyectoConfiguracion, Dominio_Proyecto, Dominio_Concepto [EXTRACTED 1.00]
- **EF Core Configuration for Reporte with Conceptos** — ReporteConfiguracion_ReporteConfiguracion, Dominio_Reporte, Dominio_ConceptoReporte, Dominio_Proyecto [EXTRACTED 1.00]
- **EF Core Configuration for Usuario with Value Objects** — UsuarioConfiguracion_UsuarioConfiguracion, Dominio_Usuario, Dominio_CorreoElectronico [EXTRACTED 1.00]
- **Web DI Service Registration** — WebProgram_WebProgram, ServicioPerfil_ServicioPerfil, ServicioFinanzas_ServicioFinanzas, EstadoAutenticacion_EstadoAutenticacion [EXTRACTED 1.00]
- **WebApi Endpoint Mapping** — WebApiProgram_WebApiProgram [EXTRACTED 1.00]
- **ServicioFinanzas Full Stack Data Flow** — ServicioFinanzas_ServicioFinanzas, CrearProyectoModelo_CrearProyectoModelo, CrearCategoriaModelo_CrearCategoriaModelo, CrearConceptoModelo_CrearConceptoModelo, CrearReporteModelo_CrearReporteModelo, CrearConceptoReporteModelo_CrearConceptoReporteModelo, ServicioFinanzas_ProyectoCreadoDto, ServicioFinanzas_CategoriaCreadaDto, ServicioFinanzas_ConceptoCreadoDto, ServicioFinanzas_ReporteCreadoDto, ServicioFinanzas_ConceptoReporteDto [EXTRACTED 1.00]
- **ServicioPerfil Full Stack Data Flow** — ServicioPerfil_ServicioPerfil, RegistrarCuentaModelo_RegistrarCuentaModelo, IniciarSesionModelo_IniciarSesionModelo, ServicioPerfil_UsuarioRegistradoDto, EstadoAutenticacion_EstadoAutenticacion [EXTRACTED 1.00]
- **Repositories Sharing AppDbContext** — CategoriaRepositorio_CategoriaRepositorio, ProyectoRepositorio_ProyectoRepositorio, ReporteRepositorio_ReporteRepositorio, UsuarioRepositorio_UsuarioRepositorio, AppDbContext_AppDbContext [EXTRACTED 1.00]
- **CQRS Flow: Finanzas Endpoints via MediatR** — finanzasendpoints_FinanzasEndpoints, imediatr_pattern, proyecto_aggregate, concepto_entity [EXTRACTED 1.00]
- **CQRS Flow: Perfil Endpoints via MediatR** — perfilendpoints_PerfilEndpoints, imediatr_pattern, usuario_aggregate [EXTRACTED 1.00]
- **CQRS Flow: Proyecto Endpoints via MediatR** — proyectoendpoints_ProyectoEndpoints, imediatr_pattern, reporte_aggregate [EXTRACTED 1.00]
- **CQRS Flow: Reportes Endpoints via MediatR** — reportesendpoints_ReportesEndpoints, imediatr_pattern, reporte_aggregate, concepto_reporte_entity [EXTRACTED 1.00]
- **Use Case Development Dependency Chain** — registrar_cuenta_UseCase, iniciar_sesion_UseCase, crear_proyecto_UseCase, crear_concepto_proyecto_UseCase, crear_concepto_reporte_UseCase [INFERRED 0.85]
- **Uniform ExcepcionDominio Error Handling Pattern** — finanzasendpoints_FinanzasEndpoints, perfilendpoints_PerfilEndpoints, proyectoendpoints_ProyectoEndpoints, reportesendpoints_ReportesEndpoints, excepcion_dominio [EXTRACTED 1.00]
- **Usuario Registration and Authentication Lifecycle** — usuario_aggregate, credencial_vo, correo_electronico_vo, nombre_persona_vo, usuario_registrado_event, sesion_iniciada_event [INFERRED 0.85]

## Communities

### Community 0 - "Infraestructura Persistencia"
Cohesion: 0.06
Nodes (61): AppDbContext (EF Core DbContext), CategoriaConfiguracion, CategoriaCreada (Domain Event), CategoriaRepositorio, ConceptoConfiguracion, ConceptoCreado (Domain Event), ConceptoReporteConfiguracion, ConceptoReporteCreado (Domain Event) (+53 more)

### Community 1 - "Dominio Base Entidades"
Cohesion: 0.04
Nodes (13): Entidad, Entidad, Categoria, Concepto, Proyecto, IRaizAgregado, List, FinanKore.Web.Components.Pages (+5 more)

### Community 2 - "Modelos Web y DTOs"
Cohesion: 0.05
Nodes (21): bool, CrearConceptoModelo, CrearReporteModelo, Guid, IDisposable, IniciarSesionModelo, FinanKore.Web.Components.Layout, NavMenu (+13 more)

### Community 3 - "Manejadores Aplicacion"
Cohesion: 0.04
Nodes (17): ActualizarConceptoReporteManejador, ActualizarConceptoReporteValorManejador, CrearCategoriaManejador, CrearConceptoManejador, CrearConceptoReporteManejador, CrearProyectoManejador, CrearReporteManejador, IniciarSesionManejador (+9 more)

### Community 4 - "Autenticacion y Perfil"
Cohesion: 0.06
Nodes (32): Script SQL 0001 Usuarios, Perfil.Usuarios, Script SQL 0002 Usuarios Sesion, ExcepcionDominio, CorreoElectronico, CorreoElectronico, Credencial, DbContext (+24 more)

### Community 5 - "Scripts SQL y Tablas"
Cohesion: 0.09
Nodes (33): Finanzas.Categorias, Finanzas.Conceptos, Proyecto.ConceptoReportes, ActualizarConceptoReporteComando, ActualizarConceptoReporteManejador, CategoriaDto, Categoria (Domain Entity), ConceptoDto (+25 more)

### Community 6 - "Entidades Dominio Finanzas"
Cohesion: 0.13
Nodes (25): Concepto (Entity), ConceptoReporte (Entity), CorreoElectronico (Value Object), Caso de Uso: Crear Concepto Proyecto, Caso de Uso: Crear Concepto Reporte, Caso de Uso: Crear Proyecto, Credencial (Value Object), ExcepcionDominio (+17 more)

### Community 7 - "Consultas Proyectos y Reportes"
Cohesion: 0.11
Nodes (17): Script SQL 0003 Proyectos, Finanzas.Proyectos, Script SQL 0005 Reportes, Proyecto.Reportes, ObtenerProyectoPorIdConsulta, ProyectoDto, Caso de Uso: Crear Proyecto, CrearProyectoComando (+9 more)

### Community 8 - "Paginas Razor Reportes"
Cohesion: 0.13
Nodes (5): CrearConceptoReporteModelo, decimal, FinanKore.Web.Components.Pages, __PrivateComponentRenderModeAttribute, ReporteConceptos

### Community 9 - "Servicios Web HTTP"
Cohesion: 0.1
Nodes (3): HttpClient, ServicioFinanzas, ServicioPerfil

### Community 10 - "Configuraciones EF Core"
Cohesion: 0.11
Nodes (7): CategoriaConfiguracion, ConceptoConfiguracion, ConceptoReporteConfiguracion, ProyectoConfiguracion, ReporteConfiguracion, UsuarioConfiguracion, IEntityTypeConfiguration

### Community 11 - "Pagina Home Dashboard"
Cohesion: 0.11
Nodes (6): int, FinanKore.Web.Components.Pages, Home, __PrivateComponentRenderModeAttribute, EstadoAutenticacion, UsuarioRegistradoDto

### Community 12 - "Comandos y DTOs Finanzas"
Cohesion: 0.17
Nodes (19): ActualizarConceptoReporteValorComando, Categoria, ConceptoReporteDto, Concepto, CrearConceptoReporteComando, CrearConceptoReporteManejador, CrearReporteComando, CrearReporteManejador (+11 more)

### Community 13 - "Caso Uso Reportes"
Cohesion: 0.14
Nodes (9): CrearReporteComando, IReporteRepositorio, ObtenerReportesPorProyectoConsulta, ObtenerReportesPorProyectoManejador, ObtenerTodosLosReportesConsulta, ObtenerTodosLosReportesManejador, ReporteDto, ReporteListadoDto (+1 more)

### Community 14 - "Interfaces Repositorio"
Cohesion: 0.12
Nodes (5): ICategoriaRepositorio, IProyectoRepositorio, IRepositorio, IUsuarioRepositorio, IReporteRepositorio

### Community 15 - "Endpoints API Finanzas"
Cohesion: 0.22
Nodes (3): FinanKore.Web.Components.Pages, __PrivateComponentRenderModeAttribute, ProyectoConceptos

### Community 16 - "Endpoints API Perfil"
Cohesion: 0.22
Nodes (4): CrearCategoriaModelo, Categorias, FinanKore.Web.Components.Pages, __PrivateComponentRenderModeAttribute

### Community 17 - "Endpoints API Reportes"
Cohesion: 0.22
Nodes (2): ICategoriaRepositorio, CategoriaRepositorio

### Community 18 - "Objetos Valor Dominio"
Cohesion: 0.44
Nodes (9): Documentacion de Arquitectura, CI/CD 80% Cobertura Minima, Financore.Api, Financore.Api.Test, Financore.Blazor, Financore.Client, Financore.Core, FinanKore Solution (+1 more)

### Community 19 - "Community 19"
Cohesion: 0.36
Nodes (1): Credencial

### Community 20 - "Community 20"
Cohesion: 0.25
Nodes (4): FinanKore.Web.Components.Pages, __PrivateComponentRenderModeAttribute, RegistrarCuenta, RegistrarCuentaModelo

### Community 21 - "Community 21"
Cohesion: 0.29
Nodes (1): IRepositorio

### Community 22 - "Community 22"
Cohesion: 0.29
Nodes (4): CrearProyectoModelo, CrearProyecto, FinanKore.Web.Components.Pages, __PrivateComponentRenderModeAttribute

### Community 23 - "Community 23"
Cohesion: 0.33
Nodes (3): Migration, AgregarCredencialUsuario, FinanKore.Infrastructure.Migrations

### Community 24 - "Community 24"
Cohesion: 0.6
Nodes (1): ObjetoValor

### Community 25 - "Community 25"
Cohesion: 0.4
Nodes (1): ImagenPerfil

### Community 26 - "Community 26"
Cohesion: 0.4
Nodes (1): NombrePersona

### Community 27 - "Community 27"
Cohesion: 0.4
Nodes (3): AppDbContextModelSnapshot, FinanKore.Infrastructure.Migrations, ModelSnapshot

### Community 28 - "Community 28"
Cohesion: 0.5
Nodes (2): retry(), retryWhenDocumentBecomesVisible()

### Community 29 - "Community 29"
Cohesion: 0.4
Nodes (3): FinanKore.Web.Components.Layout, MainLayout, LayoutComponentBase

### Community 30 - "Community 30"
Cohesion: 0.4
Nodes (2): Error, FinanKore.Web.Components.Pages

### Community 31 - "Community 31"
Cohesion: 0.5
Nodes (1): CorreoElectronico

### Community 32 - "Community 32"
Cohesion: 0.5
Nodes (2): AgregarCredencialUsuario, FinanKore.Infrastructure.Migrations

### Community 33 - "Community 33"
Cohesion: 0.67
Nodes (2): Microsoft.Extensions.Validation.Embedded, ValidatableTypeAttribute

### Community 34 - "Community 34"
Cohesion: 0.5
Nodes (2): App, FinanKore.Web.Components

### Community 35 - "Community 35"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components, Routes

### Community 36 - "Community 36"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components, _Imports

### Community 37 - "Community 37"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Layout, ReconnectModal

### Community 38 - "Community 38"
Cohesion: 0.5
Nodes (2): FinanKore.Web.Components.Pages, NotFound

### Community 39 - "Community 39"
Cohesion: 0.67
Nodes (2): EmbeddedAttribute, Microsoft.CodeAnalysis

### Community 40 - "Community 40"
Cohesion: 0.5
Nodes (4): IniciarSesionModelo, RegistrarCuentaModelo, ServicioPerfil, UsuarioRegistradoDto

### Community 41 - "Community 41"
Cohesion: 0.67
Nodes (1): IUnidadDeTrabajo

### Community 42 - "Community 42"
Cohesion: 0.67
Nodes (2): ExcepcionDominio, Exception

### Community 43 - "Community 43"
Cohesion: 0.67
Nodes (1): InyeccionDependencia

### Community 44 - "Community 44"
Cohesion: 0.67
Nodes (1): FinanzasEndpoints

### Community 45 - "Community 45"
Cohesion: 0.67
Nodes (1): PerfilEndpoints

### Community 46 - "Community 46"
Cohesion: 0.67
Nodes (1): ProyectoEndpoints

### Community 47 - "Community 47"
Cohesion: 0.67
Nodes (1): ReportesEndpoints

### Community 48 - "Community 48"
Cohesion: 1.0
Nodes (3): ObtenerTodosLosReportesConsulta, ObtenerTodosLosReportesManejador, ReporteListadoDto

### Community 49 - "Community 49"
Cohesion: 1.0
Nodes (1): IRaizAgregado

### Community 50 - "Community 50"
Cohesion: 1.0
Nodes (1): IDominioEvento

### Community 51 - "Community 51"
Cohesion: 1.0
Nodes (1): CrearCategoriaModelo

### Community 52 - "Community 52"
Cohesion: 1.0
Nodes (1): CrearConceptoModelo

### Community 53 - "Community 53"
Cohesion: 1.0
Nodes (1): CrearConceptoReporteModelo

### Community 54 - "Community 54"
Cohesion: 1.0
Nodes (1): CrearProyectoModelo

### Community 55 - "Community 55"
Cohesion: 1.0
Nodes (1): CrearReporteModelo

### Community 56 - "Community 56"
Cohesion: 1.0
Nodes (1): IniciarSesionModelo

### Community 57 - "Community 57"
Cohesion: 1.0
Nodes (1): RegistrarCuentaModelo

### Community 58 - "Community 58"
Cohesion: 1.0
Nodes (2): Conceptos Table DDL, Migracion Conceptos Categoria Index

### Community 59 - "Community 59"
Cohesion: 1.0
Nodes (2): Finanzas (SQL Schema), Proyecto (SQL Schema)

### Community 114 - "Community 114"
Cohesion: 1.0
Nodes (1): ObtenerConceptosPorProyectoConsulta

### Community 115 - "Community 115"
Cohesion: 1.0
Nodes (1): Entidad

### Community 116 - "Community 116"
Cohesion: 1.0
Nodes (1): IRaizAgregado

### Community 117 - "Community 117"
Cohesion: 1.0
Nodes (1): IRepositorio

### Community 118 - "Community 118"
Cohesion: 1.0
Nodes (1): ObjetoValor

### Community 119 - "Community 119"
Cohesion: 1.0
Nodes (1): IDominioEvento

### Community 120 - "Community 120"
Cohesion: 1.0
Nodes (1): ExcepcionDominio

### Community 121 - "Community 121"
Cohesion: 1.0
Nodes (1): ProyectoCreado

### Community 122 - "Community 122"
Cohesion: 1.0
Nodes (1): TipoMovimiento

### Community 123 - "Community 123"
Cohesion: 1.0
Nodes (1): TipoMovimiento

### Community 124 - "Community 124"
Cohesion: 1.0
Nodes (1): ReporteCreado

### Community 125 - "Community 125"
Cohesion: 1.0
Nodes (1): ProyectoConfiguracion

### Community 126 - "Community 126"
Cohesion: 1.0
Nodes (1): UsuarioConfiguracion

### Community 127 - "Community 127"
Cohesion: 1.0
Nodes (1): CrearProyectoModelo

### Community 128 - "Community 128"
Cohesion: 1.0
Nodes (1): CrearReporteModelo

### Community 129 - "Community 129"
Cohesion: 1.0
Nodes (1): Categorias Table DDL

### Community 130 - "Community 130"
Cohesion: 1.0
Nodes (1): ConceptoReportes Table DDL

### Community 131 - "Community 131"
Cohesion: 1.0
Nodes (1): ObjetoValor

## Knowledge Gaps
- **110 isolated node(s):** `IRaizAgregado`, `IDominioEvento`, `FinanKore.Infrastructure.Migrations`, `FinanKore.Infrastructure.Migrations`, `FinanKore.Infrastructure.Migrations` (+105 more)
  These have ≤1 connection - possible missing edges or undocumented components.
- **Thin community `Endpoints API Reportes`** (9 nodes): `ICategoriaRepositorio`, `CategoriaRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ObtenerActivasAsync()`, `.ObtenerPorIdAsync()`, `.ObtenerTodosAsync()`, `CategoriaRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 19`** (8 nodes): `Credencial`, `.Crear()`, `.DesdePersistencia()`, `.GenerarSalt()`, `.Hashear()`, `.ObtenerComponentesIgualdad()`, `.Verificar()`, `Credencial.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 21`** (7 nodes): `IRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ObtenerPorIdAsync()`, `.ObtenerTodosAsync()`, `IRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 24`** (5 nodes): `ObjetoValor`, `.Equals()`, `.GetHashCode()`, `.ObtenerComponentesIgualdad()`, `ObjetoValor.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 25`** (5 nodes): `ImagenPerfil`, `.Crear()`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `ImagenPerfil.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 26`** (5 nodes): `NombrePersona`, `.Crear()`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `NombrePersona.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 28`** (5 nodes): `handleReconnectStateChanged()`, `resume()`, `retry()`, `retryWhenDocumentBecomesVisible()`, `ReconnectModal.razor.js`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 30`** (5 nodes): `Error`, `.BuildRenderTree()`, `.OnInitialized()`, `FinanKore.Web.Components.Pages`, `Error.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 31`** (4 nodes): `CorreoElectronico`, `.ObtenerComponentesIgualdad()`, `.ToString()`, `CorreoElectronico.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 32`** (4 nodes): `AgregarCredencialUsuario`, `.BuildTargetModel()`, `FinanKore.Infrastructure.Migrations`, `20260512161738_AgregarCredencialUsuario.Designer.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 33`** (4 nodes): `Microsoft.Extensions.Validation.Embedded`, `ValidatableTypeAttribute`, `ValidatableTypeAttribute.cs`, `ValidatableTypeAttribute.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 34`** (4 nodes): `App`, `.BuildRenderTree()`, `FinanKore.Web.Components`, `App.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 35`** (4 nodes): `FinanKore.Web.Components`, `Routes`, `.BuildRenderTree()`, `Routes.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 36`** (4 nodes): `FinanKore.Web.Components`, `_Imports`, `.Execute()`, `_Imports.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 37`** (4 nodes): `FinanKore.Web.Components.Layout`, `ReconnectModal`, `.BuildRenderTree()`, `ReconnectModal.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 38`** (4 nodes): `FinanKore.Web.Components.Pages`, `NotFound`, `.BuildRenderTree()`, `NotFound.razor.g.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 39`** (4 nodes): `EmbeddedAttribute`, `Microsoft.CodeAnalysis`, `EmbeddedAttribute.cs`, `EmbeddedAttribute.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 41`** (3 nodes): `IUnidadDeTrabajo`, `.GuardarCambiosAsync()`, `IUnidadDeTrabajo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 42`** (3 nodes): `ExcepcionDominio`, `Exception`, `ExcepcionDominio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 43`** (3 nodes): `InyeccionDependencia`, `.AgregarInfraestructura()`, `InyeccionDependencia.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 44`** (3 nodes): `FinanzasEndpoints`, `.MapFinanzasEndpoints()`, `FinanzasEndpoints.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 45`** (3 nodes): `PerfilEndpoints`, `.MapPerfilEndpoints()`, `PerfilEndpoints.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 46`** (3 nodes): `ProyectoEndpoints`, `.MapProyectoEndpoints()`, `ProyectoEndpoints.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 47`** (3 nodes): `ReportesEndpoints`, `.MapReportesEndpoints()`, `ReportesEndpoints.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 49`** (2 nodes): `IRaizAgregado`, `IRaizAgregado.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 50`** (2 nodes): `IDominioEvento`, `IDominioEvento.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 51`** (2 nodes): `CrearCategoriaModelo`, `CrearCategoriaModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 52`** (2 nodes): `CrearConceptoModelo`, `CrearConceptoModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 53`** (2 nodes): `CrearConceptoReporteModelo`, `CrearConceptoReporteModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 54`** (2 nodes): `CrearProyectoModelo`, `CrearProyectoModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 55`** (2 nodes): `CrearReporteModelo`, `CrearReporteModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 56`** (2 nodes): `IniciarSesionModelo`, `IniciarSesionModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 57`** (2 nodes): `RegistrarCuentaModelo`, `RegistrarCuentaModelo.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 58`** (2 nodes): `Conceptos Table DDL`, `Migracion Conceptos Categoria Index`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 59`** (2 nodes): `Finanzas (SQL Schema)`, `Proyecto (SQL Schema)`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 114`** (1 nodes): `ObtenerConceptosPorProyectoConsulta`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 115`** (1 nodes): `Entidad`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 116`** (1 nodes): `IRaizAgregado`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 117`** (1 nodes): `IRepositorio`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 118`** (1 nodes): `ObjetoValor`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 119`** (1 nodes): `IDominioEvento`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 120`** (1 nodes): `ExcepcionDominio`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 121`** (1 nodes): `ProyectoCreado`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 122`** (1 nodes): `TipoMovimiento`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 123`** (1 nodes): `TipoMovimiento`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 124`** (1 nodes): `ReporteCreado`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 125`** (1 nodes): `ProyectoConfiguracion`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 126`** (1 nodes): `UsuarioConfiguracion`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 127`** (1 nodes): `CrearProyectoModelo`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 128`** (1 nodes): `CrearReporteModelo`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 129`** (1 nodes): `Categorias Table DDL`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 130`** (1 nodes): `ConceptoReportes Table DDL`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Community 131`** (1 nodes): `ObjetoValor`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `List` connect `Dominio Base Entidades` to `Modelos Web y DTOs`, `Paginas Razor Reportes`, `Pagina Home Dashboard`, `Endpoints API Finanzas`, `Endpoints API Perfil`?**
  _High betweenness centrality (0.029) - this node is a cross-community bridge._
- **Why does `IUnidadDeTrabajo` connect `Consultas Proyectos y Reportes` to `Autenticacion y Perfil`?**
  _High betweenness centrality (0.028) - this node is a cross-community bridge._
- **Why does `Proyecto (Aggregate Root)` connect `Infraestructura Persistencia` to `Consultas Proyectos y Reportes`?**
  _High betweenness centrality (0.026) - this node is a cross-community bridge._
- **What connects `IRaizAgregado`, `IDominioEvento`, `FinanKore.Infrastructure.Migrations` to the rest of the system?**
  _110 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `Infraestructura Persistencia` be split into smaller, more focused modules?**
  _Cohesion score 0.06 - nodes in this community are weakly interconnected._
- **Should `Dominio Base Entidades` be split into smaller, more focused modules?**
  _Cohesion score 0.04 - nodes in this community are weakly interconnected._
- **Should `Modelos Web y DTOs` be split into smaller, more focused modules?**
  _Cohesion score 0.05 - nodes in this community are weakly interconnected._