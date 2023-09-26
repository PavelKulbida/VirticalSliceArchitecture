using ViennaNET.Mediator;

namespace Example.Features.WeatherForecastBrowse.Application
{
  internal class GetAllWeatherForecastRequest : IRequest
  {
    public static GetAllWeatherForecastRequest Create() => new();
  }
}
