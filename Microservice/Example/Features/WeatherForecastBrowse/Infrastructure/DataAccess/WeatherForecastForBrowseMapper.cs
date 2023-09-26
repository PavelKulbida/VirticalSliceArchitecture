using Example.Features.WeatherForecastBrowse.Application;
using FluentNHibernate.Mapping;

namespace Example.Features.WeatherForecastBrowse.Infrastructure.DataAccess
{
  internal class WeatherForecastForBrowseMapper : ClassMap<WeatherForecastForBrowse>
  {
    public WeatherForecastForBrowseMapper()
    {
      Table("WeatherForecast");

      Id(x => x.Id);
      Map(x => x.ForecastDate);
      Map(x => x.TemperatureC);
      Map(x => x.Summary);
    }
  }
}
