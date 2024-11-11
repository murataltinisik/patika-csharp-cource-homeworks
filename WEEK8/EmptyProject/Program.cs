var builder = WebApplication.CreateBuilder(args);

// Controllers and Views add MVC Services. 
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Static Files include from wwwroot
app.UseStaticFiles();

// Use Routing: It is required to redirect HTTP requests for correct endpoint.
app.UseRouting();

// MapGet: Used To Define which request controllers and actions handle.
app.MapGet("/", () => "Hello World!");

// Start App
app.Run();