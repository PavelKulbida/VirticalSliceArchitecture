using System.Diagnostics.CodeAnalysis;
using Example.Features.WeatherForecastCreate.Application;
using ViennaNET.Orm;

namespace Example.Features.WeatherForecastCreate.Infrastructure.DataAccess
{
  [ExcludeFromCodeCoverage]
  internal class WeatherForecastCreateDbContext : ApplicationContext
  {
    public WeatherForecastCreateDbContext()
    {
      AddEntity<WeatherForecast>();
    }
  }
}
