using Example.Features.WeatherForecastRead.Application;
using Example.Features.WeatherForecastRead.Infrastructure.DataAccess;
using SimpleInjector;
using SimpleInjector.Packaging;
using ViennaNET.Mediator.DefaultConfiguration;
using ViennaNET.Orm.Seedwork;

namespace Example.Features.WeatherForecastRead
{
  public class WeatherForecastReadPackage : IPackage
  {
    public void RegisterServices(Container container)
    {
      container.Collection.Append<IBoundedContext, WeatherForecastReadDbContext>(Lifestyle.Singleton);

      container
        .RegisterHandler<GetWeatherForecastRequest, WeatherForecastForRead,
          GetWeatherForecastRequestHandler>();
    }
  }
}
