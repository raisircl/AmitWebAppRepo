using AmitWebAppMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IEmployeeRepository, EmployeeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.Use( async (context,next) =>
//{
//    app.Logger.LogInformation("M1: Middleware Entry");
//    await context.Response.WriteAsync("This is 1st middleware ");
//    await next();
//    app.Logger.LogInformation("M1: Middleware Exit");
//});
//app.Use(async (context, next) =>
//{
//    app.Logger.LogInformation("M2: Middleware Entry");
//    await context.Response.WriteAsync("This is 2nd middleware ");
//    await next();
//    app.Logger.LogInformation("M2: Middleware Exit");
//});
//app.Run(async context =>
//{
//    app.Logger.LogInformation("Terminal: Middleware Entry");
//    await context.Response.WriteAsync("This is last  ");
//});
app.UseHttpsRedirection();
//DefaultFilesOptions options = new DefaultFilesOptions();
//options.DefaultFileNames.Clear();
//options.DefaultFileNames.Add("foo.html");
//app.UseDefaultFiles(options);

app.UseStaticFiles();


app.UseRouting();

//app.UseEndpoints(endpoints => {
//    endpoints.MapGet("/", async context =>
//    {
//        var data = builder.Configuration["mykey"].ToString();
//        await context.Response.WriteAsync($"Process Name {System.Diagnostics.Process.GetCurrentProcess().ProcessName} and mykey {data}");
//    });
//});
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=index}/{id?}");

app.Run();
