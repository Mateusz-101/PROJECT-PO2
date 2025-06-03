using Microsoft.EntityFrameworkCore;
using OSPManagementSystem.Data;
using Rotativa.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<OSPContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

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

