using FitnessApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Configurare CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// 2. Configurare Bază de Date MySQL
var connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// 3. Suport pentru Controlleri și Views
builder.Services.AddControllersWithViews(); 

var app = builder.Build();

// --- PIPELINE MIDDLEWARE ---

app.UseStaticFiles(); // Permite fișiere CSS/JS dacă ai
app.UseRouting();

// ACTIVARE CORS - Fix între Routing și Authorization
app.UseCors("AllowReactApp"); 

app.UseAuthorization();

// Mapare Rute API și MVC
app.MapControllers(); 

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();