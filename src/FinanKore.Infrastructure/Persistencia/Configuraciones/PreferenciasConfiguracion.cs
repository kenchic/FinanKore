using FinanKore.Dominio.Configuracion;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanKore.Infraestructura.Persistencia.Configuraciones;

public sealed class PreferenciasConfiguracion : IEntityTypeConfiguration<Preferencias>
{
    public void Configure(EntityTypeBuilder<Preferencias> builder)
    {
        builder.ToTable("Preferencias", "Configuracion");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
            .ValueGeneratedNever();

        builder.Property(p => p.UsuarioId)
            .IsRequired();

        builder.HasIndex(p => p.UsuarioId)
            .IsUnique();

        builder.Property(p => p.Tema)
            .HasConversion<string>()
            .HasMaxLength(20)
            .IsRequired();
    }
}
