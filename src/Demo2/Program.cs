using Example.Features.WeatherForecastBrowse;
using Example.Features.WeatherForecastCreate;
using Example.Features.WeatherForecastRead;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder
  .Configuration
  .GetConnectionString("DefaultConnection");


// Add features to the container.
builder
  .AddFeatureWeatherForecastBrowse(connectionString)
  .AddFeatureWeatherForecastCreate(connectionString)
  .AddFeatureWeatherForecastRead(connectionString);


builder.Services.AddControllers();
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
