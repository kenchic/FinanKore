-- =============================================================
-- DBA :: Integridad referencial de Conceptos / ConceptoReportes
-- FK_DConceptos_Categorias, FK_DConceptos_CategoriasSecundaria,
-- FK_DConceptoReportes_Categorias, FK_DConceptoReportes_CategoriasSecundaria
-- Idempotente: seguro ejecutarse N veces.
-- =============================================================
USE [FinanKore];
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

IF NOT EXISTS
(
    SELECT 1 FROM sys.foreign_keys
    WHERE name = N'FK_DConceptos_Categorias'
      AND parent_object_id = OBJECT_ID(N'[Finanzas].[Conceptos]')
)
BEGIN
    ALTER TABLE [Finanzas].[Conceptos]
        ADD CONSTRAINT [FK_DConceptos_Categorias]
        FOREIGN KEY ([CategoriaId]) REFERENCES [Finanzas].[Categorias] ([Id]);
END
GO

IF NOT EXISTS
(
    SELECT 1 FROM sys.foreign_keys
    WHERE name = N'FK_DConceptos_CategoriasSecundaria'
      AND parent_object_id = OBJECT_ID(N'[Finanzas].[Conceptos]')
)
BEGIN
    ALTER TABLE [Finanzas].[Conceptos]
        ADD CONSTRAINT [FK_DConceptos_CategoriasSecundaria]
        FOREIGN KEY ([CategoriaSecundariaId]) REFERENCES [Finanzas].[Categorias] ([Id]);
END
GO

IF NOT EXISTS
(
    SELECT 1 FROM sys.foreign_keys
    WHERE name = N'FK_DConceptoReportes_Categorias'
      AND parent_object_id = OBJECT_ID(N'[Proyecto].[ConceptoReportes]')
)
BEGIN
    ALTER TABLE [Proyecto].[ConceptoReportes]
        ADD CONSTRAINT [FK_DConceptoReportes_Categorias]
        FOREIGN KEY ([CategoriaId]) REFERENCES [Finanzas].[Categorias] ([Id]);
END
GO

IF NOT EXISTS
(
    SELECT 1 FROM sys.foreign_keys
    WHERE name = N'FK_DConceptoReportes_CategoriasSecundaria'
      AND parent_object_id = OBJECT_ID(N'[Proyecto].[ConceptoReportes]')
)
BEGIN
    ALTER TABLE [Proyecto].[ConceptoReportes]
        ADD CONSTRAINT [FK_DConceptoReportes_CategoriasSecundaria]
        FOREIGN KEY ([CategoriaSecundariaId]) REFERENCES [Finanzas].[Categorias] ([Id]);
END
GO

PRINT N'Integridad referencial aplicada.';
GO
