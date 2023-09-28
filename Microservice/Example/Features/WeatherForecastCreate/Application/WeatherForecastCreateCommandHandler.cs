using ViennaNET.Mediator;
using ViennaNET.Orm.Application;
using ViennaNET.Utils;

namespace Example.Features.WeatherForecastCreate.Application
{
  internal class WeatherForecastCreateCommandHandler : IMessageHandler<WeatherForecastCreateCommand>
  {
    private readonly IEntityFactoryService _repositoryFactory;

    public WeatherForecastCreateCommandHandler(IEntityFactoryService repositoryFactory)
    {
      _repositoryFactory = repositoryFactory.ThrowIfNull(nameof(repositoryFactory));
    }

    public void Handle(WeatherForecastCreateCommand message)
    {
      using var uof = _repositoryFactory.Create();
      var repository = _repositoryFactory.Create<WeatherForecast>();
      repository.Add(message.Item);
      uof.Commit();

      message.IsCompleted = true;
    }
  }
}
