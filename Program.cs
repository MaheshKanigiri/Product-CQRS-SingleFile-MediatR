using MediatR;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using Product_CQRS_SingleFile_MediatR.Interface;
using Product_CQRS_SingleFile_MediatR.Models;
using Product_CQRS_SingleFile_MediatR.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Adding Dependency Injection
builder.Services.AddScoped<IProduct, ProductRepository>();
//builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
//builder.Services.AddSingleton<IMediator, Mediator>();
//this Configuration going to work
builder.Services.AddMediatR(typeof(ProductRepository).Assembly);
//Add service for DbConnection
builder.Services.AddDbContext<ProductdbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString(
        "DefaultConnection"));
});

//Add Service for Logging
builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
