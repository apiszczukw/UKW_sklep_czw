using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using UKW_sklep_czw.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FilmsContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb")));




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
    name: "Details",
    pattern: "{action}/{filmId}",
    defaults: new { controller = "Films", action = "Details" }
    );

app.MapControllerRoute(
	name: "Categories",
	pattern: "{categoryName}",
	defaults: new { controller = "Films", action = "FilmsList" }
	);

app.MapControllerRoute(
    name: "StaticSites",
    pattern: "Info/{viewName}",
    defaults: new { controller = "Home", action = "footerSites" }
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
