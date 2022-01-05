namespace Example
{
  public class WeatherForecast
  {
    public int Id { get; set; }

    public DateTime ForecastDate { get; set; }

    public float TemperatureC { get; set; }

    public double TemperatureF => 32 + (TemperatureC / 0.5556);

    public string? Summary { get; set; }
  }
}