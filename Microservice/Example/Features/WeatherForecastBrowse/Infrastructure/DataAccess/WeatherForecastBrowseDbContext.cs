using Example.Features.WeatherForecastBrowse.Application;
using ViennaNET.Orm;

namespace Example.Features.WeatherForecastBrowse.Infrastructure.DataAccess
{
  public class WeatherForecastBrowseDbContext : ApplicationContext
  {
    public WeatherForecastBrowseDbContext() 
    {
      AddEntity<WeatherForecastForBrowse>();
    }
  }
}
