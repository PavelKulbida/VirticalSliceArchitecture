using Microsoft.EntityFrameworkCore;

namespace Example.DataAccess
{
  public class ServiceDbContext : DbContext
  {
    public DbSet<WeatherForecast> WeatherForecast { get; set; }

    public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options)
    {
    }
  }
}
