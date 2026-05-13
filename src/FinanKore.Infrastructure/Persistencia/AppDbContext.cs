using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Dominio.Finanzas;
using FinanKore.Dominio.Perfil;
using FinanKore.Dominio.Perfil.ObjetosValor;
using Microsoft.EntityFrameworkCore;

namespace FinanKore.Infraestructura.Persistencia;

public sealed class AppDbContext : DbContext, IUnidadDeTrabajo
{
    public AppDbContext(DbContextOptions<AppDbContext> opciones)
        : base(opciones) { }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Proyecto> Proyectos => Set<Proyecto>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    async Task<int> IUnidadDeTrabajo.GuardarCambiosAsync(CancellationToken token)
        => await SaveChangesAsync(token);
}
