using System.Reflection;
using Application.Features.Products;
using Application.Helper;
using Application.Interfaces;
using FluentValidation.AspNetCore;
using Infrastructure;
using Infrastructure.Data;
using Infrastructure.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Application.Features.Products.ProductCreate;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddDbContext<DataContext>(opt=>opt.UseSqlServer(config));

//builder.Services.AddControllers();

builder.Services.AddControllers()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ProductCreate>());


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddScoped((typeof(IRepositoryBase<>)),typeof(RepositoryBase<>));
builder.Services.AddAutoMapper(typeof(AutomapperProfile).Assembly);
builder.Services.AddMediatR(typeof(ProductList.Handler).Assembly);

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

using(var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    dbContext.Database.Migrate();
    SeedData.SeedProductCategoryAndUnitData(dbContext);
}

app.Run();
