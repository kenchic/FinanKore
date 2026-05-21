using FinanKore.Dominio.Proyecto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanKore.Infraestructura.Persistencia.Configuraciones;

public sealed class ConceptoReporteConfiguracion : IEntityTypeConfiguration<ConceptoReporte>
{
    public void Configure(EntityTypeBuilder<ConceptoReporte> builder)
    {
        builder.ToTable("ConceptoReportes", "Proyecto");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
            .ValueGeneratedNever();

        builder.Property(c => c.Nombre)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(c => c.Valor)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(c => c.Tipo)
            .IsRequired();

        builder.Property(c => c.ReporteId)
            .IsRequired();

        builder.Property(c => c.CategoriaId)
            .IsRequired();

        builder.Property(c => c.FechaCreacion)
            .IsRequired();

        builder.HasIndex(c => c.ReporteId)
            .HasDatabaseName("IX_ConceptoReportes_ReporteId");

        builder.HasIndex(c => c.CategoriaId)
            .HasDatabaseName("IX_ConceptoReportes_CategoriaId");

        builder.HasIndex(c => new { c.ReporteId, c.Nombre })
            .IsUnique()
            .HasDatabaseName("UQ_ConceptoReportes_ReporteId_Nombre");
    }
}
