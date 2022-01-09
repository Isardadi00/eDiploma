using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using eDiploma.Data.Context;
using eDiploma.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<IDataServices, DataServices>();
builder.Services.AddDbContext<DiplomaDbContext>(options => 
{
    options.UseSqlite("Data Source=eDiploma.db;",
    b => b.MigrationsAssembly("eDiploma"));

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
