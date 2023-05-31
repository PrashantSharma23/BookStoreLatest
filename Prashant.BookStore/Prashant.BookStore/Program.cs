var builder = WebApplication.CreateBuilder(args);
// REGISTER SERVICES HERE
var app = builder.Build();
// REGISTER MIDDLEWARE HERE

//5app.MapGet("/", () => "Hello World!");

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Hello from my first middleware");
//});

app.Run();

