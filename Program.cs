using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Configuración de servicios
builder.Services.AddRazorPages(); // Añade soporte para Razor Pages

var app = builder.Build();

// Configuración del middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Muestra detalles de errores en desarrollo
}
else
{
    app.UseExceptionHandler("/Error"); // Maneja errores en producción
    app.UseHsts(); // Fuerza el uso de HTTPS
}

app.UseHttpsRedirection(); // Redirige HTTP a HTTPS
app.UseStaticFiles(); // Permite el uso de archivos estáticos

app.UseRouting(); // Configura el enrutamiento

app.UseAuthorization(); // Permite la autorización

app.MapRazorPages(); // Mapea las páginas Razor

app.Run(); // Inicia la aplicación
