using FitnessApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Citim string-ul de conexiune
var connectionString = builder.Configuration.GetConnectionString("Default");

// 2. AICI ERA EROAREA (trebuie ServerVersion.AutoDetect)
builder.Services.AddDbContext<AppDBContext>(options => 
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// 3. ȘI AICI ERA EROAREA (lipseau parantezele)
builder.Services.AddControllersWithViews(); 

var app = builder.Build();

// ... restul configurărilor (app.UseRouting, app.MapControllerRoute etc.)
app.Run();