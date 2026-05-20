using FinanKore.Dominio.Finanzas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanKore.Infraestructura.Persistencia.Configuraciones;

public sealed class ProyectoConfiguracion : IEntityTypeConfiguration<Proyecto>
{
    public void Configure(EntityTypeBuilder<Proyecto> builder)
    {
        builder.ToTable("Proyectos", "Finanzas");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
            .ValueGeneratedNever();

        builder.Property(p => p.Nombre)
            .HasMaxLength(200)
            .IsRequired();

        builder.HasMany(p => p.Conceptos)
            .WithOne()
            .HasForeignKey(c => c.ProyectoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
