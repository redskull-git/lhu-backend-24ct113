using MaSV_NguyenVanTeo.Api;
using MaSV_NguyenVanTeo.Api.Database;
using MaSV_NguyenVanTeo.Api.IServices;
using MaSV_NguyenVanTeo.Api.Services;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? "";

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped(sp => new SqlConnection(connectionString));

builder.Services.AddScoped<IMonHocService, MonHocService>();
builder.Services.AddScoped<ILopHocPhanService, LopHocPhanService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "Swagger"));

app.UseAuthorization();

app.MapControllers();

app.Run();
