using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WrenchWorks.Areas.Identity.Data;
using WrenchWorks.Data;
using WrenchWorks.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var wrenchWorksIdentityDbContextConnectionString = builder.Configuration.GetConnectionString("WrenchWorksIdentityDb");
builder.Services.AddDbContext<IdentityDbContext>(options =>
    options.UseSqlServer(wrenchWorksIdentityDbContextConnectionString));

var wrenchWorksDbContextConnectionString = builder.Configuration.GetConnectionString("WrenchWorksDb");
builder.Services.AddDbContext<WrenchWorksDbContext>(options =>
    options.UseSqlServer(wrenchWorksDbContextConnectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<WrenchWorksUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityDbContext>();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
    options.AddPolicy("RequireUserRole", policy => policy.RequireRole("User"));
});

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 1;
    options.Password.RequiredUniqueChars = 1;
});

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