using API.Data;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opts=> {

opts.UseSqlite(builder.Configuration.GetConnectionString("DefaultDbConnection"));
});

var app = builder.Build();

app.MapControllers();

app.Run();
