using ViennaNET.Mediator;
using ViennaNET.Orm.Application;
using ViennaNET.Utils;

namespace Example.Features.WeatherForecastBrowse.Application
{
  internal class GetWeatherForecastRequestHandler : IMessageHandler<GetAllWeatherForecastRequest, IEnumerable<WeatherForecast>>
  {
    private readonly IEntityFactoryService _repositoryFactory;

    public GetWeatherForecastRequestHandler(IEntityFactoryService repositoryFactory)
    {
      _repositoryFactory = repositoryFactory.ThrowIfNull(nameof(repositoryFactory));
    }


    public IEnumerable<WeatherForecast> Handle(GetAllWeatherForecastRequest message)
    {
      return _repositoryFactory.Create<WeatherForecast>().Query().ToArray();
    }
  }
}
