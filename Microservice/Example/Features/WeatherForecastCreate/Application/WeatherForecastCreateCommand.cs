using ViennaNET.Mediator;

namespace Example.Features.WeatherForecastCreate.Application
{
  public class WeatherForecastCreateCommand : ICommand
  {
    public bool IsCompleted { get; set; }
    public object Reason { get; set; }

    public WeatherForecast Item { get; private init; }

    public static WeatherForecastCreateCommand Create(WeatherForecast item) => new() { Item = item };
  }
}
