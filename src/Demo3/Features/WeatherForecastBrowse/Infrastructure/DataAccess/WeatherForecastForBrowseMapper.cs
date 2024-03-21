using System.Diagnostics.CodeAnalysis;
using Example.Features.WeatherForecastBrowse.Application;
using FluentNHibernate.Mapping;

namespace Example.Features.WeatherForecastBrowse.Infrastructure.DataAccess
{
  [ExcludeFromCodeCoverage]
  internal class WeatherForecastForBrowseMapper : ClassMap<WeatherForecast>
  {
    public WeatherForecastForBrowseMapper()
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
