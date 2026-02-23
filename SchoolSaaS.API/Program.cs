using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using SchoolSaaS.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add Services
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();  // /openapi/v1.json
    app.MapScalarApiReference();  // Optional UI replacement for Swagger}
}

app.UseHttpsRedirection();
app.MapControllers();
app.MapGet("/test", () => "API Working").WithName("test");

app.Run();


