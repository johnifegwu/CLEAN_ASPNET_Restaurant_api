using CLEANASPNETRestaurant.API.Interfaces;
using CLEANASPNETRestaurant.API.Services;
using CLEANASPNETRestaurant.Infrastructure.Extensions;
using CLEANASPNETRestaurant.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

var app = builder.Build();
var scope = app.Services.CreateScope();
var seed = scope.ServiceProvider.GetRequiredService<IRestaurantSeeder>();
await seed.Seed();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
