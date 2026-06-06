using FinanKore.Web.Components;
using FinanKore.Web.Servicios;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

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

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
