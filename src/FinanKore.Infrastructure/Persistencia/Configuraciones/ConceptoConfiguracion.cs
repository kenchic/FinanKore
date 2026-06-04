using FinanKore.Dominio.Finanzas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanKore.Infraestructura.Persistencia.Configuraciones;

public sealed class ConceptoConfiguracion : IEntityTypeConfiguration<Concepto>
{
    public void Configure(EntityTypeBuilder<Concepto> builder)
    {
        builder.ToTable("Conceptos", "Finanzas");

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

        builder.Property(c => c.ProyectoId)
            .IsRequired();

        builder.Property(c => c.CategoriaId)
            .IsRequired();

        builder.Property(c => c.FechaCreacion)
            .IsRequired();

        builder.HasIndex(c => c.ProyectoId)
            .HasDatabaseName("IX_Conceptos_ProyectoId");

        builder.HasIndex(c => c.CategoriaId)
            .HasDatabaseName("IX_Conceptos_CategoriaId");

        builder.HasIndex(c => new { c.ProyectoId, c.Nombre, c.CategoriaId })
            .IsUnique()
            .HasDatabaseName("UQ_Conceptos_ProyectoId_Nombre_CategoriaId");
    }
}
