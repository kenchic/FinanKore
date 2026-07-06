# Graph Report - .  (2026-07-06)

## Corpus Check
- 192 files · ~99,999 words
- Verdict: corpus is large enough that graph structure adds value.

## Summary
- 554 nodes · 631 edges · 34 communities detected
- Extraction: 78% EXTRACTED · 21% INFERRED · 0% AMBIGUOUS · INFERRED: 135 edges (avg confidence: 0.88)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- [[_COMMUNITY_ServicioFinanzas (HTTP client for apifinanzas and apirep|ServicioFinanzas (HTTP client for /api/finanzas and /api/rep]]
- [[_COMMUNITY_AppDbContext (EF Core DbContext + IUnidadDeTrabajo)|AppDbContext (EF Core DbContext + IUnidadDeTrabajo)]]
- [[_COMMUNITY_IRequestHandler|IRequestHandler]]
- [[_COMMUNITY_Usuario|Usuario]]
- [[_COMMUNITY_Concepto|Concepto]]
- [[_COMMUNITY_UsuarioRepositorio|UsuarioRepositorio]]
- [[_COMMUNITY_Credencial|Credencial]]
- [[_COMMUNITY_CategoriaDto|CategoriaDto]]
- [[_COMMUNITY_ServicioFinanzas|ServicioFinanzas]]
- [[_COMMUNITY_ProyectoRepositorio|ProyectoRepositorio]]
- [[_COMMUNITY_ExcepcionDominio|ExcepcionDominio]]
- [[_COMMUNITY_RegistrarUsuarioManejador|RegistrarUsuarioManejador]]
- [[_COMMUNITY_CrearConceptoManejador|CrearConceptoManejador]]
- [[_COMMUNITY_PreferenciasRepositorio|PreferenciasRepositorio]]
- [[_COMMUNITY_IRepositorio|IRepositorio]]
- [[_COMMUNITY_ObjetoValor|ObjetoValor]]
- [[_COMMUNITY_AgregarCredencialUsuario|AgregarCredencialUsuario]]
- [[_COMMUNITY_AppDbContext|AppDbContext]]
- [[_COMMUNITY_ObtenerTodosLosReportesManejador|ObtenerTodosLosReportesManejador]]
- [[_COMMUNITY_AppDbContextModelSnapshot|AppDbContextModelSnapshot]]
- [[_COMMUNITY_ReconnectModal.razor.js|ReconnectModal.razor.js]]
- [[_COMMUNITY_AgregarCredencialUsuario|AgregarCredencialUsuario]]
- [[_COMMUNITY_Finanzas.Proyectos|Finanzas.Proyectos]]
- [[_COMMUNITY_InyeccionDependencia|InyeccionDependencia]]
- [[_COMMUNITY_EmbeddedAttribute.cs|EmbeddedAttribute.cs]]
- [[_COMMUNITY_ValidatableTypeAttribute.cs|ValidatableTypeAttribute.cs]]
- [[_COMMUNITY_ConfiguracionEndpoints|ConfiguracionEndpoints]]
- [[_COMMUNITY_Perfil.Usuarios|Perfil.Usuarios]]
- [[_COMMUNITY_Conceptos Table DDL|Conceptos Table DDL]]
- [[_COMMUNITY_Finanzas (SQL Schema)|Finanzas (SQL Schema)]]
- [[_COMMUNITY_Categorias Table DDL|Categorias Table DDL]]
- [[_COMMUNITY_ConceptoReportes Table DDL|ConceptoReportes Table DDL]]
- [[_COMMUNITY_ObtenerConceptosPorProyectoConsulta|ObtenerConceptosPorProyectoConsulta]]
- [[_COMMUNITY_fkTema (JS cookie-based theme manager)|fkTema (JS cookie-based theme manager)]]

## God Nodes (most connected - your core abstractions)
1. `ServicioFinanzas` - 19 edges
2. `ServicioFinanzas (HTTP client for /api/finanzas and /api/reportes)` - 17 edges
3. `Usuario` - 11 edges
4. `ReporteRepositorio` - 11 edges
5. `AppDbContext (EF Core DbContext + IUnidadDeTrabajo)` - 11 edges
6. `UsuarioRepositorio` - 10 edges
7. `Categoria` - 9 edges
8. `CategoriaRepositorio` - 9 edges
9. `ProyectoRepositorio` - 9 edges
10. `RegistrarUsuarioManejador` - 9 edges

## Surprising Connections (you probably didn't know these)
- `CambiarTemaManejador` --same_as--> `CambiarTemaManejador - IRequestHandler<CambiarTemaComando, PreferenciasDto>`  [INFERRED]
  src\FinanKore.Application\Configuracion\Comandos\CambiarTemaManejador.cs → src/FinanKore.Application/Configuracion/Comandos/CambiarTemaManejador.cs
- `ObtenerPreferenciasManejador` --same_as--> `ObtenerPreferenciasManejador - IRequestHandler<ObtenerPreferenciasConsulta, PreferenciasDto?>`  [INFERRED]
  src\FinanKore.Application\Configuracion\Consultas\ObtenerPreferenciasManejador.cs → src/FinanKore.Application/Configuracion/Consultas/ObtenerPreferenciasManejador.cs
- `CrearCategoriaManejador` --same_as--> `CrearCategoriaManejador`  [INFERRED]
  src\FinanKore.Application\Finanzas\Comandos\CrearCategoriaManejador.cs → src/FinanKore.Application/Finanzas/Comandos/CrearCategoriaManejador.cs
- `CrearProyectoManejador` --same_as--> `CrearProyectoManejador`  [INFERRED]
  src\FinanKore.Application\Finanzas\Comandos\CrearProyectoManejador.cs → src/FinanKore.Application/Finanzas/Comandos/CrearProyectoManejador.cs
- `ActualizarConceptoReporteManejador` --same_as--> `ActualizarConceptoReporteManejador`  [INFERRED]
  src\FinanKore.Application\Proyecto\Comandos\ActualizarConceptoReporteManejador.cs → src/FinanKore.Application/Proyecto/Comandos/ActualizarConceptoReporteManejador.cs

## Hyperedges (group relationships)
- **SQL Finanzas Schema Tables** — 0003_proyectos_finanzas_proyectos, 0004_categorias_finanzas_categorias, 0006_conceptos_finanzas_conceptos [EXTRACTED 1.00]
- **Conceptos references both Proyectos and Categorias** — 0006_Conceptos_table, Proyectos_table, 0004_Categorias_table, Finanzas_schema [EXTRACTED 1.00]
- **Cross-Schema FK: ConceptoReportes references Finanzas.Categorias** — 0007_ConceptoReportes_table, 0004_Categorias_table, Finanzas_schema, Proyecto_schema [EXTRACTED 1.00]
- **CambiarTema CQRS Flow** — cambiar_tema_comando, cambiar_tema_manejador, i_preferencias_repositorio, preferencias, modo_tema_vo, preferencias_dto, tema_cambiado_evento [EXTRACTED 1.00]
- **ObtenerPreferencias Query Flow** — obtener_preferencias_consulta, obtener_preferencias_manejador, i_preferencias_repositorio, preferencias_dto [EXTRACTED 1.00]
- **Crear Categoria CQRS Pipeline** — CrearCategoriaComando, CrearCategoriaManejador, ICategoriaRepositorio, CategoriaDto, Categoria_entity, IUnidadDeTrabajo [EXTRACTED 1.00]
- **Crear Concepto CQRS Pipeline** — CrearConceptoComando, CrearConceptoManejador, IProyectoRepositorio, ConceptoDto, IUnidadDeTrabajo [EXTRACTED 1.00]
- **Finanzas Command Handlers** — crearproyectomanejador_crearproyectomanejador, crearcategoriamanejador_crearcategoriamanejador, crearconceptomanejador_crearconceptomanejador [INFERRED 0.85]
- **Concept Deletion via Aggregate Root Pattern** — eliminar_concepto_comando, eliminar_concepto_manejador, i_proyecto_repositorio, eliminar_concepto_reporte_comando, eliminar_concepto_reporte_manejador, i_reporte_repositorio [INFERRED 0.85]
- **Obtener Categorias CQRS Query Pipeline** — ObtenerCategoriasConsulta, ObtenerCategoriasManejador, ICategoriaRepositorio, CategoriaDto [EXTRACTED 1.00]
- **Proyecto Consultas Handlers** — obtenerproyectoporidmanejador_obtenerproyectoporidmanejador, obtenerproyectosmanejador_obtenerproyectosmanejador, proyectodto_proyectodto [INFERRED 0.85]
- **Iniciar Sesion CQRS Pipeline** — IniciarSesionComando, IniciarSesionManejador, IUsuarioRepositorio, CorreoElectronico_vo, Usuario_entity, UsuarioDto, IUnidadDeTrabajo [EXTRACTED 1.00]
- **Registrar Usuario CQRS Pipeline** — RegistrarUsuarioComando, RegistrarUsuarioManejador, IUsuarioRepositorio, CorreoElectronico_vo, NombrePersona_vo, ImagenPerfil_vo, Usuario_entity, UsuarioDto, IUnidadDeTrabajo [EXTRACTED 1.00]
- **Actualizar Concepto Reporte CQRS Pipeline** — ActualizarConceptoReporteComando, ActualizarConceptoReporteManejador, IReporteRepositorio, ConceptoReporteDto, IUnidadDeTrabajo [EXTRACTED 1.00]
- **CQRS Command: CrearConceptoReporte** — CrearConceptoReporteComando_CrearConceptoReporteComando, CrearConceptoReporteManejador_CrearConceptoReporteManejador, ConceptoReporteDto_ConceptoReporteDto [EXTRACTED 1.00]
- **CQRS Command: CrearReporte** — CrearReporteComando_CrearReporteComando, CrearReporteManejador_CrearReporteManejador, ReporteDto_ReporteDto [EXTRACTED 1.00]
- **CQRS Query: ObtenerConceptosPorReporte** — ObtenerConceptosPorReporteConsulta_ObtenerConceptosPorReporteConsulta, ObtenerConceptosPorReporteManejador_ObtenerConceptosPorReporteManejador, ConceptoReporteDto_ConceptoReporteDto [EXTRACTED 1.00]
- **CQRS Query: ObtenerReportesPorProyecto** — ObtenerReportesPorProyectoConsulta_ObtenerReportesPorProyectoConsulta, ObtenerReportesPorProyectoManejador_ObtenerReportesPorProyectoManejador, ReporteDto_ReporteDto [EXTRACTED 1.00]
- **CQRS Query: ObtenerTodosLosReportes** — ObtenerTodosLosReportesConsulta_ObtenerTodosLosReportesConsulta, ObtenerTodosLosReportesManejador_ObtenerTodosLosReportesManejador, ReporteListadoDto_ReporteListadoDto [EXTRACTED 1.00]
- **DDD Common Kernel: Entidad, ObjetoValor, IRepositorio, IRaizAgregado** — Entidad_Entidad, ObjetoValor_ObjetoValor, IRepositorio_IRepositorio, IRaizAgregado_IRaizAgregado [EXTRACTED 0.95]
- **DDD Aggregate Root: Categoria** — Categoria_Categoria, Entidad_Entidad, IRaizAgregado_IRaizAgregado, IDominioEvento_IDominioEvento [EXTRACTED 1.00]
- **DDD Entity: Concepto** — Concepto_Concepto, Entidad_Entidad, IDominioEvento_IDominioEvento [EXTRACTED 1.00]
- **Finanzas Proyecto Aggregate composition** — Proyecto_Proyecto, ProyectoCreado_ProyectoCreado, TipoMovimiento_TipoMovimiento [EXTRACTED 0.85]
- **TipoMovimiento shared across Finanzas and Proyecto contexts** — TipoMovimiento_TipoMovimiento, Proyecto_Proyecto, ConceptoReporte_ConceptoReporte, Reporte_Reporte [INFERRED 0.85]
- **Perfil Aggregate Root composition** — Usuario_Usuario, CorreoElectronico_CorreoElectronico, NombrePersona_NombrePersona, Credencial_Credencial, ImagenPerfil_ImagenPerfil [EXTRACTED 1.00]
- **Perfil domain events raised by Usuario** — Usuario_Usuario, UsuarioRegistrado_UsuarioRegistrado, SesionIniciada_SesionIniciada [EXTRACTED 1.00]
- **Proyecto Reporte Aggregate composition** — Reporte_Reporte, ConceptoReporte_ConceptoReporte, TipoMovimiento_TipoMovimiento, ReporteCreado_ReporteCreado, ConceptoReporteCreado_ConceptoReporteCreado [EXTRACTED 1.00]
- **DI Repository Interface Bindings** — InyeccionDependencia_InyeccionDependencia, IUsuarioRepositorio_IUsuarioRepositorio, IProyectoRepositorio_IProyectoRepositorio, ICategoriaRepositorio_ICategoriaRepositorio, IReporteRepositorio_IReporteRepositorio [EXTRACTED 1.00]
- **EF Core Repository Pattern in Infrastructure** — AppDbContext_AppDbContext, PreferenciasConfiguracion_PreferenciasConfiguracion, PreferenciasRepositorio_PreferenciasRepositorio, ProyectoRepositorio_ProyectoRepositorio [INFERRED 0.75]
- **AppDbContext persisted entities** — AppDbContext_AppDbContext, Usuario_Usuario, Proyecto_Proyecto, Reporte_Reporte, ConceptoReporte_ConceptoReporte [EXTRACTED 1.00]
- **EF Core Configuration for Categoria** — CategoriaConfiguracion_CategoriaConfiguracion, Dominio_Categoria [EXTRACTED 1.00]
- **EF Core Configuration for Concepto** — ConceptoConfiguracion_ConceptoConfiguracion, Dominio_Concepto, Dominio_Proyecto, Dominio_Categoria [EXTRACTED 1.00]
- **EF Core Configuration for ConceptoReporte** — ConceptoReporteConfiguracion_ConceptoReporteConfiguracion, Dominio_ConceptoReporte, Dominio_Reporte, Dominio_Categoria [EXTRACTED 1.00]
- **EF Core Configuration for Proyecto with Conceptos** — ProyectoConfiguracion_ProyectoConfiguracion, Dominio_Proyecto, Dominio_Concepto [EXTRACTED 1.00]
- **EF Core Configuration for Reporte with Conceptos** — ReporteConfiguracion_ReporteConfiguracion, Dominio_Reporte, Dominio_ConceptoReporte, Dominio_Proyecto [EXTRACTED 1.00]
- **EF Core Configuration for Usuario with Value Objects** — UsuarioConfiguracion_UsuarioConfiguracion, Dominio_Usuario, Dominio_CorreoElectronico [EXTRACTED 1.00]
- **Repositories Sharing AppDbContext** — CategoriaRepositorio_CategoriaRepositorio, ProyectoRepositorio_ProyectoRepositorio, ReporteRepositorio_ReporteRepositorio, UsuarioRepositorio_UsuarioRepositorio, AppDbContext_AppDbContext [EXTRACTED 1.00]
- **Web DI Service Registration** — WebProgram_WebProgram, ServicioPerfil_ServicioPerfil, ServicioFinanzas_ServicioFinanzas, EstadoAutenticacion_EstadoAutenticacion [EXTRACTED 1.00]
- **ServicioFinanzas Full Stack Data Flow** — ServicioFinanzas_ServicioFinanzas, CrearProyectoModelo_CrearProyectoModelo, CrearCategoriaModelo_CrearCategoriaModelo, CrearConceptoModelo_CrearConceptoModelo, CrearReporteModelo_CrearReporteModelo, CrearConceptoReporteModelo_CrearConceptoReporteModelo, ServicioFinanzas_ProyectoCreadoDto, ServicioFinanzas_CategoriaCreadaDto, ServicioFinanzas_ConceptoCreadoDto, ServicioFinanzas_ReporteCreadoDto, ServicioFinanzas_ConceptoReporteDto [EXTRACTED 1.00]
- **ServicioPerfil Full Stack Data Flow** — ServicioPerfil_ServicioPerfil, RegistrarCuentaModelo_RegistrarCuentaModelo, IniciarSesionModelo_IniciarSesionModelo, ServicioPerfil_UsuarioRegistradoDto, EstadoAutenticacion_EstadoAutenticacion [EXTRACTED 1.00]
- **WebApi Endpoint Mapping** — WebApiProgram_WebApiProgram [EXTRACTED 1.00]
- **CQRS Flow: Finanzas Endpoints via MediatR** — finanzasendpoints_FinanzasEndpoints, imediatr_pattern, proyecto_aggregate, concepto_entity [EXTRACTED 1.00]
- **Uniform ExcepcionDominio Error Handling Pattern** — finanzasendpoints_FinanzasEndpoints, perfilendpoints_PerfilEndpoints, proyectoendpoints_ProyectoEndpoints, reportesendpoints_ReportesEndpoints, excepcion_dominio [EXTRACTED 1.00]
- **CQRS Flow: Perfil Endpoints via MediatR** — perfilendpoints_PerfilEndpoints, imediatr_pattern, usuario_aggregate [EXTRACTED 1.00]
- **CQRS Flow: Proyecto Endpoints via MediatR** — proyectoendpoints_ProyectoEndpoints, imediatr_pattern, reporte_aggregate [EXTRACTED 1.00]
- **CQRS Flow: Reportes Endpoints via MediatR** — reportesendpoints_ReportesEndpoints, imediatr_pattern, reporte_aggregate, concepto_reporte_entity [EXTRACTED 1.00]

## Communities

### Community 0 - "ServicioFinanzas (HTTP client for /api/finanzas and /api/rep"
Cohesion: 0.04
Nodes (47): CategoriaConfiguracion, ConceptoConfiguracion, ConceptoReporteConfiguracion, ConfiguracionEndpoints (Minimal API: /api/configuracion), CrearCategoriaModelo, CrearConceptoModelo, CrearConceptoReporteModelo, CrearProyectoModelo (+39 more)

### Community 1 - "AppDbContext (EF Core DbContext + IUnidadDeTrabajo)"
Cohesion: 0.06
Nodes (9): Entidad, Preferencias, Entidad, Categoria, Proyecto, IRaizAgregado, List, Usuario (+1 more)

### Community 2 - "IRequestHandler"
Cohesion: 0.06
Nodes (18): CrearReporteComando, CrearReporteManejador, ObtenerReportesPorProyectoConsulta, ObtenerReportesPorProyectoManejador, ObtenerTodosLosReportesConsulta, ObtenerTodosLosReportesManejador, ReporteDto, ReporteListadoDto (+10 more)

### Community 3 - "Usuario"
Cohesion: 0.08
Nodes (27): Finanzas.Categorias, Finanzas.Conceptos, Proyecto.ConceptoReportes, ActualizarConceptoReporteComando, ActualizarConceptoReporteManejador, CategoriaDto, Categoria (Domain Entity), ConceptoDto (+19 more)

### Community 4 - "Concepto"
Cohesion: 0.08
Nodes (20): ActualizarConceptoReporteValorComando, Categoria, ConceptoReporteDto, Concepto, CrearConceptoReporteComando, CrearConceptoReporteManejador, Entidad, ExcepcionDominio (+12 more)

### Community 5 - "UsuarioRepositorio"
Cohesion: 0.1
Nodes (25): AppDbContext (EF Core DbContext + IUnidadDeTrabajo), CategoriaCreada (Domain Event), CategoriaRepositorio, ConceptoCreado (Domain Event), ConceptoReporteCreado (Domain Event), ConceptoReporte (Entity), Proyecto (Dominio), ICategoriaRepositorio (+17 more)

### Community 6 - "Credencial"
Cohesion: 0.1
Nodes (24): ActualizarConceptoComando - MediatR command (IRequest<ConceptoDto>), ActualizarConceptoManejador - IRequestHandler<ActualizarConceptoComando, ConceptoDto>, CambiarTemaComando - MediatR command (IRequest<PreferenciasDto>), CambiarTemaManejador - IRequestHandler<CambiarTemaComando, PreferenciasDto>, ActualizarConceptoManejador, EliminarConceptoManejador, EliminarConceptoReporteManejador, Domain Event on Aggregate Mutation - DDD pattern: Preferencias raises TemaCambiado in both factory and mutator (+16 more)

### Community 7 - "CategoriaDto"
Cohesion: 0.09
Nodes (11): CorreoElectronico (Value Object), Credencial (Value Object), ImagenPerfil (Value Object), NombrePersona (Value Object), SesionIniciada (Domain Event), UsuarioRegistrado (Domain Event), Usuario (Aggregate Root), CorreoElectronico (+3 more)

### Community 8 - "ServicioFinanzas"
Cohesion: 0.07
Nodes (4): HttpClient, ServicioConfiguracion, ServicioFinanzas, ServicioPerfil

### Community 9 - "ProyectoRepositorio"
Cohesion: 0.1
Nodes (7): IUsuarioRepositorio, IPreferenciasRepositorio, ICategoriaRepositorio, IProyectoRepositorio, IRepositorio, IUsuarioRepositorio, IReporteRepositorio

### Community 10 - "ExcepcionDominio"
Cohesion: 0.1
Nodes (9): ObtenerProyectoPorIdConsulta, ProyectoDto, ObtenerProyectoPorIdManejador, ObtenerProyectosManejador, IProyectoRepositorio, ObtenerProyectoPorIdManejador, ObtenerProyectosConsulta, ObtenerProyectosManejador (+1 more)

### Community 11 - "RegistrarUsuarioManejador"
Cohesion: 0.11
Nodes (10): CorreoElectronico (V.O.), Usuario (Dominio), IniciarSesionModelo, RegistrarCuentaModelo, UsuarioConfiguracion, UsuarioRepositorio, IUsuarioRepositorio, IniciarSesionModelo (+2 more)

### Community 12 - "CrearConceptoManejador"
Cohesion: 0.14
Nodes (10): FinanzasEndpoints, PerfilEndpoints, ProyectoEndpoints, ReportesEndpoints, ExcepcionDominio, FinanzasEndpoints, MediatR CQRS Pattern, PerfilEndpoints (+2 more)

### Community 13 - "PreferenciasRepositorio"
Cohesion: 0.17
Nodes (12): CorreoElectronico (Value Object), IUsuarioRepositorio, ImagenPerfil (Value Object), IniciarSesionComando, IniciarSesionManejador, NombrePersona (Value Object), RegistrarUsuarioComando, RegistrarUsuarioManejador (+4 more)

### Community 14 - "IRepositorio"
Cohesion: 0.18
Nodes (2): IReporteRepositorio, ReporteRepositorio

### Community 15 - "ObjetoValor"
Cohesion: 0.22
Nodes (2): ICategoriaRepositorio, CategoriaRepositorio

### Community 16 - "AgregarCredencialUsuario"
Cohesion: 0.22
Nodes (2): IPreferenciasRepositorio, PreferenciasRepositorio

### Community 17 - "AppDbContext"
Cohesion: 0.29
Nodes (1): IRepositorio

### Community 18 - "ObtenerTodosLosReportesManejador"
Cohesion: 0.47
Nodes (2): ObjetoValor, ObjetoValor

### Community 19 - "AppDbContextModelSnapshot"
Cohesion: 0.33
Nodes (3): Migration, AgregarCredencialUsuario, FinanKore.Infrastructure.Migrations

### Community 20 - "ReconnectModal.razor.js"
Cohesion: 0.33
Nodes (3): DbContext, IUnidadDeTrabajo, AppDbContext

### Community 21 - "AgregarCredencialUsuario"
Cohesion: 0.4
Nodes (3): AppDbContextModelSnapshot, FinanKore.Infrastructure.Migrations, ModelSnapshot

### Community 22 - "Finanzas.Proyectos"
Cohesion: 0.5
Nodes (2): retry(), retryWhenDocumentBecomesVisible()

### Community 23 - "InyeccionDependencia"
Cohesion: 0.5
Nodes (2): AgregarCredencialUsuario, FinanKore.Infrastructure.Migrations

### Community 24 - "EmbeddedAttribute.cs"
Cohesion: 0.5
Nodes (4): Script SQL 0003 Proyectos, Finanzas.Proyectos, Script SQL 0005 Reportes, Proyecto.Reportes

### Community 25 - "ValidatableTypeAttribute.cs"
Cohesion: 0.67
Nodes (1): InyeccionDependencia

### Community 26 - "ConfiguracionEndpoints"
Cohesion: 0.67
Nodes (1): ConfiguracionEndpoints

### Community 27 - "Perfil.Usuarios"
Cohesion: 0.67
Nodes (3): Script SQL 0001 Usuarios, Perfil.Usuarios, Script SQL 0002 Usuarios Sesion

### Community 28 - "Conceptos Table DDL"
Cohesion: 1.0
Nodes (2): Finanzas (SQL Schema), Proyecto (SQL Schema)

### Community 29 - "Finanzas (SQL Schema)"
Cohesion: 1.0
Nodes (2): Conceptos Table DDL, Migracion Conceptos Categoria Index

### Community 72 - "Categorias Table DDL"
Cohesion: 1.0
Nodes (1): Categorias Table DDL

### Community 73 - "ConceptoReportes Table DDL"
Cohesion: 1.0
Nodes (1): ConceptoReportes Table DDL

### Community 74 - "ObtenerConceptosPorProyectoConsulta"
Cohesion: 1.0
Nodes (1): ObtenerConceptosPorProyectoConsulta

### Community 75 - "fkTema (JS cookie-based theme manager)"
Cohesion: 1.0
Nodes (1): fkTema (JS cookie-based theme manager)

## Ambiguous Edges - Review These
- `EliminarConceptoReporteManejador - IRequestHandler<EliminarConceptoReporteComando>` → `IReporteRepositorio - Domain repository contract referenced from Proyecto (implementation not in chunk)`  [AMBIGUOUS]
  src/FinanKore.Application/Proyecto/Comandos/EliminarConceptoReporteManejador.cs · relation: calls

## Knowledge Gaps
- **37 isolated node(s):** `FinanKore.Infrastructure.Migrations`, `FinanKore.Infrastructure.Migrations`, `FinanKore.Infrastructure.Migrations`, `UsuarioRegistradoDto`, `Script SQL 0001 Usuarios` (+32 more)
  These have ≤1 connection - possible missing edges or undocumented components.
- **Thin community `IRepositorio`** (11 nodes): `IReporteRepositorio`, `ReporteRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ObtenerConceptoPorIdAsync()`, `.ObtenerPorIdAsync()`, `.ObtenerPorIdConConceptosAsync()`, `.ObtenerPorProyectoAsync()`, `.ObtenerTodosAsync()`, `ReporteRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `ObjetoValor`** (9 nodes): `ICategoriaRepositorio`, `CategoriaRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ObtenerActivasAsync()`, `.ObtenerPorIdAsync()`, `.ObtenerTodosAsync()`, `CategoriaRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `AgregarCredencialUsuario`** (9 nodes): `IPreferenciasRepositorio`, `PreferenciasRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ObtenerPorIdAsync()`, `.ObtenerPorUsuarioAsync()`, `.ObtenerTodosAsync()`, `PreferenciasRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `AppDbContext`** (7 nodes): `IRepositorio`, `.Actualizar()`, `.AgregarAsync()`, `.Eliminar()`, `.ObtenerPorIdAsync()`, `.ObtenerTodosAsync()`, `IRepositorio.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `ObtenerTodosLosReportesManejador`** (6 nodes): `ObjetoValor`, `ObjetoValor`, `.Equals()`, `.GetHashCode()`, `.ObtenerComponentesIgualdad()`, `ObjetoValor.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finanzas.Proyectos`** (5 nodes): `handleReconnectStateChanged()`, `resume()`, `retry()`, `retryWhenDocumentBecomesVisible()`, `ReconnectModal.razor.js`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `InyeccionDependencia`** (4 nodes): `AgregarCredencialUsuario`, `.BuildTargetModel()`, `FinanKore.Infrastructure.Migrations`, `20260512161738_AgregarCredencialUsuario.Designer.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `ValidatableTypeAttribute.cs`** (3 nodes): `InyeccionDependencia`, `.AgregarInfraestructura()`, `InyeccionDependencia.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `ConfiguracionEndpoints`** (3 nodes): `ConfiguracionEndpoints`, `.MapConfiguracionEndpoints()`, `ConfiguracionEndpoints.cs`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Conceptos Table DDL`** (2 nodes): `Finanzas (SQL Schema)`, `Proyecto (SQL Schema)`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Finanzas (SQL Schema)`** (2 nodes): `Conceptos Table DDL`, `Migracion Conceptos Categoria Index`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `Categorias Table DDL`** (1 nodes): `Categorias Table DDL`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `ConceptoReportes Table DDL`** (1 nodes): `ConceptoReportes Table DDL`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `ObtenerConceptosPorProyectoConsulta`** (1 nodes): `ObtenerConceptosPorProyectoConsulta`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.
- **Thin community `fkTema (JS cookie-based theme manager)`** (1 nodes): `fkTema (JS cookie-based theme manager)`
  Too small to be a meaningful cluster - may be noise or needs more connections extracted.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **What is the exact relationship between `EliminarConceptoReporteManejador - IRequestHandler<EliminarConceptoReporteComando>` and `IReporteRepositorio - Domain repository contract referenced from Proyecto (implementation not in chunk)`?**
  _Edge tagged AMBIGUOUS (relation: calls) - confidence is low._
- **Why does `AppDbContext (EF Core DbContext + IUnidadDeTrabajo)` connect `UsuarioRepositorio` to `RegistrarUsuarioManejador`, `CategoriaDto`?**
  _High betweenness centrality (0.227) - this node is a cross-community bridge._
- **Why does `CrearProyectoManejador` connect `UsuarioRepositorio` to `IRequestHandler`?**
  _High betweenness centrality (0.173) - this node is a cross-community bridge._
- **Why does `CrearProyectoManejador` connect `IRequestHandler` to `UsuarioRepositorio`?**
  _High betweenness centrality (0.166) - this node is a cross-community bridge._
- **Are the 4 inferred relationships involving `ServicioFinanzas (HTTP client for /api/finanzas and /api/reportes)` (e.g. with `ServicioConfiguracion (HTTP client for /api/configuracion)` and `FinanzasEndpoints (Minimal API: /api/finanzas)`) actually correct?**
  _`ServicioFinanzas (HTTP client for /api/finanzas and /api/reportes)` has 4 INFERRED edges - model-reasoned connections that need verification._
- **What connects `FinanKore.Infrastructure.Migrations`, `FinanKore.Infrastructure.Migrations`, `FinanKore.Infrastructure.Migrations` to the rest of the system?**
  _37 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `ServicioFinanzas (HTTP client for /api/finanzas and /api/rep` be split into smaller, more focused modules?**
  _Cohesion score 0.04 - nodes in this community are weakly interconnected._