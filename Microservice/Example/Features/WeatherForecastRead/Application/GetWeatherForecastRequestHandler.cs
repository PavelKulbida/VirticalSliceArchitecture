using ViennaNET.Mediator;
using ViennaNET.Orm.Application;
using ViennaNET.Utils;

namespace Example.Features.WeatherForecastRead.Application
{
  internal class GetWeatherForecastRequestHandler : IMessageHandler<GetWeatherForecastRequest, WeatherForecastForRead>
  {
    private readonly IEntityFactoryService _repositoryFactory;

    public GetWeatherForecastRequestHandler(IEntityFactoryService repositoryFactory)
    {
      _repositoryFactory = repositoryFactory.ThrowIfNull(nameof(repositoryFactory));
    }
    
    public WeatherForecastForRead Handle(GetWeatherForecastRequest message)
    {
      return _repositoryFactory.Create<WeatherForecastForRead>().Get(message.Id);
    }
  }
}
