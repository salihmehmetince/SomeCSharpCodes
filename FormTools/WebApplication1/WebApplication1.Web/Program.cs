using Microsoft.EntityFrameworkCore;
using WebApplication1.Web.Controllers.Helpers;
using WebApplication1.Web.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDBContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon")); });

//builder.Services.AddSingleton<IHelper, Helper>();
builder.Services.AddTransient<IHelper, Helper>();
builder.Services.AddScoped<Helper>();//bu kullaným dependicy inversion prensibini uygulamadýðý için iyi deðildir.
//builder.Services.AddScoped<Helper>(sP=>new Helper());
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
