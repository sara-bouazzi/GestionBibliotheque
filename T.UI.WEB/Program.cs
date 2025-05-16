using Microsoft.EntityFrameworkCore;
using T.Core.Domaine;
using T.Core.Interfaces;
using T.Core.Services;
using T.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IService<PretLivre>, Service<PretLivre>>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContext<TContext>(options =>
    options.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=test;Integrated Security=true"));

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
