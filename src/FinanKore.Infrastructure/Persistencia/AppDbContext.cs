using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Comun.Mensajeria;
using FinanKore.Dominio.Comun;
using FinanKore.Dominio.Configuracion;
using FinanKore.Dominio.Eventos;
using FinanKore.Dominio.Finanzas;
using FinanKore.Dominio.Perfil;
using FinanKore.Dominio.Proyecto;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FinanKore.Infraestructura.Persistencia;

public sealed class AppDbContext : DbContext, IUnidadDeTrabajo
{
    private readonly IPublisher _publicador;

    public AppDbContext(DbContextOptions<AppDbContext> opciones, IPublisher publicador)
        : base(opciones)
    {
        _publicador = publicador;
    }

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

    public override async Task<int> SaveChangesAsync(CancellationToken token = default)
    {
        var resultado = await base.SaveChangesAsync(token);
        await PublicarEventosDominioAsync(token);
        return resultado;
    }

    public override int SaveChanges()
    {
        var resultado = base.SaveChanges();
        PublicarEventosDominio().GetAwaiter().GetResult();
        return resultado;
    }

    private async Task PublicarEventosDominioAsync(CancellationToken token)
    {
        var entidades = ChangeTracker.Entries<Entidad>()
            .Where(o => o.Entity.Eventos.Count > 0)
            .Select(o => o.Entity)
            .ToList();

        foreach (var entidad in entidades)
        {
            var eventos = entidad.Eventos.ToList();
            entidad.LimpiarEventos();

            foreach (var evento in eventos)
            {
                var tipoEnvoltorio = typeof(EnvoltorioEventoDominio<>).MakeGenericType(evento.GetType());
                var envoltorio = Activator.CreateInstance(tipoEnvoltorio, evento)!;
                await _publicador.Publish(envoltorio, token);
            }
        }
    }

    private async Task PublicarEventosDominio()
        => await PublicarEventosDominioAsync(CancellationToken.None);

    async Task<int> IUnidadDeTrabajo.GuardarCambiosAsync(CancellationToken token)
        => await SaveChangesAsync(token);
}
