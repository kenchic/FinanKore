-- ============================================================
-- FinanKore :: 0010_ConceptoReportes_Unicidad_Compuesta.sql
-- Caso de Uso: Crear Reporte
-- Contexto:    PROYECTO
-- Tabla:       Proyecto.ConceptoReportes
-- ============================================================
-- Reemplaza el índice único UQ_ConceptoReportes_ReporteId_Nombre
-- (que rechazaba "Transporte" como Entrada y como Salida) por uno
-- compuesto (ReporteId, Nombre, Tipo, CategoriaId) que coincide
-- con la invariante del agregado Reporte.
-- ============================================================

USE [FinanKore];
GO

SET ANSI_NULLS ON;
GO

SET QUOTED_IDENTIFIER ON;
GO

-- 1. Eliminar la constraint única vieja
IF EXISTS (SELECT * FROM sys.indexes i
           INNER JOIN sys.tables t ON i.object_id = t.object_id
           INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
           WHERE s.name = N'Proyecto' AND t.name = N'ConceptoReportes'
             AND i.name = N'UQ_ConceptoReportes_ReporteId_Nombre')
BEGIN
    DROP INDEX [UQ_ConceptoReportes_ReporteId_Nombre]
        ON [Proyecto].[ConceptoReportes];
END
GO

-- 2. Crear la nueva constraint única compuesta
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Proyecto' AND t.name = N'ConceptoReportes'
                 AND i.name = N'UQ_ConceptoReportes_ReporteId_Nombre_Tipo_CategoriaId')
BEGIN
    CREATE UNIQUE NONCLUSTERED INDEX [UQ_ConceptoReportes_ReporteId_Nombre_Tipo_CategoriaId]
        ON [Proyecto].[ConceptoReportes] ([ReporteId], [Nombre], [Tipo], [CategoriaId]);
END
GO

PRINT '✓ Índice único de ConceptoReportes reemplazado por versión compuesta.';
GO
