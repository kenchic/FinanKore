-- ============================================================
-- FinanKore :: 0007_ConceptoReportes.sql
-- Caso de Uso: Crear Concepto Reporte
-- Contexto:    PROYECTO
-- Tabla:       Proyecto.ConceptoReportes
-- ============================================================

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'FinanKore')
BEGIN
    CREATE DATABASE [FinanKore];
END
GO

USE [FinanKore];
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

-- 1. Crear esquema Proyecto
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'Proyecto')
BEGIN
    EXEC('CREATE SCHEMA [Proyecto]');
END
GO

-- 2. Crear tabla Proyecto.ConceptoReportes
IF NOT EXISTS (SELECT * FROM sys.tables t
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Proyecto' AND t.name = N'ConceptoReportes')
BEGIN
    CREATE TABLE [Proyecto].[ConceptoReportes]
    (
        [Id]            UNIQUEIDENTIFIER   NOT NULL,
        [Nombre]        NVARCHAR(200)      NOT NULL,
        [Valor]         DECIMAL(18,2)      NOT NULL,
        [Tipo]          INT                NOT NULL,
        [ReporteId]     UNIQUEIDENTIFIER   NOT NULL,
        [CategoriaId]   UNIQUEIDENTIFIER   NOT NULL,
        [FechaCreacion] DATETIMEOFFSET     NOT NULL,

        CONSTRAINT [PK_ConceptoReportes]
            PRIMARY KEY CLUSTERED ([Id]),

        CONSTRAINT [FK_ConceptoReportes_Reportes]
            FOREIGN KEY ([ReporteId])
            REFERENCES [Proyecto].[Reportes] ([Id])
            ON DELETE CASCADE,

        CONSTRAINT [FK_ConceptoReportes_Categorias]
            FOREIGN KEY ([CategoriaId])
            REFERENCES [Finanzas].[Categorias] ([Id])
    );
END
GO

-- 3. Índice para búsquedas por reporte
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Proyecto' AND t.name = N'ConceptoReportes'
                 AND i.name = N'IX_ConceptoReportes_ReporteId')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_ConceptoReportes_ReporteId]
        ON [Proyecto].[ConceptoReportes] ([ReporteId]);
END
GO

-- 4. Índice para búsquedas por categoría
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Proyecto' AND t.name = N'ConceptoReportes'
                 AND i.name = N'IX_ConceptoReportes_CategoriaId')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_ConceptoReportes_CategoriaId]
        ON [Proyecto].[ConceptoReportes] ([CategoriaId]);
END
GO

-- 5. Índice único para nombres de concepto por reporte (compuesto por nombre + tipo + categoría)
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

PRINT '✓ Tabla Proyecto.ConceptoReportes verificada/creada exitosamente.';
GO
