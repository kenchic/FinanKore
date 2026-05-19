using FinanKore.Dominio.Proyecto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanKore.Infraestructura.Persistencia.Configuraciones;

public sealed class ReporteConfiguracion : IEntityTypeConfiguration<Reporte>
{
    public void Configure(EntityTypeBuilder<Reporte> builder)
    {
        builder.ToTable("Reportes", "Proyecto");

        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id)
            .ValueGeneratedNever();

        builder.Property(r => r.ProyectoId)
            .IsRequired();

        builder.Property(r => r.Nombre)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(r => r.Descripcion)
            .HasColumnType("nvarchar(max)");

        builder.Property(r => r.FechaCreacion)
            .IsRequired();
    }
}
