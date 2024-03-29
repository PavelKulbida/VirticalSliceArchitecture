﻿using System.Diagnostics.CodeAnalysis;
using Example.Features.WeatherForecastCreate.Application;
using FluentNHibernate.Mapping;

namespace Example.Features.WeatherForecastCreate.Infrastructure.DataAccess
{
  [ExcludeFromCodeCoverage]
  internal class WeatherForecastForCreateMapper : ClassMap<WeatherForecast>
  {
    public WeatherForecastForCreateMapper()
    {
      HibernateMapping.Not.AutoImport();

      Table("WeatherForecast");

      Id(x => x.Id).GeneratedBy.Identity();

      Map(x => x.ForecastDate);
      Map(x => x.TemperatureC);
      Map(x => x.Summary);
    }
  }
}
