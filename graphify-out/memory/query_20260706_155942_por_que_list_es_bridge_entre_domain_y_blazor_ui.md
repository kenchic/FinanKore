---
type: "query"
date: "2026-07-06T15:59:42.095995+00:00"
question: "Por que List es bridge entre Domain y Blazor UI"
contributor: "graphify"
source_nodes: ["List", "Entidad", "Proyecto", "Reporte", "Categorias", "Conceptos", "Home", "ProyectoConceptos", "Proyectos", "ReporteConceptos"]
---

# Q: Por que List es bridge entre Domain y Blazor UI

## Answer

List (System.Collections.Generic) tiene 11 edges EXTRACTED hacia 3 entidades de dominio (Entidad, Proyecto, Reporte) y 8 paginas Blazor (Categorias, Conceptos, Home, ProyectoConceptos, Proyectos, ReporteConceptos, Reportes, ReportesProyecto). El bridge existe porque: (1) las entidades de dominio agregan hijos via List<T> (Proyecto.Conceptos, Reporte.ConceptoReportes) y Entidad mantiene List<IDominioEvento>; (2) las paginas Blazor exponen List<Dto> como propiedad de su modelo. El patron de mapeo es uniforme - List a List - sin acoplamiento exotico.

## Source Nodes

- List
- Entidad
- Proyecto
- Reporte
- Categorias
- Conceptos
- Home
- ProyectoConceptos
- Proyectos
- ReporteConceptos
- Reportes
- ReportesProyecto