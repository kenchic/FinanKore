using FinanKore.Infraestructura;
using FinanKore.WebApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddAuthorization();

builder.Services.AgregarInfraestructura(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapPerfilEndpoints();
app.MapFinanzasEndpoints();
app.MapProyectoEndpoints();
app.MapReportesEndpoints();

app.Run();
