using Example.Shared.Application;
using ViennaNET.Orm.Seedwork;

namespace Example.Features.WeatherForecastBrowse.Application
{
    public class WeatherForecastForBrowse : IEntityKey<int>
  {
    public virtual int Id { get; set; }

    public virtual DateTime ForecastDate { get; set; }

    public virtual float TemperatureC { get; set; }

    public virtual double TemperatureF => TemperatureC.ToFahrenheit();

    public virtual string? Summary { get; set; }
  }
}