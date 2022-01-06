using Microsoft.EntityFrameworkCore;

namespace Example.Features.WeatherForecastCreate.Infrastructure.DataAccess
{
  public class WeatherForecastCreateDbContext : DbContext
  {
    public DbSet<WeatherForecastForCreate> WeatherForecast { get; set; }

    public WeatherForecastCreateDbContext(DbContextOptions<WeatherForecastCreateDbContext> options) 
      : base(options)
    {
    }
  }
}
