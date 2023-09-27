using Example.Features.WeatherForecastBrowse.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Example.Features.WeatherForecastBrowse
{
  public static class AddFeature
  {
    public static WebApplicationBuilder AddFeatureWeatherForecastBrowse(this WebApplicationBuilder builder, 
      string connectionString)
    {
      builder.Services.AddDbContext<WeatherForecastBrowseDbContext>(option =>
        option.UseSqlite(connectionString));

      return builder;
    }
  }
}
