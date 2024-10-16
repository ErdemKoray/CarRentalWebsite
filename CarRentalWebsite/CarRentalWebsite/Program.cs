using CarRentalWebsite.Business;
using CarRentalWebsite.Data;
using CarRentalWebsite.Data.Abstract;
using CarRentalWebsite.Data.Concrete;
using CarRentalWebsite.Models;
using CarRentalWebsite.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICarService,CarService>();
builder.Services.AddScoped(typeof(IBaseRepository<>) , typeof(BaseRepository<>));
builder.Services.AddScoped<ICarRepository , CarRepository>();
builder.Services.AddScoped<IReservationRepository , ReservationRepository>();
builder.Services.AddScoped<IPaymentRepository , PaymentRepository>();
builder.Services.AddScoped<IUserRepository , UserRepository>();

builder.Services.AddDbContext<DataContext>(options => 
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

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
