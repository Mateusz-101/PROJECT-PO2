using Microsoft.EntityFrameworkCore;
using OSPManagementSystem.Data;
using Rotativa.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Dodaj kontekst bazy danych
builder.Services.AddDbContext<OSPContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OSPContext")));

// Dodaj kontrolery i widoki
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Œcie¿ka b³êdów, HTTPS itp.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

RotativaConfiguration.Setup(app.Environment.WebRootPath, "Rotativa");

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

