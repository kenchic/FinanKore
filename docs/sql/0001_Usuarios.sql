-- ============================================================
-- FinanKore :: 0001_Usuarios.sql
-- Caso de Uso: Registrar Cuenta
-- Contexto:    PERFIL
-- Tabla:       Perfil.Usuarios
-- ============================================================

-- 1. Crear la base de datos si no existe
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

-- 2. Crear esquema Perfil
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'Perfil')
BEGIN
    EXEC('CREATE SCHEMA [Perfil]');
END
GO

-- 3. Crear tabla Perfil.Usuarios
IF NOT EXISTS (SELECT * FROM sys.tables t
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Perfil' AND t.name = N'Usuarios')
BEGIN
    CREATE TABLE [Perfil].[Usuarios]
    (
        [Id]                UNIQUEIDENTIFIER    NOT NULL,
        [Correo]            NVARCHAR(200)       NOT NULL,
        [Nombres]           NVARCHAR(100)       NOT NULL,
        [Apellidos]         NVARCHAR(100)       NOT NULL,
        [ImagenUrl]         NVARCHAR(500)       NULL,
        [FechaRegistro]     DATETIMEOFFSET      NOT NULL,
        [FechaUltimoAcceso] DATETIMEOFFSET      NULL,
        [Activo]            BIT                 NOT NULL DEFAULT 1,

        CONSTRAINT [PK_Usuarios]
            PRIMARY KEY CLUSTERED ([Id]),

        CONSTRAINT [UQ_Usuarios_Correo]
            UNIQUE ([Correo])
    );
END
GO

-- 4. Índice para búsquedas por correo (cubre el UNIQUE anterior)
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Perfil' AND t.name = N'Usuarios'
                 AND i.name = N'IX_Usuarios_Correo')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Usuarios_Correo]
        ON [Perfil].[Usuarios] ([Correo]);
END
GO

-- 5. Índice para filtrar usuarios activos
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Perfil' AND t.name = N'Usuarios'
                 AND i.name = N'IX_Usuarios_Activo')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Usuarios_Activo]
        ON [Perfil].[Usuarios] ([Activo])
        WHERE [Activo] = 1;
END
GO

PRINT '✓ Tabla Perfil.Usuarios verificada/creada exitosamente.';
GO
