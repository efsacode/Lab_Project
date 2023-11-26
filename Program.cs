using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Application1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Application1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Application1Context") ?? throw new InvalidOperationException("Connection string 'Application1Context' not found.")));


builder.Services.AddControllersWithViews();

var app = builder.Build();


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
    pattern: "{controller=Employees}/{action=Index}/{id?}");


app.Run();

