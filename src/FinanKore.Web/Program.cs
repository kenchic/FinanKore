using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Options;
using FinanKore.Web.Components;
using FinanKore.Web.Servicios;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Persistir el key ring de DataProtection (antiforgery/circuitos) fuera del contenedor:
// sin esto, cada recreation del contenedor invalida las cookies de navegadores abiertos
// ("The key {GUID} was not found in the key ring").
builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(Path.Combine(AppContext.BaseDirectory, "keys")))
    .SetApplicationName("FinanKore");

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<AutenticacionStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(sp =>
    sp.GetRequiredService<AutenticacionStateProvider>());
builder.Services.AddAuthorization();
builder.Services
    .AddAuthentication("SesionAnonima")
    .AddScheme<AuthenticationSchemeOptions, ManijaSesionAnonima>("SesionAnonima", _ => { });

builder.Services.AddRadzenComponents();

builder.Services.AddHttpClient<ServicioPerfil>(cliente =>
{
    cliente.BaseAddress = new Uri(
        builder.Configuration["ApiBaseUrl"]
        ?? "http://localhost:5157");
});

builder.Services.AddHttpClient<ServicioFinanzas>(cliente =>
{
    cliente.BaseAddress = new Uri(
        builder.Configuration["ApiBaseUrl"]
        ?? "http://localhost:5157");
});

builder.Services.AddHttpClient<ServicioConfiguracion>(cliente =>
{
    cliente.BaseAddress = new Uri(
        builder.Configuration["ApiBaseUrl"]
        ?? "http://localhost:5157");
});

builder.Services.AddScoped<EstadoAutenticacion>();
builder.Services.AddScoped<EstadoSidebar>();
builder.Services.AddScoped<EstadoCalculadora>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
