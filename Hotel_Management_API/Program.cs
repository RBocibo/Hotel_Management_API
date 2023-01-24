using Hotel_Management_API.Extensions;
using HotelManagement.Domain.UnitOfWorkInterface;
using HotelManagement.Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterDbContext(builder.Configuration);
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.RegisterAutoMapper();
builder.Services.RegisterRepositories();
builder.Services.RegisterServices();
builder.Services.RegisterCQRSHandlers();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Add API versioning service
builder.Services.AddApiVersioning(config =>
{
    config.AssumeDefaultVersionWhenUnspecified = true;
    config.DefaultApiVersion = new ApiVersion(1, 0);
    config.ReportApiVersions = true;
});

builder.Services.AddVersionedApiExplorer(
    options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
