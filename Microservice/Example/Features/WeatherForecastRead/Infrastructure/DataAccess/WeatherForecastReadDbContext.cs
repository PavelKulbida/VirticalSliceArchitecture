using Microsoft.EntityFrameworkCore;

namespace Example.Features.WeatherForecastRead.Infrastructure.DataAccess
{
  public class WeatherForecastReadDbContext : DbContext
  {
    public DbSet<WeatherForecastForRead> WeatherForecast { get; set; }

    public WeatherForecastReadDbContext(DbContextOptions<WeatherForecastReadDbContext> options) 
      : base(options)
    {
    }
  }
}
