using Microsoft.EntityFrameworkCore;
using mvcdemo;
using mvcdemo.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Startup startup = new Startup(builder.Services, builder.Configuration);
startup.ConfigureServices();

var app = builder.Build();

startup.ConfigureRouting(app);

startup.ConfigureMiddleware(app, app.Environment);

app.Run();
