var builder = WebApplication.CreateBuilder(args);


//Enabling MVC
builder.Services.AddControllersWithViews();
var app = builder.Build();

//Configuring Routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
