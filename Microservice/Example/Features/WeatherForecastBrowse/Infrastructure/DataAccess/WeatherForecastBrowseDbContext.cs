using Microsoft.EntityFrameworkCore;

namespace Example.Features.WeatherForecastBrowse.Infrastructure.DataAccess
{
  public class WeatherForecastBrowseDbContext : DbContext
  {
    public DbSet<WeatherForecastForBrowse> WeatherForecast { get; set; }

    public WeatherForecastBrowseDbContext(DbContextOptions<WeatherForecastBrowseDbContext> options) 
      : base(options)
    {
    }
  }
}
