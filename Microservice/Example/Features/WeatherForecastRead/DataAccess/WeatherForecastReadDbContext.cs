using Microsoft.EntityFrameworkCore;

namespace Example.Features.WeatherForecastRead.DataAccess
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
