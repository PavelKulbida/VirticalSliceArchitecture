using ViennaNET.Orm.Seedwork;

namespace Example.Features.WeatherForecastCreate.Application
{
    public class WeatherForecastForCreate : IEntityKey<int>
  {
        public virtual int Id { get; et; }

        public virtual DateTime ForecastDate { get; set; }

        public virtual float TemperatureC { get; set; }

        public virtual string? Summary { get; set; }
    }
}