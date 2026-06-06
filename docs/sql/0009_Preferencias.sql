-- ============================================================
-- FinanKore :: 0009_Preferencias.sql
-- Caso de Uso: Modo Oscuro / Claro (Configuración de Usuario)
-- Contexto:    CONFIGURACION
-- Tabla:       Configuracion.Preferencias
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

-- 1. Crear esquema Configuracion
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'Configuracion')
BEGIN
    EXEC('CREATE SCHEMA [Configuracion]');
END
GO

-- 2. Crear tabla Configuracion.Preferencias
IF NOT EXISTS (SELECT * FROM sys.tables t
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Configuracion' AND t.name = N'Preferencias')
BEGIN
    CREATE TABLE [Configuracion].[Preferencias]
    (
        [Id]        UNIQUEIDENTIFIER NOT NULL,
        [UsuarioId] UNIQUEIDENTIFIER NOT NULL,
        [Tema]      NVARCHAR(20)     NOT NULL,

        CONSTRAINT [PK_Preferencias]
            PRIMARY KEY CLUSTERED ([Id]),

        CONSTRAINT [FK_Preferencias_Usuarios]
            FOREIGN KEY ([UsuarioId])
            REFERENCES [Perfil].[Usuarios] ([Id])
    );
END
GO

-- 3. Índice único para garantizar una sola preferencia por usuario
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Configuracion' AND t.name = N'Preferencias'
                 AND i.name = N'UQ_Preferencias_UsuarioId')
BEGIN
    CREATE UNIQUE NONCLUSTERED INDEX [UQ_Preferencias_UsuarioId]
        ON [Configuracion].[Preferencias] ([UsuarioId]);
END
GO

PRINT '✓ Tabla Configuracion.Preferencias verificada/creada exitosamente.';
GO
