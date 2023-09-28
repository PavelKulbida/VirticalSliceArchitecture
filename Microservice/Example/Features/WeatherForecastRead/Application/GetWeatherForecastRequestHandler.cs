using ViennaNET.Mediator;
using ViennaNET.Orm.Application;
using ViennaNET.Utils;

namespace Example.Features.WeatherForecastRead.Application
{
  internal class GetWeatherForecastRequestHandler : IMessageHandler<GetWeatherForecastRequest, WeatherForecast>
  {
    private readonly IEntityFactoryService _repositoryFactory;

    public GetWeatherForecastRequestHandler(IEntityFactoryService repositoryFactory)
    {
      _repositoryFactory = repositoryFactory.ThrowIfNull(nameof(repositoryFactory));
    }
    
    public WeatherForecast Handle(GetWeatherForecastRequest message)
    {
      return _repositoryFactory.Create<WeatherForecast>().Get(message.Id);
    }
  }
}
