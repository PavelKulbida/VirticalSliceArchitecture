using Example.Features.WeatherForecastBrowse.Application;
using Example.Features.WeatherForecastBrowse.Infrastructure.DataAccess;
using SimpleInjector;
using SimpleInjector.Packaging;
using ViennaNET.Mediator.DefaultConfiguration;
using ViennaNET.Orm.Seedwork;

namespace Example.Features.WeatherForecastBrowse
{
  public class WeatherForecastBrowsePackage : IPackage
  {
    public void RegisterServices(Container container)
    {
      container.Collection.Append<IBoundedContext, WeatherForecastBrowseDbContext>(Lifestyle.Singleton);

      container
        .RegisterHandler<GetAllWeatherForecastRequest, IEnumerable<WeatherForecast>,
          GetWeatherForecastRequestHandler>();
    }
  }
}
