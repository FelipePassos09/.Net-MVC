using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectMVC.Data;
var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<ProjectMVCContext>(options =>
//    options.UseMySql(ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("ProjectMVCContext")), builder => builder.MigrationsAssembly("ProjectMVC")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add database connection.
var MySqlConnection = builder.Configuration.GetConnectionString("ProjectMVC");

builder.Services.AddDbContextPool<ProjectMVCContext>(options =>
    options.UseMySql(MySqlConnection,ServerVersion.AutoDetect(MySqlConnection)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();