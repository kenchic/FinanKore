---
type: "query"
date: "2026-07-06T16:38:47.863327+00:00"
question: "Post-procesado de entity resolution (dedup) aplicado al grafo"
contributor: "graphify"
source_nodes: ["IProyectoRepositorio", "finanzas_iproyectorepositorio_iproyectorepositorio", "iproyectorepositorio"]
---

# Q: Post-procesado de entity resolution (dedup) aplicado al grafo

## Answer

Aplicado dedup basado en (label normalizado, source_file normalizado) como discriminador. Resultado: 81 grupos, 193 nodos consolidados, 112 same_as edges bidireccionales INFERRED 0.95. Comunidades reducidas de 112 a 75 (consolidacion efectiva). Polimorfismo respetado (.Handle(), .Crear(), .Configure() no se fusionan porque tienen source_file distintos). Nodos canonicos elegidos por max degree. IProyectoRepositorio: 5 variantes ahora conectadas via same_as al canonico finanzas_iproyectorepositorio_iproyectorepositorio (deg=8). Queries BFS aun encuentran multiples matches por label; mejorar requiere colapsar same_as en el BFS. Beneficio inmediato: HTML muestra los edges same_as, cohesión de comunidades mejora, ghost nodes quedan vinculados.

## Source Nodes

- IProyectoRepositorio
- finanzas_iproyectorepositorio_iproyectorepositorio
- iproyectorepositorio