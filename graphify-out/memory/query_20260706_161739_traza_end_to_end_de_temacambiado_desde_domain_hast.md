---
type: "path_query"
date: "2026-07-06T16:17:39.710313+00:00"
question: "Traza end-to-end de TemaCambiado desde Domain hasta tema.js"
contributor: "graphify"
source_nodes: ["preferencias", "tema_cambiado_evento", "cambiar_tema_comando", "cambiar_tema_manejador", "ConfiguracionEndpoints_ConfiguracionEndpoints", "servicios_servicioconfiguracion_servicioconfiguracion", "tema_tema"]
---

# Q: Traza end-to-end de TemaCambiado desde Domain hasta tema.js

## Answer

El evento de dominio TemaCambiado viaja por 5 capas DDD: (1) Domain - Preferencias.CambiarTema() levanta TemaCambiado + ModoTema, persistido en 0009_Preferencias.sql con UQ_Preferencias_UsuarioId. (2) Application - CambiarTemaComando/CambiarTemaManejador orquesta IPreferenciasRepositorio.Preferences, retorna PreferenciasDto. (3) WebApi - ConfiguracionEndpoints (Minimal API /api/configuracion) con INFERRED edge a ServicioConfiguracion. (4) Web/Blazor - ServicioConfiguracion.CambiarTemaAsync() usa HttpClient, pero el edge HTTP->endpoint NO esta capturado en el grafo (gap de string URL). (5) JavaScript - tema.js (fkTema) maneja cookie y referencia Caso de Uso Modo Oscuro/Claro, con rationale Flicker-Free Theme Mechanism. No hay path end-to-end en el grafo (BFS no alcanza tema.js en 5 hops desde el mutator). Dos rationale nodes explicitos: Single Preference Record Per User y Domain Event on Aggregate Mutation.

## Source Nodes

- preferencias
- tema_cambiado_evento
- cambiar_tema_comando
- cambiar_tema_manejador
- ConfiguracionEndpoints_ConfiguracionEndpoints
- servicios_servicioconfiguracion_servicioconfiguracion
- tema_tema