namespace Example.Features.WeatherForecastCreate
{
  public class WeatherForecastForCreate
  {
    public int Id { get; private set; }

    public DateTime ForecastDate { get; set; }

    public float TemperatureC { get; set; }

    public string? Summary { get; set; }
  }
}