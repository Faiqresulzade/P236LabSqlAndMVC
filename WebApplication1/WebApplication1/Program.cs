using WebApplication1.Services.Abstract;
using WebApplication1.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IAppDataContext, AppDataContext>();

var app = builder.Build();

app.MapControllerRoute( name: "default",
    pattern: "{controller=home}/{action=index}/{id?}");

app.Run();
