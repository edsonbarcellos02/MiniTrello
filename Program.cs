using Microsoft.EntityFrameworkCore;
using MiniTrello.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Database>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();



app.Run();
