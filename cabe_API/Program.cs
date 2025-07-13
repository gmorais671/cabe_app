using cabe_API.Business;
using cabe_API.Business.Implementations;
using cabe_API.Models.Context;
using cabe_API.Repository;
using cabe_API.Repository.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MySQLContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 3))));

builder.Services.AddScoped<IProductRepository, ProductRepositoryImplementation>();
builder.Services.AddScoped<IProductBusiness, ProductBusinessImplementation>();
builder.Services.AddScoped<IContactRepository, ContactRepositoryImplementation>();
builder.Services.AddScoped<IContactBusiness, ContactBusinessImplementation>();

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
