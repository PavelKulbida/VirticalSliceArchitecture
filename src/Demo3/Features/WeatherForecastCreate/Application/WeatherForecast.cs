using ViennaNET.Orm.Seedwork;

namespace Example.Features.WeatherForecastCreate.Application
{
  public class WeatherForecast : IEntityKey<int>
  {
        public virtual int Id { get; }

        public virtual DateTime ForecastDate { get; set; }

        public virtual float TemperatureC { get; set; }

        public virtual string? Summary { get; set; }
    }
}