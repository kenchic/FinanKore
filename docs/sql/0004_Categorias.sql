-- ============================================================
-- FinanKore :: 0004_Categorias.sql
-- Caso de Uso: Crear Categorias
-- Contexto:    FINANZAS
-- Tabla:       Finanzas.Categorias
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

-- 2. Crear tabla Finanzas.Categorias
IF NOT EXISTS (SELECT * FROM sys.tables t
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Finanzas' AND t.name = N'Categorias')
BEGIN
    CREATE TABLE [Finanzas].[Categorias]
    (
        [Id]            UNIQUEIDENTIFIER   NOT NULL,
        [Nombre]        NVARCHAR(200)      NOT NULL,
        [Descripcion]   NVARCHAR(500)      NULL,
        [Activo]        BIT                NOT NULL DEFAULT 1,
        [FechaCreacion] DATETIMEOFFSET     NOT NULL,

        CONSTRAINT [PK_Categorias]
            PRIMARY KEY CLUSTERED ([Id])
    );
END
GO

-- 3. Índice único para nombres de categoría (global al sistema)
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Finanzas' AND t.name = N'Categorias'
                 AND i.name = N'UQ_Categorias_Nombre')
BEGIN
    CREATE UNIQUE NONCLUSTERED INDEX [UQ_Categorias_Nombre]
        ON [Finanzas].[Categorias] ([Nombre]);
END
GO

PRINT '✓ Tabla Finanzas.Categorias verificada/creada exitosamente.';
GO
