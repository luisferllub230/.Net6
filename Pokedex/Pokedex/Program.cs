using Microsoft.EntityFrameworkCore;
using Pokedex.core.Application;
using Pokedex.infraestruture.Persistence;
using Pokedex.infraestruture.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container
builder.Services.AddPersistenceInfrastruture(builder.Configuration);
builder.Services.AddApplicationLayer();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
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
    pattern: "{controller=pokedex}/{action=Index}");

app.Run();
