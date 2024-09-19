using CarBooking.Application.Features.CQRS.Queries.BrandQueries;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Mapping;
using CarBooking.Core.Entities;
using CarBooking.Persistance.Concrete;
using CarBooking.Persistance.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<CarBookingContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("sqlCon"), b => b.MigrationsAssembly("CarBooking.Persistance"));
});

builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    // Identity options configuration here
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
})
.AddEntityFrameworkStores<CarBookingContext>()
.AddDefaultTokenProviders();

builder.Services.AddControllers();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<ICarReviewRepository, CarReviewRepository>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();



builder.Services.AddAutoMapper(typeof(BrandProfile).Assembly);


builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllBrandQueryRequest).Assembly));






// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
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
