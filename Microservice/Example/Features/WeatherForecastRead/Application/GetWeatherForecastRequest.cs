using ViennaNET.Mediator;

namespace Example.Features.WeatherForecastRead.Application
{
  internal class GetWeatherForecastRequest : IRequest
  {
    public int Id { get; private init; }
    
    public static GetWeatherForecastRequest Create(int id) => new() { Id = id };
  }
}
