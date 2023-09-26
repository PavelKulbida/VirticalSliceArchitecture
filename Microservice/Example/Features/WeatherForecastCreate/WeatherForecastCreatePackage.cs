using Example.Features.WeatherForecastCreate.Application;
using Example.Features.WeatherForecastCreate.Infrastructure.DataAccess;
using SimpleInjector;
using SimpleInjector.Packaging;
using ViennaNET.Mediator;
using ViennaNET.Orm.Seedwork;

namespace Example.Features.WeatherForecastCreate
{
  public class WeatherForecastCreatePackage : IPackage
  {
    public void RegisterServices(Container container)
    {
      container.Collection.Append<IBoundedContext, WeatherForecastCreateDbContext>(Lifestyle.Singleton);

      RegisterCommandHandler<WeatherForecastCreateCommand, WeatherForecastCreateCommandHandler>(container);
    }

    private static void RegisterCommandHandler<TCommand, THandler>(Container container)
      where TCommand : class, ICommand
      where THandler : class, IMessageHandler<TCommand>
    {
      container.Collection.Append<IMessageHandler, THandler>(Lifestyle.Singleton);
      container.Collection.Append<IMessageHandler<TCommand>, THandler>(Lifestyle.Singleton);
    }
  }
}
