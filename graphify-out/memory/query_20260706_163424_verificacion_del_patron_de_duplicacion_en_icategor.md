---
type: "explain"
date: "2026-07-06T16:34:24.436973+00:00"
question: "Verificacion del patron de duplicacion en ICategoriaRepositorio, IPreferenciasRepositorio, IUsuarioRepositorio, IProyectoRepositorio"
contributor: "graphify"
source_nodes: ["iproyectorepositorio", "IProyectoRepositorio", "IProyectoRepositorio_IProyectoRepositorio", "i_proyecto_repositorio", "i_preferencias_repositorio"]
---

# Q: Verificacion del patron de duplicacion en ICategoriaRepositorio, IPreferenciasRepositorio, IUsuarioRepositorio, IProyectoRepositorio

## Answer

Patron CONFIRMADO en los 4 repositorios. Total ~40 nodos fantasma: IReporteRepositorio=9, IProyectoRepositorio=11, IUsuarioRepositorio=8, ICategoriaRepositorio=6, IPreferenciasRepositorio=6. Causa raiz: AST y subagente semantic usan esquemas de ID NO normalizados. AST usa path/to/file_entityname; subagente genera 3 estilos (lowercase, PascalCase_SnakeCase, snake_case). Merge dedup es por ID exacto, no por label. Los nodos 'ricos' (label descriptivo con firma del contrato, ej: 'IProyectoRepositorio - Domain repository contract (IRepositorio<Proyecto> + ...)') tienen mayor valor analitico y deberian ser los canonicos. Fix recomendado: post-procesado de entity resolution agrupando por similitud de label/source_file, anadiendo edge same_as INFERRED 0.95 al canonico (max degree).

## Source Nodes

- iproyectorepositorio
- IProyectoRepositorio
- IProyectoRepositorio_IProyectoRepositorio
- i_proyecto_repositorio
- i_preferencias_repositorio