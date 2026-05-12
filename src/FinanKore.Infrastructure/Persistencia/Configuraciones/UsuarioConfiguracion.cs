using FinanKore.Dominio.Perfil;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanKore.Infraestructura.Persistencia.Configuraciones;

public sealed class UsuarioConfiguracion : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios", "Perfil");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id)
            .ValueGeneratedNever();

        builder.Property(u => u.Correo)
            .HasConversion(c => c.Valor, v => new Dominio.Perfil.ObjetosValor.CorreoElectronico(v))
            .HasMaxLength(200)
            .IsRequired();

        builder.HasIndex(u => u.Correo)
            .IsUnique();

        builder.OwnsOne(u => u.Nombre, n =>
        {
            n.Property(p => p.Nombres)
                .HasColumnName("Nombres")
                .HasMaxLength(100)
                .IsRequired();

            n.Property(p => p.Apellidos)
                .HasColumnName("Apellidos")
                .HasMaxLength(100)
                .IsRequired();

            n.Ignore(p => p.Completo);
        });

        builder.OwnsOne(u => u.Imagen, i =>
        {
            i.Property(p => p.Url)
                .HasColumnName("ImagenUrl")
                .HasMaxLength(500);
        });

        builder.Property(u => u.FechaRegistro)
            .IsRequired();

        builder.Property(u => u.FechaUltimoAcceso);

        builder.Property(u => u.Activo)
            .IsRequired()
            .HasDefaultValue(true);
    }
}
