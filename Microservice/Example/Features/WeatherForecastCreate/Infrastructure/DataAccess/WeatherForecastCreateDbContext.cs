using Example.Features.WeatherForecastCreate.Application;
using ViennaNET.Orm;

namespace Example.Features.WeatherForecastCreate.Infrastructure.DataAccess
{
  public class WeatherForecastCreateDbContext : ApplicationContext
  {
    public WeatherForecastCreateDbContext()
    {
      AddEntity<WeatherForecastForCreate>();
    }
  }
}
