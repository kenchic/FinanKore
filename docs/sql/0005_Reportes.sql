-- ============================================================
-- FinanKore :: 0005_Reportes.sql
-- Caso de Uso: Crear Reporte
-- Contexto:    PROYECTO
-- Tabla:       Proyecto.Reportes
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

-- 2. Crear tabla Proyecto.Reportes
IF NOT EXISTS (SELECT * FROM sys.tables t
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Proyecto' AND t.name = N'Reportes')
BEGIN
    CREATE TABLE [Proyecto].[Reportes]
    (
        [Id]            UNIQUEIDENTIFIER    NOT NULL,
        [ProyectoId]    UNIQUEIDENTIFIER    NOT NULL,
        [Nombre]        NVARCHAR(200)       NOT NULL,
        [Descripcion]   NVARCHAR(MAX)       NULL,
        [FechaCreacion] DATETIMEOFFSET      NOT NULL,

        CONSTRAINT [PK_Reportes]
            PRIMARY KEY CLUSTERED ([Id]),

        CONSTRAINT [FK_Reportes_Proyectos]
            FOREIGN KEY ([ProyectoId])
            REFERENCES [Finanzas].[Proyectos] ([Id])
    );
END
GO

-- 3. Índice para búsquedas por proyecto
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Proyecto' AND t.name = N'Reportes'
                 AND i.name = N'IX_Reportes_ProyectoId')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Reportes_ProyectoId]
        ON [Proyecto].[Reportes] ([ProyectoId]);
END
GO

-- 4. Índice para búsquedas por nombre (no único, se permite repetir)
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Proyecto' AND t.name = N'Reportes'
                 AND i.name = N'IX_Reportes_Nombre')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Reportes_Nombre]
        ON [Proyecto].[Reportes] ([Nombre]);
END
GO

PRINT '✓ Tabla Proyecto.Reportes verificada/creada exitosamente.';
GO
