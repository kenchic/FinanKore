---
type: "explain"
date: "2026-07-06T16:29:37.616107+00:00"
question: "Trace del gap IReporteRepositorio en el grafo"
contributor: "graphify"
source_nodes: ["IReporteRepositorio", "ReporteRepositorio", "i_reporte_repositorio", "IReporteRepositorio_IReporteRepositorio", "ReporteRepositorio_ReporteRepositorio"]
---

# Q: Trace del gap IReporteRepositorio en el grafo

## Answer

Gap NO es semantico sino de deduplicacion: 9 nodos distintos representan IReporteRepositorio + ReporteRepositorio. Causa: chunk 1 (Application/Proyecto) vio referencia en EliminarConceptoReporteManejador pero no la implementacion, creo nodo i_reporte_repositorio con label 'implementation not in chunk' + edge AMBIGUOUS 0.2. Chunk 2 (Infrastructure/Persistencia) vio la impl, creo IReporteRepositorio_IReporteRepositorio y ReporteRepositorio_ReporteRepositorio con edge implements EXTRACTED 1.0. AST luego anadio 4-5 nodos mas (file + class + sin-src variants). Resultado: 9 nodos para 2 entidades, sin edge de same_as/equals entre las variantes. Implicacion: BFS queries divergen en 9 starting nodes. Fix: post-procesado de dedup por (label, source_file_normalized) o embeddings + clustering. Mismo patron aplica a ICategoriaRepositorio e IPreferenciasRepositorio.

## Source Nodes

- IReporteRepositorio
- ReporteRepositorio
- i_reporte_repositorio
- IReporteRepositorio_IReporteRepositorio
- ReporteRepositorio_ReporteRepositorio