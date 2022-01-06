using Example.Features.WeatherForecastBrowse.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Example.Features.WeatherForecastBrowse.Infrastructure.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private readonly WeatherForecastBrowseDbContext _dbContext;

    public WeatherForecastController(WeatherForecastBrowseDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    [HttpGet]
    public IEnumerable<WeatherForecastForBrowse> ReadAll()
    {
      return _dbContext.WeatherForecast;
    }
  }
}