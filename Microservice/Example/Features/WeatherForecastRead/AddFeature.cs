using Example.Features.WeatherForecastRead.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Example.Features.WeatherForecastRead
{
  public static class AddFeature
  {
    public static WebApplicationBuilder AddFeatureWeatherForecastRead(this WebApplicationBuilder builder, 
      string connectionString)
    {
      builder.Services.AddDbContext<WeatherForecastReadDbContext>(option =>
        option.UseSqlite(connectionString));

      return builder;
    }
  }
}
