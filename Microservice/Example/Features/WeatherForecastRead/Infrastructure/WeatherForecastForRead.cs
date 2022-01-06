namespace Example.Features.WeatherForecastRead.Infrastructure
{
  public class WeatherForecastForRead
  {
    public int Id { get; private set; }

    public DateTime ForecastDate { get; set; }

    public float TemperatureC { get; set; }

    public double TemperatureF => 32 + (TemperatureC / 0.5556);

    public string? Summary { get; set; }
  }
}