using System.Reflection;
using ECommerce.DataAccess.abstracts;
using ECommerce.DataAccess.Concretes;
using ECommerce.DataAccess.Contexts;
using ECommerce.Models;
using ECommerce.Services.Abstracts;
using ECommerce.Services.Concretes;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);


// AddSingleton() : Tek bir nesne
// AddScopped() : Request Response arasında 1 nesne üretir.
// AddTransient() : İstek başına bir nesne üretir.
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddDbContext<BaseDbContext>();
builder.Services.AddScoped<IProductRepository,EfProductRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, EfCategoryRepository>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddIdentity<User, IdentityRole>(opt =>
    {
        opt.User.RequireUniqueEmail = true;
        opt.Password.RequireNonAlphanumeric = false;
        opt.Password.RequiredLength = 6;
    }
).AddEntityFrameworkStores<BaseDbContext>();



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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");

app.Run();