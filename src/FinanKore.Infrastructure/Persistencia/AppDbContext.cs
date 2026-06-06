using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Dominio.Configuracion;
using FinanKore.Dominio.Finanzas;
using FinanKore.Dominio.Perfil;
using FinanKore.Dominio.Proyecto;
using Microsoft.EntityFrameworkCore;

namespace FinanKore.Infraestructura.Persistencia;

public sealed class AppDbContext : DbContext, IUnidadDeTrabajo
{
    public AppDbContext(DbContextOptions<AppDbContext> opciones)
        : base(opciones) { }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Proyecto> Proyectos => Set<Proyecto>();
    public DbSet<Categoria> Categorias => Set<Categoria>();
    public DbSet<Concepto> Conceptos => Set<Concepto>();
    public DbSet<Reporte> Reportes => Set<Reporte>();
    public DbSet<ConceptoReporte> ConceptoReportes => Set<ConceptoReporte>();
    public DbSet<Preferencias> Preferencias => Set<Preferencias>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    async Task<int> IUnidadDeTrabajo.GuardarCambiosAsync(CancellationToken token)
        => await SaveChangesAsync(token);
}
