using ViennaNET.Mediator;

namespace Example.Features.WeatherForecastBrowse.Application
{
  public class GetAllWeatherForecastRequest : IRequest
  {
    public static GetAllWeatherForecastRequest Create() => new();
  }
}
