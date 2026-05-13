-- ============================================================
-- FinanKore :: 0003_Proyectos.sql
-- Caso de Uso: Crear Proyecto
-- Contexto:    FINANZAS
-- Tabla:       Finanzas.Proyectos
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

-- 2. Crear tabla Finanzas.Proyectos
IF NOT EXISTS (SELECT * FROM sys.tables t
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Finanzas' AND t.name = N'Proyectos')
BEGIN
    CREATE TABLE [Finanzas].[Proyectos]
    (
        [Id]     UNIQUEIDENTIFIER NOT NULL,
        [Nombre] NVARCHAR(200)    NOT NULL,

        CONSTRAINT [PK_Proyectos]
            PRIMARY KEY CLUSTERED ([Id])
    );
END
GO

-- 3. Índice para búsquedas por nombre
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Finanzas' AND t.name = N'Proyectos'
                 AND i.name = N'IX_Proyectos_Nombre')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Proyectos_Nombre]
        ON [Finanzas].[Proyectos] ([Nombre]);
END
GO

PRINT '✓ Tabla Finanzas.Proyectos verificada/creada exitosamente.';
GO
