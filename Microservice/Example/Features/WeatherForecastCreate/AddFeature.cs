using Example.Features.WeatherForecastCreate.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Example.Features.WeatherForecastCreate
{
    public static class AddFeature
  {
    public static WebApplicationBuilder AddFeatureWeatherForecastCreate(this WebApplicationBuilder builder, 
      string connectionString)
    {
      builder.Services.AddDbContext<WeatherForecastCreateDbContext>(option =>
        option.UseSqlite(connectionString));

      return builder;
    }
  }
}
