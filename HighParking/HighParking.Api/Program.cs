using HighParking.Api;
using HighParking.Core.Repositories;
using HighParking.Core.Services;
using HighParking.Data;
using HighParking.Data.Repositories;
using HighParking.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenApi at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerServices, CustomersService>();
builder.Services.AddScoped<IInvoicingService, InvoicingService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IInvoicingRepository, InvoicingRepository>();
builder.Services.AddSingleton<DataContext>();


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
