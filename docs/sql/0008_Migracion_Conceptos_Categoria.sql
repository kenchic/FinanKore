-- ============================================================
-- FinanKore :: 0008_Migracion_Conceptos_Categoria.sql
-- Cambio:    El índice único ahora incluye CategoriaId para
--            permitir mismo nombre con distinta categoría.
-- Tabla:     Finanzas.Conceptos
-- ============================================================

USE [FinanKore];
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

-- 1. Eliminar índice único viejo (ProyectoId + Nombre)
IF EXISTS (SELECT * FROM sys.indexes i
           INNER JOIN sys.tables t ON i.object_id = t.object_id
           INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
           WHERE s.name = N'Finanzas' AND t.name = N'Conceptos'
             AND i.name = N'UQ_Conceptos_ProyectoId_Nombre')
BEGIN
    DROP INDEX [UQ_Conceptos_ProyectoId_Nombre]
        ON [Finanzas].[Conceptos];
    PRINT '  - Índice UQ_Conceptos_ProyectoId_Nombre eliminado.';
END
GO

-- 2. Crear nuevo índice único (ProyectoId + Nombre + CategoriaId)
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Finanzas' AND t.name = N'Conceptos'
                 AND i.name = N'UQ_Conceptos_ProyectoId_Nombre_CategoriaId')
BEGIN
    CREATE UNIQUE NONCLUSTERED INDEX [UQ_Conceptos_ProyectoId_Nombre_CategoriaId]
        ON [Finanzas].[Conceptos] ([ProyectoId], [Nombre], [CategoriaId]);
    PRINT '  + Índice UQ_Conceptos_ProyectoId_Nombre_CategoriaId creado.';
END
GO

PRINT '✓ Migración completada: ahora se permite mismo nombre con distinta categoría.';
GO
