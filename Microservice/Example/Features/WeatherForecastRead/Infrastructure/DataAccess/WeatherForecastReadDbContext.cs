using Example.Features.WeatherForecastRead.Application;
using ViennaNET.Orm;

namespace Example.Features.WeatherForecastRead.Infrastructure.DataAccess
{
  internal class WeatherForecastReadDbContext : ApplicationContext
  {
    public WeatherForecastReadDbContext() 
    {
      AddEntity<WeatherForecastForRead>();
    }
  }
}
