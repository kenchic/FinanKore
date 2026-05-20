-- ============================================================
-- FinanKore :: 0006_Conceptos.sql
-- Caso de Uso: Crear Concepto Proyecto
-- Contexto:    FINANZAS
-- Tabla:       Finanzas.Conceptos
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

-- 1. Crear esquema Finanzas
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'Finanzas')
BEGIN
    EXEC('CREATE SCHEMA [Finanzas]');
END
GO

-- 2. Crear tabla Finanzas.Conceptos
IF NOT EXISTS (SELECT * FROM sys.tables t
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Finanzas' AND t.name = N'Conceptos')
BEGIN
    CREATE TABLE [Finanzas].[Conceptos]
    (
        [Id]            UNIQUEIDENTIFIER   NOT NULL,
        [Nombre]        NVARCHAR(200)      NOT NULL,
        [Valor]         DECIMAL(18,2)      NOT NULL,
        [Tipo]          INT                NOT NULL,
        [ProyectoId]    UNIQUEIDENTIFIER   NOT NULL,
        [CategoriaId]   UNIQUEIDENTIFIER   NOT NULL,
        [FechaCreacion] DATETIMEOFFSET     NOT NULL,

        CONSTRAINT [PK_Conceptos]
            PRIMARY KEY CLUSTERED ([Id]),

        CONSTRAINT [FK_Conceptos_Proyectos]
            FOREIGN KEY ([ProyectoId])
            REFERENCES [Finanzas].[Proyectos] ([Id])
            ON DELETE CASCADE,

        CONSTRAINT [FK_Conceptos_Categorias]
            FOREIGN KEY ([CategoriaId])
            REFERENCES [Finanzas].[Categorias] ([Id])
    );
END
GO

-- 3. Índice para búsquedas por proyecto
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Finanzas' AND t.name = N'Conceptos'
                 AND i.name = N'IX_Conceptos_ProyectoId')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Conceptos_ProyectoId]
        ON [Finanzas].[Conceptos] ([ProyectoId]);
END
GO

-- 4. Índice para búsquedas por categoría
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Finanzas' AND t.name = N'Conceptos'
                 AND i.name = N'IX_Conceptos_CategoriaId')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Conceptos_CategoriaId]
        ON [Finanzas].[Conceptos] ([CategoriaId]);
END
GO

-- 5. Índice único para nombres de concepto por proyecto
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Finanzas' AND t.name = N'Conceptos'
                 AND i.name = N'UQ_Conceptos_ProyectoId_Nombre')
BEGIN
    CREATE UNIQUE NONCLUSTERED INDEX [UQ_Conceptos_ProyectoId_Nombre]
        ON [Finanzas].[Conceptos] ([ProyectoId], [Nombre]);
END
GO

PRINT '✓ Tabla Finanzas.Conceptos verificada/creada exitosamente.';
GO
