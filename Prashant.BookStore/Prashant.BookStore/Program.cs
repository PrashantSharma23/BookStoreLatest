var builder = WebApplication.CreateBuilder(args);
// REGISTER SERVICES HERE
builder.Services.AddControllersWithViews();



var app = builder.Build();
// REGISTER MIDDLEWARE HERE

var env = app.Environment;

if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseRouting();
app.MapDefaultControllerRoute();
app.UseEndpoints(endpoints =>
{
   // endpoints.MapDefaultControllerRoute();
    //endpoints.MapGet("/", async context =>
    //{
    //    if (env.IsDevelopment())
    //    {
    //        await context.Response.WriteAsync("development");
    //    }
    //    else if (env.IsProduction())
    //    {
    //        await context.Response.WriteAsync("Production");
    //    }
    //    else if (env.IsStaging())
    //    {
    //        await context.Response.WriteAsync("staging");
    //    }
    //    else
    //    {
    //        await context.Response.WriteAsync(env.EnvironmentName);
    //    }
    //});
});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync(env.EnvironmentName);
//});
//app.MapGet("/", () => "Hello World!");
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
//});

// app.use for call next middleware
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 1\n");

    await next();
    await context.Response.WriteAsync("Middleware 1 response!\n");

});
// app.run will not call next middleware
app.Run(async (context) =>
{
    await context.Response.WriteAsync("middleware 2\n");
});
app.Run();

