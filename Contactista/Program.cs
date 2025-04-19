using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Contactista.DataAccess;
using Contactista.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ContactistaConnectionString");
builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    // Register your repositories
   
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Home/Error");
    app.UseDeveloperExceptionPage();
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); 
app.UseAuthorization();

app.MapControllerRoute(
            name: "Default",
            pattern: "{controller}/{action}/{id?}");


//app.MapGet("/", () => "Hello World!");

app.Run();
