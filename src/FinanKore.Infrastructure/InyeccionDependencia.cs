using FinanKore.Aplicacion.Finanzas.Comandos;
using FinanKore.Aplicacion.Comun.Interfaces;
using FinanKore.Aplicacion.Perfil.Comandos;
using FinanKore.Dominio.Finanzas;
using FinanKore.Dominio.Perfil;
using FinanKore.Infraestructura.Persistencia;
using FinanKore.Infraestructura.Persistencia.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinanKore.Infraestructura;

public static class InyeccionDependencia
{
    public static IServiceCollection AgregarInfraestructura(
        this IServiceCollection servicios,
        IConfiguration configuracion)
    {
        var cadenaConexion = configuracion.GetConnectionString("CadenaConexion")
            ?? throw new InvalidOperationException(
                "CadenaConexion no encontrada en appsettings.json.");

        servicios.AddDbContext<AppDbContext>(opciones =>
            opciones.UseSqlServer(cadenaConexion));

        servicios.AddScoped<IUnidadDeTrabajo>(sp => sp.GetRequiredService<AppDbContext>());
        servicios.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
        servicios.AddScoped<IProyectoRepositorio, ProyectoRepositorio>();
        servicios.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssemblyContaining<RegistrarUsuarioComando>());
        servicios.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssemblyContaining<CrearProyectoComando>());

        return servicios;
    }
}
