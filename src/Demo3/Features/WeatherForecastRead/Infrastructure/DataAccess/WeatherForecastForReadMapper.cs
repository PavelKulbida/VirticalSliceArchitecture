using Example.Features.WeatherForecastRead.Application;
using FluentNHibernate.Mapping;

namespace Example.Features.WeatherForecastRead.Infrastructure.DataAccess
{
  internal class WeatherForecastForReadMapper : ClassMap<WeatherForecast>
  {
    public WeatherForecastForReadMapper()
    {
      HibernateMapping.Not.AutoImport();

      Table("WeatherForecast");

      Id(x => x.Id);
      Map(x => x.ForecastDate);
      Map(x => x.TemperatureC);
      Map(x => x.Summary);
    }
  }
}
