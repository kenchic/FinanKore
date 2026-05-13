-- ============================================================
-- FinanKore :: 0002_Usuarios_Sesion.sql
-- Caso de Uso: Iniciar Sesion
-- Contexto:    PERFIL
-- Tabla:       Perfil.Usuarios
-- Objetivo:    Asegurar esquema fisico completo para autenticacion
--              (Correo + Credencial) con indices optimizados.
-- ============================================================

USE [master];
GO

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

-- 1. Esquema Perfil
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'Perfil')
BEGIN
    EXEC('CREATE SCHEMA [Perfil]');
END
GO

-- 2. Tabla Perfil.Usuarios (creacion completa o alteracion incremental)
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
        [PasswordHash]      NVARCHAR(100)       NOT NULL,
        [PasswordSalt]      NVARCHAR(50)        NOT NULL,
        [ImagenUrl]         NVARCHAR(500)       NULL,
        [FechaRegistro]     DATETIMEOFFSET      NOT NULL,
        [FechaUltimoAcceso] DATETIMEOFFSET      NULL,
        [Activo]            BIT                 NOT NULL CONSTRAINT [DF_Usuarios_Activo] DEFAULT 1,

        CONSTRAINT [PK_Usuarios]
            PRIMARY KEY CLUSTERED ([Id]),

        CONSTRAINT [UQ_Usuarios_Correo]
            UNIQUE ([Correo])
    );
END
ELSE
BEGIN
    -- Compatibilidad: si la tabla fue creada por script anterior sin credenciales
    IF NOT EXISTS (SELECT * FROM sys.columns c
                   INNER JOIN sys.tables t ON c.object_id = t.object_id
                   INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
                   WHERE s.name = N'Perfil' AND t.name = N'Usuarios' AND c.name = N'PasswordHash')
    BEGIN
        ALTER TABLE [Perfil].[Usuarios]
            ADD [PasswordHash] NVARCHAR(100) NOT NULL
                CONSTRAINT [DF_Usuarios_PasswordHash] DEFAULT '';
    END

    IF NOT EXISTS (SELECT * FROM sys.columns c
                   INNER JOIN sys.tables t ON c.object_id = t.object_id
                   INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
                   WHERE s.name = N'Perfil' AND t.name = N'Usuarios' AND c.name = N'PasswordSalt')
    BEGIN
        ALTER TABLE [Perfil].[Usuarios]
            ADD [PasswordSalt] NVARCHAR(50) NOT NULL
                CONSTRAINT [DF_Usuarios_PasswordSalt] DEFAULT '';
    END
END
GO

-- 3. Indices optimizados para Iniciar Sesion

-- Indice cubierto para busqueda por correo (login + registro)
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

-- Indice filtrado para usuarios activos (evita loguear cuentas desactivadas)
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

-- 4. Indice cubierto para autenticacion (correo + activo incluyendo hash/salt)
IF NOT EXISTS (SELECT * FROM sys.indexes i
               INNER JOIN sys.tables t ON i.object_id = t.object_id
               INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
               WHERE s.name = N'Perfil' AND t.name = N'Usuarios'
                 AND i.name = N'IX_Usuarios_Autenticacion')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Usuarios_Autenticacion]
        ON [Perfil].[Usuarios] ([Correo], [Activo])
        INCLUDE ([PasswordHash], [PasswordSalt], [Id], [Nombres], [Apellidos], [ImagenUrl], [FechaRegistro], [FechaUltimoAcceso]);
END
GO

PRINT '✓ Tabla Perfil.Usuarios verificada/creada exitosamente para caso de uso Iniciar Sesion.';
GO
