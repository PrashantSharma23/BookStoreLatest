using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
// REGISTER SERVICES HERE
builder.Services.AddControllersWithViews();

//reflect latest change to browser without build
#if DEBUG    // pre processor
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#endif

var app = builder.Build();
// REGISTER MIDDLEWARE HERE // dfg //dfgas

var env = app.Environment;

if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();

// use static file from other than wwwroot folder
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "mystaticfiles")),
    RequestPath = "/mystaticfiles"
});
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    //endpoints.MapControllerRoute(
    //    name: "Default",
    //    pattern: "bookApp/{controller=Home}/{action=Index}/{id?}");
});

//app.MapDefaultControllerRoute();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapDefaultControllerRoute();
//    endpoints.MapGet("/", async context =>
//    {
//        if (env.IsDevelopment())
//        {
//            await context.Response.WriteAsync("development");
//        }
//        else if (env.IsProduction())
//        {
//            await context.Response.WriteAsync("Production");
//        }
//        else if (env.IsStaging())
//        {
//            await context.Response.WriteAsync("staging");
//        }
//        else
//        {
//            await context.Response.WriteAsync(env.EnvironmentName);
//        }
//    });
//});

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

