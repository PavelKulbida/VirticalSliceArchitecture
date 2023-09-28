using System.Diagnostics.CodeAnalysis;
using Example.Features.WeatherForecastBrowse.Application;
using ViennaNET.Orm;

namespace Example.Features.WeatherForecastBrowse.Infrastructure.DataAccess
{
  [ExcludeFromCodeCoverage]
  internal class WeatherForecastBrowseDbContext : ApplicationContext
  {
    public WeatherForecastBrowseDbContext() 
    {
      AddEntity<WeatherForecast>();
    }
  }
}
