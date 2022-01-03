using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Example.DataAccess
{
  public class ServiceDbContext : DbContext
  {
    public DbSet<WeatherForecast> WeatherForecast { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "database.db" };
      var connectionString = connectionStringBuilder.ToString();
      var connection = new SqliteConnection(connectionString);

      optionsBuilder.UseSqlite(connection);
    }
  }
}
