using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WrenchWorks.Data;
using WrenchWorks.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var identityDbContextConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<IdentityDbContext>(options =>
    options.UseSqlite(identityDbContextConnectionString));

var WrenchWorksDbContextConnectionString = builder.Configuration.GetConnectionString("WrenchWorksDb");
builder.Services.AddDbContext<DbContext>(options =>
    options.UseSqlServer(WrenchWorksDbContextConnectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityDbContext>();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

app.Run();